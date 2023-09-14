namespace Projeto_CharasBarbearia
{
    partial class SDASHBOARD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SDASHBOARD));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.BT_Customers = new System.Windows.Forms.Button();
            this.BT_Exit = new System.Windows.Forms.Button();
            this.BT_Dashboard = new System.Windows.Forms.Button();
            this.BT_Schedule = new System.Windows.Forms.Button();
            this.PanelLOGO = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_Home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LB_DASHBOARD = new System.Windows.Forms.Label();
            this.PanelMenu.SuspendLayout();
            this.PanelLOGO.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.Orange;
            this.PanelMenu.Controls.Add(this.BT_Customers);
            this.PanelMenu.Controls.Add(this.BT_Exit);
            this.PanelMenu.Controls.Add(this.BT_Dashboard);
            this.PanelMenu.Controls.Add(this.BT_Schedule);
            this.PanelMenu.Controls.Add(this.PanelLOGO);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(120, 656);
            this.PanelMenu.TabIndex = 2;
            // 
            // BT_Customers
            // 
            this.BT_Customers.Dock = System.Windows.Forms.DockStyle.Top;
            this.BT_Customers.FlatAppearance.BorderSize = 0;
            this.BT_Customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Customers.ForeColor = System.Drawing.Color.Black;
            this.BT_Customers.Image = ((System.Drawing.Image)(resources.GetObject("BT_Customers.Image")));
            this.BT_Customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Customers.Location = new System.Drawing.Point(0, 140);
            this.BT_Customers.Name = "BT_Customers";
            this.BT_Customers.Size = new System.Drawing.Size(120, 40);
            this.BT_Customers.TabIndex = 5;
            this.BT_Customers.Text = "  CUSTOMERS";
            this.BT_Customers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Customers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Customers.UseVisualStyleBackColor = true;
            this.BT_Customers.Click += new System.EventHandler(this.BT_Customers_Click);
            // 
            // BT_Exit
            // 
            this.BT_Exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BT_Exit.FlatAppearance.BorderSize = 0;
            this.BT_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Exit.ForeColor = System.Drawing.Color.Gainsboro;
            this.BT_Exit.Image = ((System.Drawing.Image)(resources.GetObject("BT_Exit.Image")));
            this.BT_Exit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BT_Exit.Location = new System.Drawing.Point(0, 616);
            this.BT_Exit.Name = "BT_Exit";
            this.BT_Exit.Size = new System.Drawing.Size(120, 40);
            this.BT_Exit.TabIndex = 4;
            this.BT_Exit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Exit.UseVisualStyleBackColor = true;
            this.BT_Exit.Click += new System.EventHandler(this.BT_Exit_Click);
            // 
            // BT_Dashboard
            // 
            this.BT_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.BT_Dashboard.FlatAppearance.BorderSize = 0;
            this.BT_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Dashboard.ForeColor = System.Drawing.Color.Black;
            this.BT_Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("BT_Dashboard.Image")));
            this.BT_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Dashboard.Location = new System.Drawing.Point(0, 100);
            this.BT_Dashboard.Name = "BT_Dashboard";
            this.BT_Dashboard.Size = new System.Drawing.Size(120, 40);
            this.BT_Dashboard.TabIndex = 3;
            this.BT_Dashboard.Text = "  DASHBOARD";
            this.BT_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Dashboard.UseVisualStyleBackColor = true;
            // 
            // BT_Schedule
            // 
            this.BT_Schedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.BT_Schedule.FlatAppearance.BorderSize = 0;
            this.BT_Schedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Schedule.ForeColor = System.Drawing.Color.Black;
            this.BT_Schedule.Image = ((System.Drawing.Image)(resources.GetObject("BT_Schedule.Image")));
            this.BT_Schedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Schedule.Location = new System.Drawing.Point(0, 60);
            this.BT_Schedule.Name = "BT_Schedule";
            this.BT_Schedule.Size = new System.Drawing.Size(120, 40);
            this.BT_Schedule.TabIndex = 2;
            this.BT_Schedule.Text = "  SCHEDULE";
            this.BT_Schedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Schedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Schedule.UseVisualStyleBackColor = true;
            this.BT_Schedule.Click += new System.EventHandler(this.BT_Schedule_Click);
            // 
            // PanelLOGO
            // 
            this.PanelLOGO.BackColor = System.Drawing.Color.SteelBlue;
            this.PanelLOGO.Controls.Add(this.panel1);
            this.PanelLOGO.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLOGO.Location = new System.Drawing.Point(0, 0);
            this.PanelLOGO.Name = "PanelLOGO";
            this.PanelLOGO.Size = new System.Drawing.Size(120, 60);
            this.PanelLOGO.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.BT_Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 60);
            this.panel1.TabIndex = 2;
            // 
            // BT_Home
            // 
            this.BT_Home.FlatAppearance.BorderSize = 0;
            this.BT_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Home.Image = ((System.Drawing.Image)(resources.GetObject("BT_Home.Image")));
            this.BT_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Home.Location = new System.Drawing.Point(3, 5);
            this.BT_Home.Name = "BT_Home";
            this.BT_Home.Size = new System.Drawing.Size(101, 49);
            this.BT_Home.TabIndex = 0;
            this.BT_Home.UseVisualStyleBackColor = true;
            this.BT_Home.Click += new System.EventHandler(this.BT_Home_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Chocolate;
            this.panel2.Controls.Add(this.LB_DASHBOARD);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(120, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1113, 60);
            this.panel2.TabIndex = 3;
            // 
            // LB_DASHBOARD
            // 
            this.LB_DASHBOARD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_DASHBOARD.AutoSize = true;
            this.LB_DASHBOARD.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DASHBOARD.Location = new System.Drawing.Point(361, 0);
            this.LB_DASHBOARD.Name = "LB_DASHBOARD";
            this.LB_DASHBOARD.Size = new System.Drawing.Size(338, 55);
            this.LB_DASHBOARD.TabIndex = 0;
            this.LB_DASHBOARD.Text = "DASHBOARD";
            // 
            // SDASHBOARD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 656);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelMenu);
            this.Name = "SDASHBOARD";
            this.Text = "DASHBOARD";
            this.PanelMenu.ResumeLayout(false);
            this.PanelLOGO.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button BT_Customers;
        private System.Windows.Forms.Button BT_Exit;
        private System.Windows.Forms.Button BT_Dashboard;
        private System.Windows.Forms.Button BT_Schedule;
        private System.Windows.Forms.Panel PanelLOGO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BT_Home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LB_DASHBOARD;
    }
}