namespace Projeto_CharasBarbearia
{
    partial class SLOGIN
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SLOGIN));
            this.PANEL_Login = new System.Windows.Forms.Panel();
            this.LBPASSWORD = new System.Windows.Forms.Label();
            this.LBUSER = new System.Windows.Forms.Label();
            this.LBLOGIN = new System.Windows.Forms.Label();
            this.TXBLOGIN = new System.Windows.Forms.TextBox();
            this.TXBPASSWORD = new System.Windows.Forms.TextBox();
            this.BTSIGN_IN = new System.Windows.Forms.Button();
            this.IMAGELOGO_LOGIN = new System.Windows.Forms.PictureBox();
            this.PANEL_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGELOGO_LOGIN)).BeginInit();
            this.SuspendLayout();
            // 
            // PANEL_Login
            // 
            this.PANEL_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PANEL_Login.BackColor = System.Drawing.Color.SteelBlue;
            this.PANEL_Login.Controls.Add(this.LBPASSWORD);
            this.PANEL_Login.Controls.Add(this.LBUSER);
            this.PANEL_Login.Controls.Add(this.LBLOGIN);
            this.PANEL_Login.Controls.Add(this.TXBLOGIN);
            this.PANEL_Login.Controls.Add(this.TXBPASSWORD);
            this.PANEL_Login.Controls.Add(this.BTSIGN_IN);
            this.PANEL_Login.Location = new System.Drawing.Point(572, 236);
            this.PANEL_Login.Name = "PANEL_Login";
            this.PANEL_Login.Size = new System.Drawing.Size(283, 193);
            this.PANEL_Login.TabIndex = 0;
            // 
            // LBPASSWORD
            // 
            this.LBPASSWORD.AutoSize = true;
            this.LBPASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPASSWORD.Location = new System.Drawing.Point(15, 112);
            this.LBPASSWORD.Name = "LBPASSWORD";
            this.LBPASSWORD.Size = new System.Drawing.Size(98, 16);
            this.LBPASSWORD.TabIndex = 5;
            this.LBPASSWORD.Text = "PASSWORD:";
            // 
            // LBUSER
            // 
            this.LBUSER.AutoSize = true;
            this.LBUSER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBUSER.Location = new System.Drawing.Point(15, 68);
            this.LBUSER.Name = "LBUSER";
            this.LBUSER.Size = new System.Drawing.Size(53, 16);
            this.LBUSER.TabIndex = 4;
            this.LBUSER.Text = "USER:";
            // 
            // LBLOGIN
            // 
            this.LBLOGIN.AutoSize = true;
            this.LBLOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLOGIN.Location = new System.Drawing.Point(92, 21);
            this.LBLOGIN.Name = "LBLOGIN";
            this.LBLOGIN.Size = new System.Drawing.Size(104, 31);
            this.LBLOGIN.TabIndex = 3;
            this.LBLOGIN.Text = "LOGIN";
            // 
            // TXBLOGIN
            // 
            this.TXBLOGIN.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TXBLOGIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXBLOGIN.Location = new System.Drawing.Point(18, 87);
            this.TXBLOGIN.Name = "TXBLOGIN";
            this.TXBLOGIN.Size = new System.Drawing.Size(251, 20);
            this.TXBLOGIN.TabIndex = 2;
            this.TXBLOGIN.TextChanged += new System.EventHandler(this.TXBLOGIN_TextChanged);
            // 
            // TXBPASSWORD
            // 
            this.TXBPASSWORD.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TXBPASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXBPASSWORD.Location = new System.Drawing.Point(18, 131);
            this.TXBPASSWORD.Name = "TXBPASSWORD";
            this.TXBPASSWORD.PasswordChar = '•';
            this.TXBPASSWORD.Size = new System.Drawing.Size(251, 20);
            this.TXBPASSWORD.TabIndex = 1;
            this.TXBPASSWORD.TextChanged += new System.EventHandler(this.TXBPASSWORD_TextChanged);
            // 
            // BTSIGN_IN
            // 
            this.BTSIGN_IN.FlatAppearance.BorderSize = 0;
            this.BTSIGN_IN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSIGN_IN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSIGN_IN.Image = ((System.Drawing.Image)(resources.GetObject("BTSIGN_IN.Image")));
            this.BTSIGN_IN.Location = new System.Drawing.Point(106, 167);
            this.BTSIGN_IN.Name = "BTSIGN_IN";
            this.BTSIGN_IN.Size = new System.Drawing.Size(75, 23);
            this.BTSIGN_IN.TabIndex = 0;
            this.BTSIGN_IN.UseVisualStyleBackColor = true;
            this.BTSIGN_IN.Click += new System.EventHandler(this.BTSIGN_IN_Click);
            // 
            // IMAGELOGO_LOGIN
            // 
            this.IMAGELOGO_LOGIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IMAGELOGO_LOGIN.BackColor = System.Drawing.Color.SteelBlue;
            this.IMAGELOGO_LOGIN.Image = ((System.Drawing.Image)(resources.GetObject("IMAGELOGO_LOGIN.Image")));
            this.IMAGELOGO_LOGIN.Location = new System.Drawing.Point(360, 236);
            this.IMAGELOGO_LOGIN.Name = "IMAGELOGO_LOGIN";
            this.IMAGELOGO_LOGIN.Size = new System.Drawing.Size(224, 193);
            this.IMAGELOGO_LOGIN.TabIndex = 1;
            this.IMAGELOGO_LOGIN.TabStop = false;
            // 
            // SLOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1233, 656);
            this.Controls.Add(this.IMAGELOGO_LOGIN);
            this.Controls.Add(this.PANEL_Login);
            this.Name = "SLOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " LOGIN";
            this.PANEL_Login.ResumeLayout(false);
            this.PANEL_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGELOGO_LOGIN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PANEL_Login;
        private System.Windows.Forms.Button BTSIGN_IN;
        private System.Windows.Forms.Label LBLOGIN;
        private System.Windows.Forms.TextBox TXBLOGIN;
        private System.Windows.Forms.TextBox TXBPASSWORD;
        private System.Windows.Forms.Label LBUSER;
        private System.Windows.Forms.Label LBPASSWORD;
        private System.Windows.Forms.PictureBox IMAGELOGO_LOGIN;
    }
}

