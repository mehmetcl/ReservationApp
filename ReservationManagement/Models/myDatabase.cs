using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Media.Animation;
using System.Windows.Documents;
using System.Windows.Input;
using System.Xml.Linq;

namespace ReservationManagement.Models
{
    public class myDatabase
    {
        public myDatabase()
        {


        }

        //---------------------------------------------------------------------------------------------------------------------
        SqlConnection _connection = new SqlConnection("Data Source=CLM;Initial Catalog=Reservation;Integrated Security=True");
        Reservation Reservation = new Reservation();
        //---------------------------------------------------------------------------------------------------------------------
        
        public List<Tables> GetTables()
        {
            ConnectionControl();
            SqlCommand cmd = new SqlCommand("SELECT * from Tables", _connection);

            SqlDataReader reader = cmd.ExecuteReader();



            List<Tables> sqldata = new List<Tables>();

            while (reader.Read())
            {
                Tables tableRow = new Tables()
                {
                    Name = reader["Name"].ToString(),
                    TableId = Convert.ToInt32(reader["id"])
                };




                {



                };
                sqldata.Add(tableRow);
            }

            reader.Close();
            _connection.Close();
            return sqldata;
        }
        public List<Tables> GetTableName()
        {
            ConnectionControl();
            SqlCommand cmd = new SqlCommand("SELECT * from Tables ", _connection);

            SqlDataReader reader = cmd.ExecuteReader();



            List<Tables> restables = new List<Tables>();

            while (reader.Read())
            {
                Tables tableRow = new Tables()
                {

                    Name = reader["Name"].ToString(),
                    TableId = Convert.ToInt32(reader["id"]),
                };
                restables.Add(tableRow);
            }

            reader.Close();
            _connection.Close();
            return restables;
        }

        public List<Reservation> GetJoin()
        {
            ConnectionControl();
            SqlCommand cmd = new SqlCommand(@"
                SELECT R.*, T.Name AS TableName
                FROM Reservation AS R
                JOIN Tables AS T ON T.id = R.TableId", _connection);

            SqlDataReader reader = cmd.ExecuteReader();



            List<Reservation> restables = new List<Reservation>();

            while (reader.Read())
            {
                Reservation tableRow = new Reservation();

                if (int.TryParse(reader["id"].ToString(), out int id))
                {

                    tableRow.ResId = id;

                }

                if (int.TryParse(reader["tableId"].ToString(), out int TableId))
                {
                    tableRow.tableId = TableId;

                }

                tableRow.reservedName = reader["ReservationName"].ToString();

                if (DateTime.TryParse(reader["Date"].ToString(), out DateTime date))
                {
                    tableRow.date = date;
                }

                if (DateTime.TryParse(reader["Time"].ToString(), out DateTime time))
                {
                    tableRow.time = time;
                }

                tableRow.description = reader["Description"].ToString();

                tableRow.tableName = reader["TableName"].ToString();
                restables.Add(tableRow);
            }

            reader.Close();
            _connection.Close();
            return restables;
        }

        public List<CustomerTable> GetReserverName()
        {
            ConnectionControl();
            SqlCommand cmd = new SqlCommand(@"
                SELECT r.ReservationName,r.Date,r.Time, t.Name
                FROM Reservation AS r
                JOIN Tables AS t ON t.id = r.TableId;", _connection);

            SqlDataReader reader = cmd.ExecuteReader();



            List<CustomerTable> restables = new List<CustomerTable>();

            while (reader.Read())
            {
                CustomerTable tableRow = new CustomerTable();

                tableRow.ReservationName = reader["ReservationName"].ToString();
                tableRow.TableName = reader["Name"].ToString();

                if (DateTime.TryParse(reader["Date"].ToString(), out DateTime date))
                {
                    tableRow.ReservationDate = date;
                }

                if (DateTime.TryParse(reader["Time"].ToString(), out DateTime time))
                {
                    tableRow.ReservationTime = time;
                }

                restables.Add(tableRow);
            }

            reader.Close();
            _connection.Close();
            return restables;
        }



        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Reservation where id=@id", _connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            _connection.Close();

        }



        //--------------------------------------------------------------------------------------
        public void Add(Reservation reservation)
        {
            ConnectionControl();
            SqlCommand cmd = new SqlCommand("INSERT INTO Reservation (TableId, ReservationName, Date, Time, Description) VALUES (@TableId, @ReservationName, @Date, @Time, @Description)", _connection);

            cmd.Parameters.AddWithValue("@TableId", reservation.tableId);
            cmd.Parameters.AddWithValue("@ReservationName", reservation.reservedName);
            cmd.Parameters.AddWithValue("@Date", reservation.date);
            cmd.Parameters.AddWithValue("@Time", reservation.time);
            cmd.Parameters.AddWithValue("@Description", reservation.description);

            cmd.ExecuteNonQuery();
            _connection.Close();
        }

        public void AddTable(Tables table)
        {
            ConnectionControl();
            SqlCommand cmd = new SqlCommand("Insert into Tables values(@Name)", _connection);

            cmd.Parameters.AddWithValue("@Name,", table.Name);

            cmd.ExecuteNonQuery();
            _connection.Close();

        }



        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }

        }

    }
}
