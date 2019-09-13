using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
  public class PatientClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public int PatientTable(int PatientId,
            int VisitorNo,
            String Title,
            String PatientName,
            String Address,
            int ContactNo,
            DateTime DOB,
            String Gender,
            String PatientType,
            String MaritialStatus,
            String BloodGroup,
            byte[] Image,
            int Mode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ManagePatients", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PatientId", PatientId);
                cmd.Parameters.AddWithValue("@VisitorNo", VisitorNo);
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@PatientName", PatientName);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@ContactNo", ContactNo);
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@PatientType", PatientType);
                cmd.Parameters.AddWithValue("@MaritialStatus", MaritialStatus);
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
        public DataTable GetAllPatients()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from PatientTable", conn);
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
