using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class CabinClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public int CabinTable(int CabinId,
            int CabinNo,
            int RoomNo,
            String CabinType,
            String Doctor,
            String Staff,
            int Mode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ManageCabins", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CabinId", CabinId);
                cmd.Parameters.AddWithValue("@CabinNo", CabinNo);
                cmd.Parameters.AddWithValue("@RoomNo", RoomNo);
                cmd.Parameters.AddWithValue("@CabinType", CabinType);
                cmd.Parameters.AddWithValue("@Doctor", Doctor);
                cmd.Parameters.AddWithValue("@Staff", Staff);
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
        public DataTable GetAllCabins()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from CabinTable", conn);
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
