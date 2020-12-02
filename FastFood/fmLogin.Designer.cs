namespace FastFood
{
    partial class fmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 759);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1199, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 54);
            this.btnExit.TabIndex = 29;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Location = new System.Drawing.Point(401, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(444, 563);
            this.panel4.TabIndex = 28;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtMatKhau);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.txtMaNV);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.btnLogin);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(442, 511);
            this.panel5.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.White;
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMatKhau.Location = new System.Drawing.Point(43, 324);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(360, 25);
            this.txtMatKhau.TabIndex = 28;
            this.txtMatKhau.Text = "Password";
            this.txtMatKhau.Click += new System.EventHandler(this.txtMatKhau_Click_1);
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            this.txtMatKhau.Enter += new System.EventHandler(this.txtMatKhau_Enter);
            this.txtMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatKhau_KeyDown);
            this.txtMatKhau.Leave += new System.EventHandler(this.txtMatKhau_Leave_1);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DimGray;
            this.panel9.Location = new System.Drawing.Point(43, 353);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(360, 1);
            this.panel9.TabIndex = 29;
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.Color.White;
            this.txtMaNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaNV.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaNV.Location = new System.Drawing.Point(43, 270);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(360, 25);
            this.txtMaNV.TabIndex = 27;
            this.txtMaNV.Text = "Username";
            this.txtMaNV.Click += new System.EventHandler(this.txtMaNV_Click_1);
            this.txtMaNV.Leave += new System.EventHandler(this.txtMaNV_Leave_1);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DimGray;
            this.panel10.Location = new System.Drawing.Point(43, 299);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(360, 1);
            this.panel10.TabIndex = 30;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(43, 419);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(360, 54);
            this.btnLogin.TabIndex = 26;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(61, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 34);
            this.label1.TabIndex = 25;
            this.label1.Text = "Login to Your Account";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::FastFood.Properties.Resources.icons8_small_business_200px;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(120, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 193);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.label4);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(442, 50);
            this.panel11.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Login";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 759);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmLogin";
            this.Text = "fmLogin";
            this.Load += new System.EventHandler(this.fmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Panel panel11;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}