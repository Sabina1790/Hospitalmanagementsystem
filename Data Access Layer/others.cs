using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
   public class others
    {
            SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
            public int Others(int Id,
                String AmbulanceDriver,
                int Contact,
                int Doctorsfee,
                int Staffsfee,
                DateTime Date,
                int Mode)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_ManageOthers", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@AmbulanceDriver", AmbulanceDriver);
                    cmd.Parameters.AddWithValue("@Contact", Contact);
                    cmd.Parameters.AddWithValue("@Doctorsfee", Doctorsfee);
                    cmd.Parameters.AddWithValue("@Staffsfee", Staffsfee);
                    cmd.Parameters.AddWithValue("@Date", Date);
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
            public DataTable GetAllOthers()
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("Select * from Others", conn);
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
