using ReservationManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationManagement
{
    public partial class CreateReservation : Form
    {
        public CreateReservation(int ti, string tn, string dt)
        {
            InitializeComponent();
            this.tableName = tn;
            this.tableid = ti;
            //this.TopMost = true;
            this.dateTime = dt;
        }
        public string tableName { get; set; }
        public int tableid { get; set; }

        public string dateTime { get; set; }



        static DateTime currentDate = DateTime.Now;
        TimeSpan time = currentDate.TimeOfDay;
        DateTime useDate;

        string hour;
        string Minute;
        private void CreateReservation_Load(object sender, EventArgs e)
        {
            lblTableNo.Text = tableid.ToString();
            lblTableName.Text = tableName;
            useDate = currentDate;
            //myDatabase.GetTables();
            lblSelectedDate.Text = $" {dateTime}";
            Button button = new Button();
            button.Text = "OK";



            for (int i = 9; i < 23; i++)
            {
                hour = i.ToString("D2");
                cbxHour.Items.Add(hour);
            }

            for (int i = 0; i <= 55; i += 5)
            {
                Minute = i.ToString("D2");
                cbxMinute.Items.Add(Minute);
            }


        }

        private void btnClosedManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        UC_Ts uC_Ts = new UC_Ts();
        private void button1_Click(object sender, EventArgs e)
        {


            this.Hide();
        }
        Reservation Reservation = new Reservation();
        myDatabase myDatabase = new myDatabase();
        private void btnBookaTable_Click(object sender, EventArgs e)
        {
            //Reservasyon işlemleri ---------------------------------------------

            try
            {
                if (string.IsNullOrWhiteSpace(cbxHour.Text) || string.IsNullOrWhiteSpace(cbxMinute.Text))
                {
                    MessageBox.Show("Lütfen Reservasyon saati seçin");
                }
                if (string.IsNullOrWhiteSpace(lblSelectedDate.Text) || string.IsNullOrWhiteSpace(lblSelectedTime.Text) || string.IsNullOrWhiteSpace(cbxHour.Text) || string.IsNullOrWhiteSpace(cbxMinute.Text) || string.IsNullOrWhiteSpace(tbxDescription.Text) || string.IsNullOrWhiteSpace(tbxResName.Text))
                {
                    MessageBox.Show("Lütfen gerekli alanları doldurun");

                }
                else
                {
                    myDatabase.Add(new Reservation()
                    {
                        tableId = Convert.ToInt32(lblTableNo.Text),
                        reservedName = tbxResName.Text.ToString().Trim(),
                        date = DateTime.Parse(lblSelectedDate.Text),
                        time = Time,
                        description = tbxDescription.Text.Trim(),

                    });
                    MessageBox.Show("Kayıt Başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();



                }
            }
            catch (ArgumentNullException)
            {

                MessageBox.Show("Lütfen gerekli alanları doldurun");
            }



        }
        DateTime Time;
        string selectTheTime;
        private void btnVisit_Click(object sender, EventArgs e)
        {
            currentDate = DateTime.Now;


            lblSelectedTime.Text = $" {cbxHour.SelectedItem}:{cbxMinute.SelectedItem}";
            selectTheTime = lblSelectedTime.Text;
            if (DateTime.TryParse(selectTheTime, out Time))
            {
                for (int i = 1;i <= 7; i++)
                
                {
                    if (Time.Hour < currentDate.Hour && Convert.ToDateTime(lblSelectedDate.Text).ToString("dd/MM/yyyy") == currentDate.ToString("dd/MM/yyyy"))
                    {

                        lblSelectedTime.Text = "Select Time";
                        MessageBox.Show("Geçmiş bir saati seçemezsiniz.");
                        break;

                    }
                   else if(Time.Hour.ToString() == cbxHour.Items[cbxHour.Items.Count - 1].ToString() && Time.Minute.ToString() != "0" )
                    {
                       

                        MessageBox.Show("Mesai saatlerini aştınız.");
                        break;

                    }
                    else if (lblSelectedDate.Text.ToString() == currentDate.ToShortDateString())
                    {
                        if (int.Parse(cbxHour.Items[cbxHour.Items.Count - 1].ToString()) <= int.Parse(currentDate.Hour.ToString()) && Time.Minute.ToString() != "0")
                        {
                            MessageBox.Show("Mesai saatlerini aştınız.");
                            break;
                        }
                        
                    }
                    
                    else
                    {
                        MessageBox.Show("Saat Ayarlandı.");

                        Time = DateTime.Parse(selectTheTime);
                        break;
                    }


                }



            }



        }


    }
}
