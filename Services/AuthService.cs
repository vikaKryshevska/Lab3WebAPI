using Lab3WebAPI.Entities;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BC = BCrypt.Net.BCrypt;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace Lab3WebAPI.Services
{
    public class AuthService
    {


        private readonly TelephoneDbContext dataContext;
        private readonly IConfiguration configuration;

        public AuthService(TelephoneDbContext dataContext, IConfiguration configuration)
        {
            this.dataContext = dataContext;
            this.configuration = configuration;
        }

        public bool IsAuthenticated(string name, string password)
        {
            var user = this.GetByName(name);
            return this.DoesSubscribersExists(name) && BC.Verify(password, user.Password);
        }

        public bool DoesSubscribersExists(string name)
        {
            var user = this.dataContext.Subscribers.FirstOrDefault(x => x.Name == name);
            return user != null;
        }

        public Subscriber GetByName(string name)
        {
            return this.dataContext.Subscribers.FirstOrDefault(c => c.Name == name);
        }

        public Subscriber GetById(int id)
        {
            return this.dataContext.Subscribers.FirstOrDefault(c => c.Id == id);
        }
        public Subscriber[] GetAll()
        {
            return this.dataContext.Subscribers.ToArray();
        }


        public Subscriber RegisterUser(Subscriber model)
        {
            var name = IdGenerator.CreateLetterName(10);
            var existWithId = this.GetByName(name);
            while (existWithId != null)
            {
                name = IdGenerator.CreateLetterName(10);
                existWithId = this.GetByName(name);
            }
            model.Name = name;
            model.Password = BC.HashPassword(model.Password);

            var userEntity = this.dataContext.Subscribers.Add(model);
            this.dataContext.SaveChanges();

            return userEntity.Entity;
        }




        public string GenerateJwtToken(string email, string role)
        {
            var issuer = this.configuration["Jwt:Issuer"];
            var audience = this.configuration["Jwt:Audience"];
            var key = Encoding.ASCII.GetBytes(this.configuration["Jwt:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                        {
                    new Claim("Id", Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Sub, email),
                        new Claim(JwtRegisteredClaimNames.Email, email),
                        new Claim(ClaimTypes.Role, role),
                        new Claim(JwtRegisteredClaimNames.Jti,
                            Guid.NewGuid().ToString())
                }),
                Expires = DateTime.UtcNow.AddMinutes(5),
                Issuer = issuer,
                Audience = audience,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
            };

            var tokenHandler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        public string DecodeNameFromToken(string token)
        {
            var decodedToken = new JwtSecurityTokenHandler();
            var indexOfTokenValue = 7;

            var t = decodedToken.ReadJwtToken(token.Substring(indexOfTokenValue));

            return t.Payload.FirstOrDefault(x => x.Key == "name").Value.ToString();
        }

        public Subscriber ChangeRole(string name, string role)
        {
            var user = this.GetByName(name);
            user.Role = role;
            this.dataContext.SaveChanges();


            return user;
        }



    }
}
