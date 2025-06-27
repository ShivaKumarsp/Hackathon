using HackathonAPI.Comman;
using HackathonAPI.HackathonDTO;
using HackathonAPI.IHackathon;
using System.Data;
using System.Data.SqlClient;

namespace HackathonAPI.HackathonImpl
{
    public class ShiftScheduleImpl: IShiftSchedule
    {
        string cs = ConnectionString.dbcs;
        public ShiftScheduleDTO getroleList()
        {
            ShiftScheduleDTO dto = new ShiftScheduleDTO();
            List<ShiftScheduleDTO> list = new List<ShiftScheduleDTO>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("getRole", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ShiftScheduleDTO sd = new ShiftScheduleDTO();
                    sd.RoleId = (int)dr[0];
                    sd.RoleName = (string)dr[1];
                    list.Add(sd);
                }
                con.Close();
                dto.roleList = list.ToArray();
            }
            return dto;
        }

        public ShiftScheduleDTO getStaffList(int id)
        {
            ShiftScheduleDTO dto = new ShiftScheduleDTO();
            List<ShiftScheduleDTO> list = new List<ShiftScheduleDTO>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("getStaffUserByRoleId", con);
                cmd.Parameters.Add("@roleId", SqlDbType.Int).Value = id;
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ShiftScheduleDTO sd = new ShiftScheduleDTO();
                    sd.StaffId = (int)dr[0];
                    sd.StaffName = (string)dr[1];
                    list.Add(sd);
                }
                con.Close();
                dto.staffList = list.ToArray();
            }
            return dto;
        }

        public ShiftScheduleDTO SaveData(ShiftScheduleDTO dto)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("insertshiftschedules", con);
                cmd.Parameters.Add("@staffId", SqlDbType.Int).Value = dto.StaffId;
                cmd.Parameters.Add("@shiftId", SqlDbType.Int).Value = dto.ShiftId;
                cmd.Parameters.Add("@shiftDate", SqlDbType.DateTime).Value = dto.ShiftDate;
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
