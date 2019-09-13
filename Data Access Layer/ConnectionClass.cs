using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Data_Access_Layer
{
    public class ConnectionClass
    {
        //connect to database for storing the information and data 

        public static String ConnectionString
        {
            get { return "Data Source=DESKTOP-FTV0E4C;Initial Catalog=hospitalmanagementsystem;Integrated Security=True"; }

        }
    }
}
