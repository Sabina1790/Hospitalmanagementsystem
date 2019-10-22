using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
   public class MedicineClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public int MedicinesTable(int MedicineId,
            int VisitorNo,
            String PatientName,
            String DoctorName,
            String ReferredMedicines,
            DateTime MfgDate,
            DateTime ExpiredDate,
            String SupplierName,
            String CompanyName,
            int Mode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ManageMedicines", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MedicineId", MedicineId);
                cmd.Parameters.AddWithValue("@VisitorNo", VisitorNo);
                cmd.Parameters.AddWithValue("@PatientName", PatientName);
                cmd.Parameters.AddWithValue("@DoctorName", DoctorName);
                cmd.Parameters.AddWithValue("@ReferredMedicines", ReferredMedicines);
                cmd.Parameters.AddWithValue("@MfgDate", MfgDate);
                cmd.Parameters.AddWithValue("@ExpiredDate", ExpiredDate);
                cmd.Parameters.AddWithValue("@SupplierName", SupplierName);
                cmd.Parameters.AddWithValue("@CompanyName", CompanyName);
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
        public DataTable GetAllmedicines()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from MedicinesTable", conn);
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
