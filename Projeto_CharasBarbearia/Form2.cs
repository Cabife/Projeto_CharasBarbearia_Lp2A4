using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_CharasBarbearia
{
    public partial class SMENU : Form
    {
        public SMENU()
        {
            InitializeComponent();

            IMAGELOGO.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void IMAGELOGO_Click(object sender, EventArgs e)
        {           
        }

        private void LB_Menu_Home_Click(object sender, EventArgs e)
        { 
        }

        private void BT_Schedule_Click(object sender, EventArgs e)
        {
           //Instancia tela de agendamento
           SSCHEDULE sSCHEDULE = new SSCHEDULE();

           this.Close();

           sSCHEDULE.Show();

        }

        private void BT_Dashboard_Click(object sender, EventArgs e)
        {
            //Instancia tela de dashboard
            SDASHBOARD sDASHBOARD = new SDASHBOARD();

            this.Close();

            sDASHBOARD.Show();
        }

        private void BT_Customers_Click(object sender, EventArgs e)
        {
            //Instacia tela customers 
            SCUSTOMERS sCUSTOMERS = new SCUSTOMERS();

            this.Close();

            sCUSTOMERS.Show();
        }

        private void BT_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
