namespace FastFood.UIQuanLy
{
    partial class DetailMaterial
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTenNL = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtGiaNL = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.pnTieuDe.Size = new System.Drawing.Size(662, 45);
            this.pnTieuDe.TabIndex = 0;
            this.pnTieuDe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTieuDe_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::FastFood.Properties.Resources.icons8_multiply_32px;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(611, 9);
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
            this.btnMinimize.Location = new System.Drawing.Point(564, 9);
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
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 342);
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
            this.btnSave.Location = new System.Drawing.Point(383, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(227, 51);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "      Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtTenNL);
            this.panel4.Location = new System.Drawing.Point(237, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(373, 35);
            this.panel4.TabIndex = 10;
            // 
            // txtTenNL
            // 
            this.txtTenNL.BackColor = System.Drawing.Color.White;
            this.txtTenNL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenNL.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNL.Location = new System.Drawing.Point(6, 5);
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.Size = new System.Drawing.Size(358, 23);
            this.txtTenNL.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtGiaNL);
            this.panel3.Location = new System.Drawing.Point(237, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 35);
            this.panel3.TabIndex = 11;
            // 
            // txtGiaNL
            // 
            this.txtGiaNL.BackColor = System.Drawing.Color.White;
            this.txtGiaNL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGiaNL.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaNL.Location = new System.Drawing.Point(6, 5);
            this.txtGiaNL.Name = "txtGiaNL";
            this.txtGiaNL.Size = new System.Drawing.Size(358, 23);
            this.txtGiaNL.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtSL);
            this.panel5.Location = new System.Drawing.Point(237, 150);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(373, 35);
            this.panel5.TabIndex = 12;
            // 
            // txtSL
            // 
            this.txtSL.BackColor = System.Drawing.Color.White;
            this.txtSL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSL.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(6, 5);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(358, 23);
            this.txtSL.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Material Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Material\'s Name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtDonVi);
            this.panel1.Location = new System.Drawing.Point(237, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 35);
            this.panel1.TabIndex = 17;
            // 
            // txtDonVi
            // 
            this.txtDonVi.BackColor = System.Drawing.Color.White;
            this.txtDonVi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDonVi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonVi.Location = new System.Drawing.Point(6, 5);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(358, 23);
            this.txtDonVi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Unit";
            // 
            // DetailMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 387);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailProduct";
            this.Load += new System.EventHandler(this.DetailProduct_Load);
            this.pnTieuDe.ResumeLayout(false);
            this.pnTieuDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTenNL;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtGiaNL;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnTieuDe;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.Label label4;
    }
}