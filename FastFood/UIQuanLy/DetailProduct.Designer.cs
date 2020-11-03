namespace FastFood
{
    partial class DetailProduct
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
            this.pnTieuDe = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.picSP = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtGiaSP = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbKind = new System.Windows.Forms.ComboBox();
            this.pnKind = new System.Windows.Forms.Panel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pnTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.panel13.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnKind.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTieuDe
            // 
            this.pnTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnTieuDe.Controls.Add(this.btnClose);
            this.pnTieuDe.Controls.Add(this.btnMinimize);
            this.pnTieuDe.Controls.Add(this.lblName);
            this.pnTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnTieuDe.Name = "pnTieuDe";
            this.pnTieuDe.Size = new System.Drawing.Size(891, 45);
            this.pnTieuDe.TabIndex = 0;
            this.pnTieuDe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTieuDe_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::FastFood.Properties.Resources.icons8_multiply_32px;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(840, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = global::FastFood.Properties.Resources.icons8_subtract_32px;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.Location = new System.Drawing.Point(793, 9);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(14, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(137, 23);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Form\'s Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.listView2);
            this.panel2.Controls.Add(this.pnKind);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.picSP);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 686);
            this.panel2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::FastFood.Properties.Resources.icons8_save_20px;
            this.btnSave.Location = new System.Drawing.Point(627, 613);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(227, 51);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "      Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picSP
            // 
            this.picSP.BackgroundImage = global::FastFood.Properties.Resources.khoai_tay_chien;
            this.picSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSP.Location = new System.Drawing.Point(34, 23);
            this.picSP.Name = "picSP";
            this.picSP.Size = new System.Drawing.Size(228, 163);
            this.picSP.TabIndex = 13;
            this.picSP.TabStop = false;
            this.picSP.Click += new System.EventHandler(this.picSP_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtTenSP);
            this.panel4.Location = new System.Drawing.Point(480, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(373, 35);
            this.panel4.TabIndex = 10;
            // 
            // txtTenSP
            // 
            this.txtTenSP.BackColor = System.Drawing.Color.White;
            this.txtTenSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenSP.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(6, 5);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(358, 23);
            this.txtTenSP.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtGiaSP);
            this.panel3.Location = new System.Drawing.Point(480, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 35);
            this.panel3.TabIndex = 11;
            // 
            // txtGiaSP
            // 
            this.txtGiaSP.BackColor = System.Drawing.Color.White;
            this.txtGiaSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGiaSP.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaSP.Location = new System.Drawing.Point(6, 5);
            this.txtGiaSP.Name = "txtGiaSP";
            this.txtGiaSP.Size = new System.Drawing.Size(358, 23);
            this.txtGiaSP.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtGiaBan);
            this.panel5.Location = new System.Drawing.Point(159, 210);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(236, 35);
            this.panel5.TabIndex = 12;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.BackColor = System.Drawing.Color.White;
            this.txtGiaBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGiaBan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(6, 5);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(221, 23);
            this.txtGiaBan.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Profit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Product Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Product\'s Name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(476, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Discount";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.textBox2);
            this.panel10.Location = new System.Drawing.Point(618, 210);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(236, 35);
            this.panel10.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(6, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 23);
            this.textBox2.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.label8);
            this.panel11.Location = new System.Drawing.Point(27, 267);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(703, 57);
            this.panel11.TabIndex = 16;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.comboBox2);
            this.panel12.Location = new System.Drawing.Point(132, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(373, 42);
            this.panel12.TabIndex = 14;
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Burger",
            "Chicken",
            "Chicken Set",
            "Combo",
            "Value",
            "Set",
            "Dessert",
            "Drink"});
            this.comboBox2.Location = new System.Drawing.Point(6, 1);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(358, 31);
            this.comboBox2.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Material";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.numericUpDown2.Location = new System.Drawing.Point(5, 4);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 28);
            this.numericUpDown2.TabIndex = 17;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.numericUpDown2);
            this.panel13.Location = new System.Drawing.Point(544, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(130, 42);
            this.panel13.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kind";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.cbKind);
            this.panel6.Location = new System.Drawing.Point(197, 7);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(373, 42);
            this.panel6.TabIndex = 14;
            // 
            // cbKind
            // 
            this.cbKind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKind.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKind.FormattingEnabled = true;
            this.cbKind.Items.AddRange(new object[] {
            "Burger",
            "Chicken",
            "Chicken Set",
            "Combo",
            "Value",
            "Set",
            "Dessert",
            "Drink"});
            this.cbKind.Location = new System.Drawing.Point(6, 1);
            this.cbKind.Name = "cbKind";
            this.cbKind.Size = new System.Drawing.Size(358, 31);
            this.cbKind.TabIndex = 16;
            // 
            // pnKind
            // 
            this.pnKind.Controls.Add(this.panel6);
            this.pnKind.Controls.Add(this.label4);
            this.pnKind.Location = new System.Drawing.Point(283, 137);
            this.pnKind.Name = "pnKind";
            this.pnKind.Size = new System.Drawing.Size(585, 60);
            this.pnKind.TabIndex = 16;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(34, 343);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(667, 254);
            this.listView2.TabIndex = 17;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(733, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 42);
            this.button3.TabIndex = 15;
            this.button3.Text = "Edit";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(733, 343);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 42);
            this.button4.TabIndex = 15;
            this.button4.Text = "Select";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(732, 400);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 42);
            this.button5.TabIndex = 15;
            this.button5.Text = " Delete";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // DetailProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(891, 731);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailProduct";
            this.Load += new System.EventHandler(this.DetailProduct_Load);
            this.pnTieuDe.ResumeLayout(false);
            this.pnTieuDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.pnKind.ResumeLayout(false);
            this.pnKind.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picSP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtGiaSP;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnTieuDe;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnKind;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbKind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}