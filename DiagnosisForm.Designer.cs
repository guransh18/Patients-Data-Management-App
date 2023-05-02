namespace DAMS
{
    partial class DiagnosisForm
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
            this.DiagId = new System.Windows.Forms.TextBox();
            this.PatientIdCb = new System.Windows.Forms.ComboBox();
            this.PatientTb = new System.Windows.Forms.TextBox();
            this.SymptomsTb = new System.Windows.Forms.TextBox();
            this.DiagnosisTb = new System.Windows.Forms.TextBox();
            this.MedicineTb = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Diagnosislbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Medicineslbl = new System.Windows.Forms.Label();
            this.Symptomslbl = new System.Windows.Forms.Label();
            this.PatientNamelbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DiagnosisGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1625, 176);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(720, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "DIAGNOSIS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(478, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(901, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "DOCTOR APPOINTMENT MANAGEMENT SYSTEM";
            // 
            // DiagId
            // 
            this.DiagId.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiagId.Location = new System.Drawing.Point(63, 221);
            this.DiagId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DiagId.Name = "DiagId";
            this.DiagId.Size = new System.Drawing.Size(220, 36);
            this.DiagId.TabIndex = 4;
            this.DiagId.Text = "DiagnosisID";
            this.DiagId.TextChanged += new System.EventHandler(this.DiagId_TextChanged);
            // 
            // PatientIdCb
            // 
            this.PatientIdCb.BackColor = System.Drawing.SystemColors.Menu;
            this.PatientIdCb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientIdCb.FormattingEnabled = true;
            this.PatientIdCb.Location = new System.Drawing.Point(63, 289);
            this.PatientIdCb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PatientIdCb.Name = "PatientIdCb";
            this.PatientIdCb.Size = new System.Drawing.Size(220, 37);
            this.PatientIdCb.TabIndex = 13;
            this.PatientIdCb.Text = "PatientID";
            this.PatientIdCb.SelectionChangeCommitted += new System.EventHandler(this.PatientIdCb_SelectionChangeCommitted);
            // 
            // PatientTb
            // 
            this.PatientTb.Enabled = false;
            this.PatientTb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientTb.Location = new System.Drawing.Point(63, 359);
            this.PatientTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PatientTb.Name = "PatientTb";
            this.PatientTb.Size = new System.Drawing.Size(220, 36);
            this.PatientTb.TabIndex = 9;
            this.PatientTb.Text = "PatientName";
            // 
            // SymptomsTb
            // 
            this.SymptomsTb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SymptomsTb.Location = new System.Drawing.Point(347, 221);
            this.SymptomsTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SymptomsTb.Name = "SymptomsTb";
            this.SymptomsTb.Size = new System.Drawing.Size(220, 36);
            this.SymptomsTb.TabIndex = 15;
            this.SymptomsTb.Text = "Symptoms";
            this.SymptomsTb.TextChanged += new System.EventHandler(this.SymptomsTb_TextChanged);
            // 
            // DiagnosisTb
            // 
            this.DiagnosisTb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiagnosisTb.Location = new System.Drawing.Point(347, 289);
            this.DiagnosisTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DiagnosisTb.Name = "DiagnosisTb";
            this.DiagnosisTb.Size = new System.Drawing.Size(220, 36);
            this.DiagnosisTb.TabIndex = 16;
            this.DiagnosisTb.Text = "Diagnosis";
            // 
            // MedicineTb
            // 
            this.MedicineTb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MedicineTb.Location = new System.Drawing.Point(347, 359);
            this.MedicineTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MedicineTb.Name = "MedicineTb";
            this.MedicineTb.Size = new System.Drawing.Size(220, 36);
            this.MedicineTb.TabIndex = 17;
            this.MedicineTb.Text = "Medicine";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkCyan;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(253, 515);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 65);
            this.button4.TabIndex = 21;
            this.button4.Text = "HOME";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkCyan;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(379, 441);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 65);
            this.button3.TabIndex = 20;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(253, 441);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 65);
            this.button2.TabIndex = 19;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(126, 441);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 65);
            this.button1.TabIndex = 18;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(663, 763);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 52);
            this.label3.TabIndex = 23;
            this.label3.Text = "DIAGNOSIS LIST";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.Diagnosislbl);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Medicineslbl);
            this.panel2.Controls.Add(this.Symptomslbl);
            this.panel2.Controls.Add(this.PatientNamelbl);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(677, 184);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 575);
            this.panel2.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(311, 517);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(293, 30);
            this.label11.TabIndex = 9;
            this.label11.Text = "By Guransh and Venkatraj";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(194, 488);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(592, 30);
            this.label10.TabIndex = 8;
            this.label10.Text = "DOCTOR APPOINTMENT MANAGEMENT SYSTEM";
            // 
            // Diagnosislbl
            // 
            this.Diagnosislbl.AutoSize = true;
            this.Diagnosislbl.BackColor = System.Drawing.Color.Transparent;
            this.Diagnosislbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Diagnosislbl.ForeColor = System.Drawing.Color.Navy;
            this.Diagnosislbl.Location = new System.Drawing.Point(542, 287);
            this.Diagnosislbl.Name = "Diagnosislbl";
            this.Diagnosislbl.Size = new System.Drawing.Size(130, 34);
            this.Diagnosislbl.TabIndex = 7;
            this.Diagnosislbl.Text = "Diagnosis";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(800, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 35);
            this.label8.TabIndex = 6;
            this.label8.Text = "DATE";
            // 
            // Medicineslbl
            // 
            this.Medicineslbl.AutoSize = true;
            this.Medicineslbl.BackColor = System.Drawing.Color.Transparent;
            this.Medicineslbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Medicineslbl.ForeColor = System.Drawing.Color.Navy;
            this.Medicineslbl.Location = new System.Drawing.Point(194, 287);
            this.Medicineslbl.Name = "Medicineslbl";
            this.Medicineslbl.Size = new System.Drawing.Size(136, 34);
            this.Medicineslbl.TabIndex = 5;
            this.Medicineslbl.Text = "Medicines";
            // 
            // Symptomslbl
            // 
            this.Symptomslbl.AutoSize = true;
            this.Symptomslbl.BackColor = System.Drawing.Color.Transparent;
            this.Symptomslbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Symptomslbl.ForeColor = System.Drawing.Color.Navy;
            this.Symptomslbl.Location = new System.Drawing.Point(542, 163);
            this.Symptomslbl.Name = "Symptomslbl";
            this.Symptomslbl.Size = new System.Drawing.Size(141, 34);
            this.Symptomslbl.TabIndex = 4;
            this.Symptomslbl.Text = "Symptoms";
            // 
            // PatientNamelbl
            // 
            this.PatientNamelbl.AutoSize = true;
            this.PatientNamelbl.BackColor = System.Drawing.Color.Transparent;
            this.PatientNamelbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientNamelbl.ForeColor = System.Drawing.Color.Navy;
            this.PatientNamelbl.Location = new System.Drawing.Point(194, 163);
            this.PatientNamelbl.Name = "PatientNamelbl";
            this.PatientNamelbl.Size = new System.Drawing.Size(175, 34);
            this.PatientNamelbl.TabIndex = 3;
            this.PatientNamelbl.Text = "Patient Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(289, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(456, 46);
            this.label4.TabIndex = 2;
            this.label4.Text = "DIAGNOSIS SUMMARY";
            // 
            // DiagnosisGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DiagnosisGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DiagnosisGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DiagnosisGV.ColumnHeadersHeight = 4;
            this.DiagnosisGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DiagnosisGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DiagnosisGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DiagnosisGV.Location = new System.Drawing.Point(14, 823);
            this.DiagnosisGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DiagnosisGV.Name = "DiagnosisGV";
            this.DiagnosisGV.RowHeadersVisible = false;
            this.DiagnosisGV.RowHeadersWidth = 51;
            this.DiagnosisGV.RowTemplate.Height = 25;
            this.DiagnosisGV.Size = new System.Drawing.Size(1595, 364);
            this.DiagnosisGV.TabIndex = 25;
            this.DiagnosisGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DiagnosisGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DiagnosisGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DiagnosisGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DiagnosisGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DiagnosisGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DiagnosisGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DiagnosisGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DiagnosisGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DiagnosisGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiagnosisGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DiagnosisGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DiagnosisGV.ThemeStyle.HeaderStyle.Height = 4;
            this.DiagnosisGV.ThemeStyle.ReadOnly = false;
            this.DiagnosisGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DiagnosisGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DiagnosisGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiagnosisGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DiagnosisGV.ThemeStyle.RowsStyle.Height = 25;
            this.DiagnosisGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DiagnosisGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DiagnosisGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiagnosisGV_CellContentClick);
            // 
            // DiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 1102);
            this.Controls.Add(this.DiagnosisGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MedicineTb);
            this.Controls.Add(this.DiagnosisTb);
            this.Controls.Add(this.SymptomsTb);
            this.Controls.Add(this.PatientTb);
            this.Controls.Add(this.PatientIdCb);
            this.Controls.Add(this.DiagId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DiagnosisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiagnosisFormcs";
            this.Load += new System.EventHandler(this.DiagnosisFormcs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox DiagId;
        private ComboBox PatientIdCb;
        private TextBox PatientTb;
        private TextBox SymptomsTb;
        private TextBox DiagnosisTb;
        private TextBox MedicineTb;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label3;
        private Panel panel2;
        private Label label11;
        private Label label10;
        private Label Diagnosislbl;
        private Label label8;
        private Label Medicineslbl;
        private Label Symptomslbl;
        private Label PatientNamelbl;
        private Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView DiagnosisGV;
    }
}