﻿using System;
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
    public partial class SDASHBOARD : Form
    {
        public SDASHBOARD()
        {
            InitializeComponent();
        }

        private void BT_Home_Click(object sender, EventArgs e)
        {
            //Instacia a tela MENU
            SMENU sMENU = new SMENU();

            this.Close();

            sMENU.Show();
        }

        private void BT_Schedule_Click(object sender, EventArgs e)
        {
            //Instacia a tela SCHEDULE
            SSCHEDULE sSCHEDULE = new SSCHEDULE();

            this.Close();

            sSCHEDULE.Show();
        }

        private void BT_Customers_Click(object sender, EventArgs e)
        {
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
