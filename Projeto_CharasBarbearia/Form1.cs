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
    public partial class SLOGIN : Form
    {
        public SLOGIN()
        {
            InitializeComponent();

            IMAGELOGO_LOGIN.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void TXBLOGIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXBPASSWORD_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTSIGN_IN_Click(object sender, EventArgs e)
        {
            //Instacia tela de menu
            SMENU sMENU = new SMENU();

            this.Hide();

            sMENU.Show();
        }
    }
}
