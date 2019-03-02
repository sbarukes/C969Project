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
        static DataSet calandarDataset;

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

        static public void setCalendarSet(DataSet set)
        {
            calandarDataset = set;
        }

        static public DataSet getCalandarSet()
        {
            return calandarDataset;
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

        static public void addAppointment(int cusid, string title, string description, string location, string contact, string url, DateTime start, DateTime end, string type, int userid)
        {
            MySqlConnection con = getConnection();
            DateTime dateToAdd = DateTime.Now;
            DateTime startUni = start.ToUniversalTime();
            DateTime endUni = end.ToUniversalTime();

            string sqlFormattedDateEnd = endUni.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string sqlFormattedDateStart = startUni.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string sqlFormattedDateAdd = dateToAdd.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string add = $"INSERT INTO appointment(appointmentId, customerId, title, description, location, contact, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy, type, userId) VALUES ('{createNewID("appointment")}', '{cusid}', '{title}', '{description}', '{location}', '{contact}', '{url}', '{sqlFormattedDateStart}', '{sqlFormattedDateEnd}', '{sqlFormattedDateAdd}', 'test', '{sqlFormattedDateAdd}', 'test', '{type}', '{userid}')";

            MySqlCommand com = new MySqlCommand(add, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        static public void updateAppointment(int appID, string title, string description, string location, string contact, string url, DateTime start, DateTime end, string type)
        {
            MySqlConnection con = getConnection();
            DateTime dateToAdd = DateTime.Now;
            DateTime startUni = start.ToUniversalTime();
            DateTime endUni = end.ToUniversalTime();

            string sqlFormattedDateEnd = endUni.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string sqlFormattedDateStart = startUni.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string sqlFormattedDateAdd = dateToAdd.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string update = $"UPDATE appointment " +
                $"SET title = '{title}', " +
                $"description = '{description}', " +
                $"location = '{location}', " +
                $"contact = '{contact}', " +
                $"url = '{url}', " +
                $"start = '{sqlFormattedDateStart}', " +
                $"end = '{sqlFormattedDateEnd}', " +
                $"lastUpdate = '{sqlFormattedDateAdd}', " +
                $"lastUpdateBy = 'test', " +
                $"type = '{type}' " +
                $"WHERE appointmentId = '{appID}'";

            MySqlCommand com = new MySqlCommand(update, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        //Method to check for overlapping times
        static public bool checkCalandar(DateTime overlapCheckStart, DateTime overlapCheckEnd)
        {
            foreach(DataTable table in calandarDataset.Tables)
            {
                foreach(DataRow row in table.Rows)
                {
                    if(((DateTime)row.ItemArray[7] >= overlapCheckStart && (DateTime)row.ItemArray[7] <= overlapCheckEnd) || ((DateTime)row.ItemArray[8] >= overlapCheckStart && (DateTime)row.ItemArray[8] <= overlapCheckEnd))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
