namespace BookManagementSystem
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnProceed = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.TextBox();
            this.lblfname = new System.Windows.Forms.TextBox();
            this.lbllast = new System.Windows.Forms.TextBox();
            this.lbldeductions = new System.Windows.Forms.TextBox();
            this.lblhome = new System.Windows.Forms.TextBox();
            this.lblmonthly = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblmarital = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1000, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 26);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.btnProceed.Location = new System.Drawing.Point(887, 447);
            this.btnProceed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(103, 32);
            this.btnProceed.TabIndex = 27;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -151);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1376, 423);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(57, 222);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(128, 25);
            this.txtUsername.TabIndex = 28;
            this.txtUsername.Text = "Employee ID:";
            // 
            // lblid
            // 
            this.lblid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.lblid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.White;
            this.lblid.Location = new System.Drawing.Point(206, 222);
            this.lblid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(164, 25);
            this.lblid.TabIndex = 29;
            this.lblid.Text = "<Employee ID>";
            this.lblid.TextChanged += new System.EventHandler(this.lblid_TextChanged);
            // 
            // lblfname
            // 
            this.lblfname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.lblfname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblfname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfname.ForeColor = System.Drawing.Color.White;
            this.lblfname.Location = new System.Drawing.Point(206, 287);
            this.lblfname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(177, 25);
            this.lblfname.TabIndex = 30;
            this.lblfname.Text = "<First Name>";
            this.lblfname.TextChanged += new System.EventHandler(this.lblfname_TextChanged);
            // 
            // lbllast
            // 
            this.lbllast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.lbllast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbllast.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllast.ForeColor = System.Drawing.Color.White;
            this.lbllast.Location = new System.Drawing.Point(206, 349);
            this.lbllast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbllast.Name = "lbllast";
            this.lbllast.Size = new System.Drawing.Size(177, 25);
            this.lbllast.TabIndex = 31;
            this.lbllast.Text = "<Last Name>";
            this.lbllast.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbldeductions
            // 
            this.lbldeductions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.lbldeductions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbldeductions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeductions.ForeColor = System.Drawing.Color.White;
            this.lbldeductions.Location = new System.Drawing.Point(740, 222);
            this.lbldeductions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbldeductions.Name = "lbldeductions";
            this.lbldeductions.Size = new System.Drawing.Size(164, 25);
            this.lbldeductions.TabIndex = 32;
            this.lbldeductions.Text = "<Deductions>";
            this.lbldeductions.TextChanged += new System.EventHandler(this.lbldeductions_TextChanged);
            // 
            // lblhome
            // 
            this.lblhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.lblhome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblhome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhome.ForeColor = System.Drawing.Color.White;
            this.lblhome.Location = new System.Drawing.Point(740, 287);
            this.lblhome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblhome.Name = "lblhome";
            this.lblhome.Size = new System.Drawing.Size(164, 25);
            this.lblhome.TabIndex = 33;
            this.lblhome.Text = "<Home Pay>";
            // 
            // lblmonthly
            // 
            this.lblmonthly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.lblmonthly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblmonthly.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonthly.ForeColor = System.Drawing.Color.White;
            this.lblmonthly.Location = new System.Drawing.Point(740, 349);
            this.lblmonthly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblmonthly.Name = "lblmonthly";
            this.lblmonthly.Size = new System.Drawing.Size(164, 25);
            this.lblmonthly.TabIndex = 34;
            this.lblmonthly.Text = "<Monthly Pay>";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(68, 287);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(117, 25);
            this.textBox6.TabIndex = 35;
            this.textBox6.Text = "First Name";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(68, 349);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(117, 25);
            this.textBox7.TabIndex = 36;
            this.textBox7.Text = "Last Name";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.White;
            this.textBox8.Location = new System.Drawing.Point(551, 222);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(129, 25);
            this.textBox8.TabIndex = 37;
            this.textBox8.Text = "Deductions:";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.Color.White;
            this.textBox9.Location = new System.Drawing.Point(551, 287);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(129, 25);
            this.textBox9.TabIndex = 38;
            this.textBox9.Text = "Home Pay";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.ForeColor = System.Drawing.Color.White;
            this.textBox10.Location = new System.Drawing.Point(541, 349);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(139, 25);
            this.textBox10.TabIndex = 39;
            this.textBox10.Text = "Monthly Pay";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(48, 436);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 25);
            this.textBox1.TabIndex = 40;
            this.textBox1.Text = "Marital Status:";
            // 
            // lblmarital
            // 
            this.lblmarital.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.lblmarital.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblmarital.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarital.ForeColor = System.Drawing.Color.White;
            this.lblmarital.Location = new System.Drawing.Point(206, 436);
            this.lblmarital.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblmarital.Name = "lblmarital";
            this.lblmarital.Size = new System.Drawing.Size(177, 25);
            this.lblmarital.TabIndex = 41;
            this.lblmarital.Text = "<Marital Status>";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1045, 498);
            this.Controls.Add(this.lblmarital);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.lblmonthly);
            this.Controls.Add(this.lblhome);
            this.Controls.Add(this.lbldeductions);
            this.Controls.Add(this.lbllast);
            this.Controls.Add(this.lblfname);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUsername;
        public System.Windows.Forms.TextBox lblid;
        public System.Windows.Forms.TextBox lblfname;
        public System.Windows.Forms.TextBox lbllast;
        public System.Windows.Forms.TextBox lbldeductions;
        public System.Windows.Forms.TextBox lblhome;
        public System.Windows.Forms.TextBox lblmonthly;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox lblmarital;
    }
}