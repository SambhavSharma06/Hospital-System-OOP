namespace HMS___CA_ONE
{
    partial class ViewPersons
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.patientBtn = new System.Windows.Forms.Button();
            this.doctorBtn = new System.Windows.Forms.Button();
            this.nurseBtn = new System.Windows.Forms.Button();
            this.querycomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.Snow;
            this.dataGridView.Location = new System.Drawing.Point(23, 94);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(852, 306);
            this.dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(315, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click to view queries";
            // 
            // patientBtn
            // 
            this.patientBtn.BackColor = System.Drawing.Color.Tomato;
            this.patientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.patientBtn.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientBtn.ForeColor = System.Drawing.Color.White;
            this.patientBtn.Location = new System.Drawing.Point(58, 439);
            this.patientBtn.Name = "patientBtn";
            this.patientBtn.Size = new System.Drawing.Size(107, 46);
            this.patientBtn.TabIndex = 2;
            this.patientBtn.Text = "Patients";
            this.patientBtn.UseVisualStyleBackColor = false;
            this.patientBtn.Click += new System.EventHandler(this.patientBtn_Click);
            // 
            // doctorBtn
            // 
            this.doctorBtn.BackColor = System.Drawing.Color.Tomato;
            this.doctorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.doctorBtn.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorBtn.ForeColor = System.Drawing.Color.White;
            this.doctorBtn.Location = new System.Drawing.Point(212, 439);
            this.doctorBtn.Name = "doctorBtn";
            this.doctorBtn.Size = new System.Drawing.Size(107, 46);
            this.doctorBtn.TabIndex = 3;
            this.doctorBtn.Text = "Doctors";
            this.doctorBtn.UseVisualStyleBackColor = false;
            this.doctorBtn.Click += new System.EventHandler(this.doctorBtn_Click);
            // 
            // nurseBtn
            // 
            this.nurseBtn.BackColor = System.Drawing.Color.Tomato;
            this.nurseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nurseBtn.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseBtn.ForeColor = System.Drawing.Color.White;
            this.nurseBtn.Location = new System.Drawing.Point(371, 439);
            this.nurseBtn.Name = "nurseBtn";
            this.nurseBtn.Size = new System.Drawing.Size(107, 46);
            this.nurseBtn.TabIndex = 4;
            this.nurseBtn.Text = "Nurses";
            this.nurseBtn.UseVisualStyleBackColor = false;
            this.nurseBtn.Click += new System.EventHandler(this.nurseBtn_Click);
            // 
            // querycomboBox
            // 
            this.querycomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.querycomboBox.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.querycomboBox.FormattingEnabled = true;
            this.querycomboBox.Items.AddRange(new object[] {
            "All nurses who are Male.",
            "Patients above the age of 25.",
            "Doctors with high pay.",
            "Nurses working over 40 hours."});
            this.querycomboBox.Location = new System.Drawing.Point(553, 448);
            this.querycomboBox.Name = "querycomboBox";
            this.querycomboBox.Size = new System.Drawing.Size(299, 30);
            this.querycomboBox.TabIndex = 5;
            this.querycomboBox.SelectedIndexChanged += new System.EventHandler(this.querycomboBox_SelectedIndexChanged);
            // 
            // ViewPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 531);
            this.Controls.Add(this.querycomboBox);
            this.Controls.Add(this.nurseBtn);
            this.Controls.Add(this.doctorBtn);
            this.Controls.Add(this.patientBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Name = "ViewPersons";
            this.Text = "ViewPersons";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button patientBtn;
        private System.Windows.Forms.Button doctorBtn;
        private System.Windows.Forms.Button nurseBtn;
        private System.Windows.Forms.ComboBox querycomboBox;
    }
}