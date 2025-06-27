using HackathonAPI.Comman;
using HackathonAPI.HackathonDTO;
using HackathonAPI.IHackathon;
using System.Data;
using System.Data.SqlClient;

namespace HackathonAPI.HackathonImpl
{
    public class AttendanceEntryImpl: IAttendanceEntry
    {
        string cs = ConnectionString.dbcs;
        public AttendanceEntryDTO GetData()
        {
            AttendanceEntryDTO dto = new AttendanceEntryDTO();
            List<AttendanceEntryDTO> list = new List<AttendanceEntryDTO>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("getStaffs", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    AttendanceEntryDTO sd = new AttendanceEntryDTO();
                    sd.StaffId = (int)dr[0];
                    sd.StaffName = (string)dr[1] +' '+ (string)dr[2];
                    list.Add(sd);
                }
                con.Close();
                dto.staffList = list.ToArray();
            }

            List<AttendanceEntryDTO> roleList = new List<AttendanceEntryDTO>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("getAttendanceList", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    AttendanceEntryDTO rd = new AttendanceEntryDTO();
                    rd.StaffId = (int)dr[0];
                    rd.StaffName = (string)dr[1];
                    rd.ShiftDate = (DateTime)dr[2];
                    rd.CheckInTime = (TimeSpan)dr[3];
                    rd.CheckOutTime = (TimeSpan)dr[4];
                    rd.Status = (string)dr[5];
                    rd.Description = (string)dr[6];
                    rd.StaffAttendanceId = (int)dr[7];
                    roleList.Add(rd);
                }
                con.Close();
                dto.attendanceList = roleList.ToArray();
            }

            return dto;
        }

        public AttendanceEntryDTO SaveData(AttendanceEntryDTO dto)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("createAttendance", con);
                cmd.Parameters.Add("@staffId", SqlDbType.VarChar).Value = dto.StaffId;
                cmd.Parameters.Add("@shiftDate", SqlDbType.VarChar).Value = dto.ShiftDate;
                cmd.Parameters.Add("@checkInTime", SqlDbType.VarChar).Value = dto.CheckInTime;
                cmd.Parameters.Add("@checkOutTime", SqlDbType.BigInt).Value = dto.CheckOutTime;
                cmd.Parameters.Add("@status", SqlDbType.Int).Value = dto.Status;
                cmd.Parameters.Add("@description", SqlDbType.Int).Value = dto.Description;
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
