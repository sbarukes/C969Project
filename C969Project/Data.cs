using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969Project
{
    class Data
    {
        static public MySqlConnection getConnection()
        {
            MySqlConnection con = new MySqlConnection("server=52.206.157.109;uid=U05dEG;database=U05dEG;pwd=53688472726");
            return con;
        }

        static public void addCity(string city)
        {
            string add = $"SELECT        city, cityId FROM            city WHERE city= '{city}'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(add, getConnection());
            DataSet ds = new DataSet();
            getConnection().Open();
            adapter.Fill(ds);
            getConnection().Close();

            foreach(DataTable table in ds.Tables)
            {
                foreach(DataRow row in table.Rows)
                {
                    foreach(object currentCity in row.ItemArray)
                    {
                        if (currentCity.ToString().Equals(city))
                        {
                            break;
                        }
                        else
                        {
                            //insert city
                        }
                    }
                }
            }
        }
    }
}
