using ReservationManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;

namespace ReservationManagement
{
    public partial class UC_Ts : UserControl
    {

        public UC_Ts()
        {
            InitializeComponent();



        }
        DateTime CurrentDate = DateTime.Now;
        DateTime useDate;
        DateTime Sendtime;
        Reservation reservation = new Reservation();
        private void lblDateTime_TextChanged(object sender, EventArgs e)
        {
            Control(useDate);
        }

        private void Control(DateTime dateTime)
        {
            myDatabase myDatabase = new myDatabase();
            List<CustomerTable> customerTables = myDatabase.GetReserverName();
            List<Reservation> reservations = myDatabase.GetJoin();
            foreach (Control control in grbTables.Controls)
            {
                if (control is Button button)
                {
                    string buttonTag = button.Tag.ToString();

                    if (reservations.Any(r => r.tableName == buttonTag && r.date.Date == dateTime.Date))
                    {
                        Reservation reservation = reservations.FirstOrDefault(r => r.tableName == buttonTag && r.date.Date == dateTime.Date);

                        if (reservation != null)
                        {
                            button.Text = $"{reservation.tableName.ToUpper()} {reservation.reservedName} ";
                            button.BackColor = Color.Red;
                            button.Enabled = false;


                        }
                    }
                    else
                    {
                        button.BackColor = Color.GreenYellow;
                        button.Text = "Available";
                        button.Enabled = true;
                    }
                }
            }
        }



    
        DateTime reserDate = DateTime.Now;
     

        private void UC_Ts_Load(object sender, EventArgs e)
        {
            useDate = CurrentDate;
            btnPrevious.Enabled = false;
            lblDateTime.Text = useDate.ToShortDateString();
            lblDateTime.TextChanged += lblDateTime_TextChanged;
            Control(useDate);



        }
        string sendTableName = null;
        int sendTableId = 0;

        private void btnTable2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            myDatabase myDatabase = new myDatabase();
            List<Tables> tables = myDatabase.GetTableName();




        
            List<Reservation> reservations = myDatabase.GetJoin();
            foreach (Control control in grbTables.Controls)
            {

                if (control is Button buttons)
                {
                    foreach (Tables table1 in tables)
                    {
                        if (table1.Name == button.Tag.ToString())
                        {
                            sendTableId = table1.TableId;
                            sendTableName = table1.Name;
                        }
                    }
                }
            }
            Sendtime = DateTime.Parse(lblDateTime.Text);
            CreateReservation createReservation = new CreateReservation(sendTableId, sendTableName, Sendtime.ToString());
            createReservation.Show();





        }




        myDatabase myDatabase = new myDatabase();
        private void btnNext_Click_1(object sender, EventArgs e)
        {
            useDate = useDate.AddDays(1);
            lblDateTime.Text = useDate.ToShortDateString();
            btnPrevious.Enabled = true;

            if (CurrentDate.AddDays(7) == useDate)
            {
                btnNext.Enabled = false;
            }

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            useDate = useDate.AddDays(-1);
            lblDateTime.Text = useDate.ToShortDateString();
            btnNext.Enabled = true;
            if (CurrentDate == useDate)
            {

                btnPrevious.Enabled = false;
            }

        }
    }
}





