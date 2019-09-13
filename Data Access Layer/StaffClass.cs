using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class StaffClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public int StaffTable(int StaffId,
            int StaffNo,
            String StaffName,
            String Category,
            int WardNo,
            String Qualification,
            DateTime DOB,
            String Gender,
            String MaritalStatus,
            String BloodGroup,
            DateTime DutyTime,
            DateTime EndTime,
            byte[] Image,
            int Mode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ManageStaffs", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StaffId", StaffId);
                cmd.Parameters.AddWithValue("@StaffNo", StaffNo);
                cmd.Parameters.AddWithValue("@StaffName", StaffName);
                cmd.Parameters.AddWithValue("@Category", Category);
                cmd.Parameters.AddWithValue("@WardNo", WardNo);
                cmd.Parameters.AddWithValue("@Qualification", Qualification);
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@MaritalStatus", MaritalStatus);
                cmd.Parameters.AddWithValue("@BloodGroup", BloodGroup);
                cmd.Parameters.AddWithValue("@DutyTime", DutyTime);
                cmd.Parameters.AddWithValue("@EndTime", EndTime);
                cmd.Parameters.AddWithValue("@Image", Image);
                cmd.Parameters.AddWithValue("@Mode", Mode);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable GetAllStaffs()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from StaffTable", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.Close(); }
        }
    }
}
