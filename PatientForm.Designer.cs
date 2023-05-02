namespace DAMS
{
    partial class PatientForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PatPhone = new System.Windows.Forms.TextBox();
            this.PatAdd = new System.Windows.Forms.TextBox();
            this.PatName = new System.Windows.Forms.TextBox();
            this.PatId = new System.Windows.Forms.TextBox();
            this.PatAge = new System.Windows.Forms.TextBox();
            this.GenderCb = new System.Windows.Forms.ComboBox();
            this.BloodCb = new System.Windows.Forms.ComboBox();
            this.PatDisease = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PatientGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1422, 132);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Swis721 BlkCn BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(641, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "PATIENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Swis721 BlkCn BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(412, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "DOCTOR APPOINTMENT MANAGEMENT SYSTEM";
            // 
            // PatPhone
            // 
            this.PatPhone.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatPhone.Location = new System.Drawing.Point(55, 356);
            this.PatPhone.Name = "PatPhone";
            this.PatPhone.Size = new System.Drawing.Size(193, 30);
            this.PatPhone.TabIndex = 10;
            this.PatPhone.Text = "PatientPhone";
            // 
            // PatAdd
            // 
            this.PatAdd.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatAdd.Location = new System.Drawing.Point(55, 299);
            this.PatAdd.Name = "PatAdd";
            this.PatAdd.Size = new System.Drawing.Size(193, 30);
            this.PatAdd.TabIndex = 9;
            this.PatAdd.Text = "PatientAddress";
            // 
            // PatName
            // 
            this.PatName.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatName.Location = new System.Drawing.Point(55, 241);
            this.PatName.Name = "PatName";
            this.PatName.Size = new System.Drawing.Size(193, 30);
            this.PatName.TabIndex = 8;
            this.PatName.Text = "PatientName";
            // 
            // PatId
            // 
            this.PatId.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatId.Location = new System.Drawing.Point(55, 185);
            this.PatId.Name = "PatId";
            this.PatId.Size = new System.Drawing.Size(193, 30);
            this.PatId.TabIndex = 7;
            this.PatId.Text = "PatientID";
            // 
            // PatAge
            // 
            this.PatAge.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatAge.Location = new System.Drawing.Point(55, 412);
            this.PatAge.Name = "PatAge";
            this.PatAge.Size = new System.Drawing.Size(193, 30);
            this.PatAge.TabIndex = 11;
            this.PatAge.Text = "PatientAge";
            // 
            // GenderCb
            // 
            this.GenderCb.BackColor = System.Drawing.SystemColors.Menu;
            this.GenderCb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenderCb.FormattingEnabled = true;
            this.GenderCb.Items.AddRange(new object[] {
            "Male ",
            "Female",
            "Other"});
            this.GenderCb.Location = new System.Drawing.Point(55, 470);
            this.GenderCb.Name = "GenderCb";
            this.GenderCb.Size = new System.Drawing.Size(193, 30);
            this.GenderCb.TabIndex = 12;
            this.GenderCb.Text = "Gender";
            // 
            // BloodCb
            // 
            this.BloodCb.BackColor = System.Drawing.SystemColors.Menu;
            this.BloodCb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BloodCb.FormattingEnabled = true;
            this.BloodCb.Items.AddRange(new object[] {
            "A+",
            "B+",
            "O+",
            "AB+",
            "A-",
            "B-",
            "O-",
            "AB-"});
            this.BloodCb.Location = new System.Drawing.Point(55, 526);
            this.BloodCb.Name = "BloodCb";
            this.BloodCb.Size = new System.Drawing.Size(193, 30);
            this.BloodCb.TabIndex = 13;
            this.BloodCb.Text = "BloodGroup";
            // 
            // PatDisease
            // 
            this.PatDisease.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatDisease.Location = new System.Drawing.Point(55, 582);
            this.PatDisease.Name = "PatDisease";
            this.PatDisease.Size = new System.Drawing.Size(193, 30);
            this.PatDisease.TabIndex = 14;
            this.PatDisease.Text = "MajorDisease";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkCyan;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(167, 737);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 49);
            this.button4.TabIndex = 19;
            this.button4.Text = "HOME";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkCyan;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(278, 682);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 49);
            this.button3.TabIndex = 18;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(167, 682);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 49);
            this.button2.TabIndex = 17;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(56, 682);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 49);
            this.button1.TabIndex = 16;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Swis721 BlkCn BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(849, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 42);
            this.label3.TabIndex = 20;
            this.label3.Text = "PATIENTS LIST";
            // 
            // PatientGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.PatientGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PatientGV.ColumnHeadersHeight = 30;
            this.PatientGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.PatientGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientGV.Location = new System.Drawing.Point(490, 210);
            this.PatientGV.Name = "PatientGV";
            this.PatientGV.RowHeadersVisible = false;
            this.PatientGV.RowTemplate.Height = 30;
            this.PatientGV.Size = new System.Drawing.Size(919, 602);
            this.PatientGV.TabIndex = 22;
            this.PatientGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PatientGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PatientGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PatientGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PatientGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PatientGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PatientGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.MediumBlue;
            this.PatientGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PatientGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PatientGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PatientGV.ThemeStyle.HeaderStyle.Height = 30;
            this.PatientGV.ThemeStyle.ReadOnly = false;
            this.PatientGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PatientGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PatientGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PatientGV.ThemeStyle.RowsStyle.Height = 30;
            this.PatientGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PatientGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientGV_CellContentClick);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 824);
            this.Controls.Add(this.PatientGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PatDisease);
            this.Controls.Add(this.BloodCb);
            this.Controls.Add(this.GenderCb);
            this.Controls.Add(this.PatAge);
            this.Controls.Add(this.PatPhone);
            this.Controls.Add(this.PatAdd);
            this.Controls.Add(this.PatName);
            this.Controls.Add(this.PatId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        

            #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox PatPhone;
        private TextBox PatAdd;
        private TextBox PatName;
        private TextBox PatId;
        private TextBox PatAge;
        private ComboBox GenderCb;
        private ComboBox BloodCb;
        private TextBox PatDisease;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView PatientGV;
    }
}