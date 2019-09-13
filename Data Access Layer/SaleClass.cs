using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
   public class SaleClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public int SaleTable(int SaleId,
            int VisitorNo,
            String PatientName,
            int ReferringNo,
            String DoctorName,
            String ReferredMedicines,
            int SalesPrice,
            int Quantity,
            int TotalPrice,
            byte[] Image1,
            byte[] Image2,
            int Mode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ManageSales", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SaleId", SaleId);
                cmd.Parameters.AddWithValue("@VisitorNo", VisitorNo);
                cmd.Parameters.AddWithValue("@PatientName", PatientName);
                cmd.Parameters.AddWithValue("@ReferringNo", ReferringNo);
                cmd.Parameters.AddWithValue("@DoctorName", DoctorName);
                cmd.Parameters.AddWithValue("@ReferredMedicines", ReferredMedicines);
                cmd.Parameters.AddWithValue("@SalesPrice", SalesPrice);
                cmd.Parameters.AddWithValue("@Quantity", Quantity);
                cmd.Parameters.AddWithValue("@TotalPrice", TotalPrice);
                cmd.Parameters.AddWithValue("@Image1", Image1);
                cmd.Parameters.AddWithValue("@Image2", Image2);
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
        public DataTable GetAllSales()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from SaleTable", conn);
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
