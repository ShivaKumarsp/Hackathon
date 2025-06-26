using HackathonAPI.Comman;
using HackathonAPI.HackathonDTO;
using HackathonAPI.IHackathon;
using System.Data;
using System.Data.SqlClient;

namespace HackathonAPI.HackathonImpl
{
    public class StaffImpl:IStaff
    {
        string cs = ConnectionString.dbcs;
        public StaffDTO GetData()
        {
            StaffDTO dto = new StaffDTO();
            List<StaffDTO> list = new List<StaffDTO>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("getStaffs", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    StaffDTO sd = new StaffDTO();
                    sd.StaffId = (int)dr[0];
                    sd.FirstName = (string)dr[1];
                    sd.LastName = (string)dr[2];
                    sd.Email = (string)dr[3];
                    sd.Mobile = (int)dr[4];
                    sd.RoleId = (int)dr[5];
                    list.Add(sd);
                }
                con.Close();
                dto.staffList = list.ToArray();
            }

            List<RoleDTO> roleList = new List<RoleDTO>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("getRole", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    RoleDTO rd = new RoleDTO();
                    rd.RoleId = (int)dr[0];
                    rd.RoleName = (string)dr[1];
                    roleList.Add(rd);
                }
                con.Close();
                dto.roleList = roleList.ToArray();
            }

            return dto;
        }

        public StaffDTO SaveData(StaffDTO dto)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("createStaff", con);
                cmd.Parameters.Add("@firstName", SqlDbType.VarChar).Value = dto.FirstName;
                cmd.Parameters.Add("@lastName", SqlDbType.VarChar).Value = dto.LastName;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = dto.Email;
                cmd.Parameters.Add("@mobile", SqlDbType.BigInt).Value = dto.Mobile;
                cmd.Parameters.Add("@roleId", SqlDbType.Int).Value = dto.RoleId;
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                int id = cmd.ExecuteNonQuery();
                con.Close();
                if (id > 0)
                {
                    dto.response = "Success";
                }
                else
                {
                    dto.response = "Faile";
                }
            }
            return dto;
        }
    }
}
