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
    public partial class SysManagement : Form
    {
        public SysManagement()
        {
            InitializeComponent();
        }
        DateTime dateTime = DateTime.Now;


        private void btnClosedManagement_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //UserControl pages
        private void add_UControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(userControl);
            userControl.BringToFront();

        }


        private void Btn_Click(object sender, EventArgs e)
        {

            foreach (var pnl in tableLayoutPanel1.Controls.OfType<Panel>())
            {
                pnl.BackColor = SystemColors.ActiveCaption;
            }
            Button btn = (Button)sender;
            switch (btn.Name)
            {


                case "btnReservationList":
                    add_UControls(new UC_Rl());
                    pnlReservationList.BackColor = Color.MediumSeaGreen;

                    break;
                case "btnTableState":
                    add_UControls(new UC_Ts());
                    pnlTableState.BackColor = Color.MediumSeaGreen;

                    break;
                default: break;



            }



        }


    }
}
