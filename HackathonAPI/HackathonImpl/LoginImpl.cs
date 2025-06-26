using HackathonAPI.Comman;
using HackathonAPI.HackathonDTO;
using HackathonAPI.IHackathon;
using System.Data;
using System.Data.SqlClient;

namespace HackathonAPI.HackathonImpl
{
    public class LoginImpl:ILogin
    {
        string cs = ConnectionString.dbcs;

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
                var value = (int)cmd.ExecuteScalar();               
                con.Close();
                dto.Return = Convert.ToBoolean(value);
            }
            return dto;
        }
    }
}
