using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class DoctorClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public int DoctorTable(int DoctorId,
            int ReferringNo,
            String FirstName,
            String LastName,
            String Speciality,
            int ContactNo,
            DateTime DOB,
            String Gender,
            String Address,
            String ReferringRate,
            String BloodGroup,
            byte[] Image,
            int Mode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ManagePatients", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DoctorId", DoctorId);
                cmd.Parameters.AddWithValue("@ReferringNo", ReferringNo);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@lastName", LastName);
                cmd.Parameters.AddWithValue("@Speciality", Speciality);
                cmd.Parameters.AddWithValue("@ContactNo", ContactNo);
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@ReferringRate", ReferringRate);
                cmd.Parameters.AddWithValue("@BloodGroup", BloodGroup);
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
        public DataTable GetAllDoctors()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from DoctorTable", conn);
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
