using ReservationManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationManagement
{
    public partial class UC_Rl : UserControl
    {
        public UC_Rl()
        {
            InitializeComponent();
          
        }
        myDatabase myDatabase = new myDatabase();
        List<Tables> tables = new List<Tables>();
        private void UC_Rl_Load(object sender, EventArgs e)
        {

            LoadReservation();
        ;
            this.Refresh();
        }

        private void LoadReservation()
        {
            DataGridView.DataSource = myDatabase.GetJoin();
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(DataGridView.CurrentRow.Cells[0].Value);
            tbxId.Text = id.ToString();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DataGridView.CurrentRow.Cells[0].Value);
            tbxId.Clear();  
            myDatabase.Delete(id);
            LoadReservation();
            MessageBox.Show($"Deleted{id}!");
        }
    }
}
