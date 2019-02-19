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
        static int currentUserID = 0;

        static public MySqlConnection getConnection()
        {
            MySqlConnection con = new MySqlConnection("server=52.206.157.109;uid=U05dEG;database=U05dEG;pwd=53688472726");
            return con;
        }

        static public void setCurrentUser(int id)
        {
            currentUserID = id;
        }

        static public int getCurrentUser()
        {
            return currentUserID;
        }

        static public int createNewID(string table)
        {
            MySqlConnection con = getConnection();
            con.Open();
            MySqlCommand com = new MySqlCommand($"SELECT {table + "Id"} FROM {table}", con);
            MySqlDataReader read = com.ExecuteReader();
            List<int> l = new List<int>();

            while (read.Read())
            {
                l.Add(Convert.ToInt32(read[0]));
            }
            read.Close();
            con.Close();
            return newID(l);
        }

        static public int newID(List<int> l)
        {
            int ID = 0;

            foreach(int id in l)
            {
                if(id > ID)
                {
                    ID = id;
                }
            }
            return ID + 1;
        }

        static public void addCustomer(string name, int cityID, string pNumber, string address, string pCode)
        {
            bool status = true;
            DateTime dateToInsert = DateTime.Now;
            MySqlConnection con = getConnection();
            string sqlFormattedDate = dateToInsert.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string add = $"INSERT INTO customer (customerId, customerName, addressID, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('{createNewID("customer")}', '{name}', '{addAddress(address,pNumber,pCode,cityID)}', '{status}', '{sqlFormattedDate}', 'test', '{sqlFormattedDate}', 'test')";

            MySqlCommand com = new MySqlCommand(add, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }


        static public int addAddress(string address, string pNumber, string pCode, int cityID)
        {
            int id = createNewID("address");
            DateTime dateToInsert = DateTime.Now;
            MySqlConnection con = getConnection();
            string sqlFormattedDate = dateToInsert.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string add = $"INSERT INTO address(addressId, address, address2, postalCode, phone, createDate, createdBy, cityId, lastUpdateBy, lastUpdate) VALUES ('{id}', '{address}', 'N/A', '{pCode}', '{pNumber}', '{sqlFormattedDate}', 'test', '{cityID}', 'test', '{sqlFormattedDate}')";

            MySqlCommand com = new MySqlCommand(add, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

            return id;
            
        }

        static public void updateCus(int cusid, string name, int addressID, string pNumber, string address, string pCode, int cityID)
        {
            MySqlConnection con = getConnection();
            DateTime dateToUpdate = DateTime.Now;
            string sqlFormattedDate = dateToUpdate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string update = $"UPDATE customer AS c INNER JOIN address  AS a ON c.addressId = c.addressId SET c.customerName = '{name}', c.lastUpdate = '{sqlFormattedDate}', a.address = '{address}', a.phone = '{pNumber}', a.postalCode = '{pCode}', a.cityId = '{cityID}' WHERE c.customerId = '{cusid}' AND a.addressId = '{addressID}'";

            MySqlCommand com = new MySqlCommand(update, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

    }
}
