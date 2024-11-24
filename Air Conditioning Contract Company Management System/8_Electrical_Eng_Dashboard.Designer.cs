namespace Air_Conditioning_Contract_Company_Management_System
{
    partial class ElectricalEngineerDashboard
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
            this.components = new System.ComponentModel.Container();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlLogout = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.Panel();
            this.pnlAppointment = new System.Windows.Forms.Panel();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.pnlSRequest = new System.Windows.Forms.Panel();
            this.btnSRequest = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.pnlLogout.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.pnlAppointment.SuspendLayout();
            this.pnlSRequest.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(58, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(187, 33);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Log-out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlLogout
            // 
            this.pnlLogout.Controls.Add(this.pictureBox8);
            this.pnlLogout.Controls.Add(this.btnLogout);
            this.pnlLogout.Location = new System.Drawing.Point(12, 105);
            this.pnlLogout.Name = "pnlLogout";
            this.pnlLogout.Size = new System.Drawing.Size(267, 42);
            this.pnlLogout.TabIndex = 6;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.SteelBlue;
            this.sidebar.Controls.Add(this.pnlLogout);
            this.sidebar.Controls.Add(this.pnlAppointment);
            this.sidebar.Controls.Add(this.pnlSRequest);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 41);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(304, 583);
            this.sidebar.TabIndex = 4;
            // 
            // pnlAppointment
            // 
            this.pnlAppointment.Controls.Add(this.pictureBox2);
            this.pnlAppointment.Controls.Add(this.btnAppointment);
            this.pnlAppointment.Location = new System.Drawing.Point(9, 8);
            this.pnlAppointment.Name = "pnlAppointment";
            this.pnlAppointment.Size = new System.Drawing.Size(270, 42);
            this.pnlAppointment.TabIndex = 0;
            // 
            // btnAppointment
            // 
            this.btnAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointment.Location = new System.Drawing.Point(58, 3);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(187, 33);
            this.btnAppointment.TabIndex = 0;
            this.btnAppointment.Text = "Project Proposal";
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // pnlSRequest
            // 
            this.pnlSRequest.Controls.Add(this.pictureBox3);
            this.pnlSRequest.Controls.Add(this.btnSRequest);
            this.pnlSRequest.Location = new System.Drawing.Point(9, 57);
            this.pnlSRequest.Name = "pnlSRequest";
            this.pnlSRequest.Size = new System.Drawing.Size(270, 42);
            this.pnlSRequest.TabIndex = 1;
            // 
            // btnSRequest
            // 
            this.btnSRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSRequest.Location = new System.Drawing.Point(58, 3);
            this.btnSRequest.Name = "btnSRequest";
            this.btnSRequest.Size = new System.Drawing.Size(187, 33);
            this.btnSRequest.TabIndex = 0;
            this.btnSRequest.Text = "Project Report";
            this.btnSRequest.UseVisualStyleBackColor = true;
            this.btnSRequest.Click += new System.EventHandler(this.btnSRequest_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(217)))), ((int)(((byte)(235)))));
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.Location = new System.Drawing.Point(310, 47);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 633);
            this.panelMain.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "iDAC (Pvt) Ltd";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 41);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Air_Conditioning_Contract_Company_Management_System.Properties.Resources.power;
            this.pictureBox8.Location = new System.Drawing.Point(0, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(57, 36);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 1;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Air_Conditioning_Contract_Company_Management_System.Properties.Resources.profiles5;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Air_Conditioning_Contract_Company_Management_System.Properties.Resources.profiles6;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Air_Conditioning_Contract_Company_Management_System.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(91, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Image = global::Air_Conditioning_Contract_Company_Management_System.Properties.Resources.menu1;
            this.btnMenu.Location = new System.Drawing.Point(12, 10);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(31, 25);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            // 
            // ElectricalEngineerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 624);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Name = "ElectricalEngineerDashboard";
            this.Text = "ElectricalEngineerDashboard";
            this.pnlLogout.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.pnlAppointment.ResumeLayout(false);
            this.pnlSRequest.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlLogout;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel pnlAppointment;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Panel pnlSRequest;
        private System.Windows.Forms.Button btnSRequest;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}