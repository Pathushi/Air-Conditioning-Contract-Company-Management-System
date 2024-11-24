namespace Air_Conditioning_Contract_Company_Management_System
{
    partial class Admin_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlEmpRegistration = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnEmpRegistration = new System.Windows.Forms.Button();
            this.pnlCusRegistration = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnCusRegistration = new System.Windows.Forms.Button();
            this.pnlTechResources = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnTechResources = new System.Windows.Forms.Button();
            this.pnlEquipment = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btnEquipment = new System.Windows.Forms.Button();
            this.pnlMonitorSystem = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnMonitorSystem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picboxlogout = new System.Windows.Forms.PictureBox();
            this.lbllogout = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnlEmpRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlCusRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlTechResources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.pnlEquipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.pnlMonitorSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogout)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 38);
            this.panel1.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.Image = global::Air_Conditioning_Contract_Company_Management_System.Properties.Resources.menu;
            this.btnMenu.Location = new System.Drawing.Point(3, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 23);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 2;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "iDAC (Pvt) Ltd";
            // 
            // SidebarTransition
            // 
            this.SidebarTransition.Interval = 10;
            this.SidebarTransition.Tick += new System.EventHandler(this.SidebarTransition_Tick);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(217)))), ((int)(((byte)(235)))));
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMain.Location = new System.Drawing.Point(347, 38);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(733, 631);
            this.panelMain.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Air_Conditioning_Contract_Company_Management_System.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(164, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.SteelBlue;
            this.sidebar.Controls.Add(this.pnlEmpRegistration);
            this.sidebar.Controls.Add(this.pnlCusRegistration);
            this.sidebar.Controls.Add(this.pnlTechResources);
            this.sidebar.Controls.Add(this.pnlEquipment);
            this.sidebar.Controls.Add(this.pnlMonitorSystem);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 38);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(345, 631);
            this.sidebar.TabIndex = 10;
            // 
            // pnlEmpRegistration
            // 
            this.pnlEmpRegistration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlEmpRegistration.Controls.Add(this.pictureBox2);
            this.pnlEmpRegistration.Controls.Add(this.btnEmpRegistration);
            this.pnlEmpRegistration.Location = new System.Drawing.Point(3, 3);
            this.pnlEmpRegistration.Name = "pnlEmpRegistration";
            this.pnlEmpRegistration.Size = new System.Drawing.Size(321, 48);
            this.pnlEmpRegistration.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox2.Image = global::Air_Conditioning_Contract_Company_Management_System.Properties.Resources.group;
            this.pictureBox2.Location = new System.Drawing.Point(2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnEmpRegistration
            // 
            this.btnEmpRegistration.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEmpRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpRegistration.Location = new System.Drawing.Point(57, 3);
            this.btnEmpRegistration.Name = "btnEmpRegistration";
            this.btnEmpRegistration.Size = new System.Drawing.Size(250, 40);
            this.btnEmpRegistration.TabIndex = 0;
            this.btnEmpRegistration.Text = "Employee Registration";
            this.btnEmpRegistration.UseVisualStyleBackColor = true;
            this.btnEmpRegistration.Click += new System.EventHandler(this.btnEmpRegistration_Click);
            // 
            // pnlCusRegistration
            // 
            this.pnlCusRegistration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCusRegistration.Controls.Add(this.pictureBox4);
            this.pnlCusRegistration.Controls.Add(this.btnCusRegistration);
            this.pnlCusRegistration.Location = new System.Drawing.Point(3, 57);
            this.pnlCusRegistration.Name = "pnlCusRegistration";
            this.pnlCusRegistration.Size = new System.Drawing.Size(321, 48);
            this.pnlCusRegistration.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox4.Image = global::Air_Conditioning_Contract_Company_Management_System.Properties.Resources.icons8_user_32;
            this.pictureBox4.Location = new System.Drawing.Point(2, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // btnCusRegistration
            // 
            this.btnCusRegistration.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCusRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusRegistration.Location = new System.Drawing.Point(57, 3);
            this.btnCusRegistration.Name = "btnCusRegistration";
            this.btnCusRegistration.Size = new System.Drawing.Size(250, 40);
            this.btnCusRegistration.TabIndex = 0;
            this.btnCusRegistration.Text = "Customer Registration";
            this.btnCusRegistration.UseVisualStyleBackColor = true;
            this.btnCusRegistration.Click += new System.EventHandler(this.btnCusRegistration_Click);
            // 
            // pnlTechResources
            // 
            this.pnlTechResources.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTechResources.Controls.Add(this.pictureBox6);
            this.pnlTechResources.Controls.Add(this.btnTechResources);
            this.pnlTechResources.Location = new System.Drawing.Point(3, 111);
            this.pnlTechResources.Name = "pnlTechResources";
            this.pnlTechResources.Size = new System.Drawing.Size(321, 48);
            this.pnlTechResources.TabIndex = 6;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox6.Image = global::Air_Conditioning_Contract_Company_Management_System.Properties.Resources.icons8_service_50;
            this.pictureBox6.Location = new System.Drawing.Point(2, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(49, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // btnTechResources
            // 
            this.btnTechResources.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTechResources.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechResources.Location = new System.Drawing.Point(57, 3);
            this.btnTechResources.Name = "btnTechResources";
            this.btnTechResources.Size = new System.Drawing.Size(250, 40);
            this.btnTechResources.TabIndex = 0;
            this.btnTechResources.Text = "Technical Resources";
            this.btnTechResources.UseVisualStyleBackColor = true;
            this.btnTechResources.Click += new System.EventHandler(this.btnTechResources_Click);
            // 
            // pnlEquipment
            // 
            this.pnlEquipment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlEquipment.Controls.Add(this.pictureBox9);
            this.pnlEquipment.Controls.Add(this.btnEquipment);
            this.pnlEquipment.Location = new System.Drawing.Point(3, 165);
            this.pnlEquipment.Name = "pnlEquipment";
            this.pnlEquipment.Size = new System.Drawing.Size(321, 48);
            this.pnlEquipment.TabIndex = 9;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox9.Image = global::Air_Conditioning_Contract_Company_Management_System.Properties.Resources.icons8_air_conditioner_50;
            this.pictureBox9.Location = new System.Drawing.Point(2, 3);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(49, 40);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 1;
            this.pictureBox9.TabStop = false;
            // 
            // btnEquipment
            // 
            this.btnEquipment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipment.Location = new System.Drawing.Point(57, 3);
            this.btnEquipment.Name = "btnEquipment";
            this.btnEquipment.Size = new System.Drawing.Size(250, 40);
            this.btnEquipment.TabIndex = 0;
            this.btnEquipment.Text = "Equipment";
            this.btnEquipment.UseVisualStyleBackColor = true;
            this.btnEquipment.Click += new System.EventHandler(this.btnEquipment_Click);
            // 
            // pnlMonitorSystem
            // 
            this.pnlMonitorSystem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMonitorSystem.Controls.Add(this.pictureBox7);
            this.pnlMonitorSystem.Controls.Add(this.btnMonitorSystem);
            this.pnlMonitorSystem.Location = new System.Drawing.Point(3, 219);
            this.pnlMonitorSystem.Name = "pnlMonitorSystem";
            this.pnlMonitorSystem.Size = new System.Drawing.Size(321, 48);
            this.pnlMonitorSystem.TabIndex = 7;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox7.Image = global::Air_Conditioning_Contract_Company_Management_System.Properties.Resources.monitor;
            this.pictureBox7.Location = new System.Drawing.Point(2, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(49, 40);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            // 
            // btnMonitorSystem
            // 
            this.btnMonitorSystem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMonitorSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitorSystem.Location = new System.Drawing.Point(57, 3);
            this.btnMonitorSystem.Name = "btnMonitorSystem";
            this.btnMonitorSystem.Size = new System.Drawing.Size(250, 40);
            this.btnMonitorSystem.TabIndex = 0;
            this.btnMonitorSystem.Text = "Monitor System";
            this.btnMonitorSystem.UseVisualStyleBackColor = true;
            this.btnMonitorSystem.Click += new System.EventHandler(this.btnMonitorSystem_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.picboxlogout);
            this.panel2.Controls.Add(this.lbllogout);
            this.panel2.Location = new System.Drawing.Point(3, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 48);
            this.panel2.TabIndex = 6;
            // 
            // picboxlogout
            // 
            this.picboxlogout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picboxlogout.Image = ((System.Drawing.Image)(resources.GetObject("picboxlogout.Image")));
            this.picboxlogout.Location = new System.Drawing.Point(2, 3);
            this.picboxlogout.Name = "picboxlogout";
            this.picboxlogout.Size = new System.Drawing.Size(49, 40);
            this.picboxlogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxlogout.TabIndex = 2;
            this.picboxlogout.TabStop = false;
            // 
            // lbllogout
            // 
            this.lbllogout.AutoSize = true;
            this.lbllogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogout.Location = new System.Drawing.Point(134, 12);
            this.lbllogout.Name = "lbllogout";
            this.lbllogout.Size = new System.Drawing.Size(84, 23);
            this.lbllogout.TabIndex = 10;
            this.lbllogout.Text = "Log-out";
            this.lbllogout.Click += new System.EventHandler(this.lbllogout_Click);
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1080, 669);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnlEmpRegistration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlCusRegistration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlTechResources.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.pnlEquipment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.pnlMonitorSystem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Timer SidebarTransition;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel pnlEmpRegistration;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnEmpRegistration;
        private System.Windows.Forms.Panel pnlCusRegistration;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnCusRegistration;
        private System.Windows.Forms.Panel pnlTechResources;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnTechResources;
        private System.Windows.Forms.Panel pnlEquipment;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button btnEquipment;
        private System.Windows.Forms.Panel pnlMonitorSystem;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btnMonitorSystem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picboxlogout;
        private System.Windows.Forms.Label lbllogout;
    }
}