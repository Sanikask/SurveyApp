using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SurevyApp
{
    class Class1

    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-VU8DLKEQ;Initial Catalog=master;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        SqlCommandBuilder cmdb;
        DataSet ds;
        public int add_data(string name, string age,string gender,string profession,string highest_qualification,string height,string weight,string sleep_hours,string screen_time,string exercise,int score)
        {

            string str = "insert into User_data1 values('" + name + "','" + age + "','" + gender + "','" + profession + "','" + highest_qualification + "','" + height + "','" + weight + "','" + sleep_hours + "','" + screen_time + "','" + exercise + "','" + score +" ')";
            cmd = new SqlCommand(str, con);
            con.Open();
            int no = cmd.ExecuteNonQuery();
            con.Close();
            return (no);

        }
    }
}
