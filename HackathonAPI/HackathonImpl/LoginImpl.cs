using HackathonAPI.Comman;
using HackathonAPI.HackathonDTO;
using HackathonAPI.IHackathon;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.Data.SqlClient;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace HackathonAPI.HackathonImpl
{
    public class LoginImpl : ILogin
    {
        string cs = ConnectionString.dbcs;
        public readonly IConfiguration _configuration;

        public LoginImpl(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public LoginDTO Login(LoginDTO dto)
        {
          
        

            List<LoginDTO> list = new List<LoginDTO>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("getLoginDetails", con);
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = dto.UserName;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = dto.Password;
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
               SqlDataReader dr= cmd.ExecuteReader();
                while (dr.Read())
                {
                    LoginDTO sd = new LoginDTO();
                    sd.UserId = (int)dr[0];
                    sd.UserName = (string)dr[1];
                    list.Add(sd);
                }
                con.Close();
                dto.userList = list.ToArray();
                                        
            }

            if (dto.userList.Length>0)
            {
                var issuer = _configuration["JWTConfig:Issuer"];
                var audiance = _configuration["JWTConfig:Audiance"];
                var key = _configuration["JWTConfig:Key"];
                var tokenValidate = _configuration.GetValue<int>("JWTConfig:Expires");
                var tokenExpire = DateTime.UtcNow.AddHours(tokenValidate);

                var tokenDescription = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[]
                    {
                            new Claim(JwtRegisteredClaimNames.Name, dto.UserName)
                        }),
                    Expires = tokenExpire,
                    Issuer = issuer,
                    Audience = audiance,
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)), SecurityAlgorithms.HmacSha256Signature),
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDescription);
                var accessToken = tokenHandler.WriteToken(securityToken);
                dto.AccessToken= accessToken;
                dto.ExpireIn = (int)tokenExpire.Subtract(DateTime.UtcNow).TotalHours;
            }
            return dto;
        }
    }
}
