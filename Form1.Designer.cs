namespace HMS___CA_ONE
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.doctorBtn = new System.Windows.Forms.Button();
            this.patientBtn = new System.Windows.Forms.Button();
            this.nurseBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Private Hospital";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // doctorBtn
            // 
            this.doctorBtn.Location = new System.Drawing.Point(137, 195);
            this.doctorBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.doctorBtn.Name = "doctorBtn";
            this.doctorBtn.Size = new System.Drawing.Size(154, 68);
            this.doctorBtn.TabIndex = 2;
            this.doctorBtn.Text = "Doctor";
            this.doctorBtn.UseVisualStyleBackColor = true;
            this.doctorBtn.Click += new System.EventHandler(this.doctorBtn_Click);
            // 
            // patientBtn
            // 
            this.patientBtn.Location = new System.Drawing.Point(137, 100);
            this.patientBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.patientBtn.Name = "patientBtn";
            this.patientBtn.Size = new System.Drawing.Size(154, 68);
            this.patientBtn.TabIndex = 4;
            this.patientBtn.Text = "Patient";
            this.patientBtn.UseVisualStyleBackColor = true;
            this.patientBtn.Click += new System.EventHandler(this.patientBtn_Click);
            // 
            // nurseBtn
            // 
            this.nurseBtn.Location = new System.Drawing.Point(137, 293);
            this.nurseBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nurseBtn.Name = "nurseBtn";
            this.nurseBtn.Size = new System.Drawing.Size(154, 68);
            this.nurseBtn.TabIndex = 5;
            this.nurseBtn.Text = "Nurse";
            this.nurseBtn.UseVisualStyleBackColor = true;
            this.nurseBtn.Click += new System.EventHandler(this.nurseBtn_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(137, 393);
            this.viewBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(154, 68);
            this.viewBtn.TabIndex = 6;
            this.viewBtn.Text = "View";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 508);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.nurseBtn);
            this.Controls.Add(this.patientBtn);
            this.Controls.Add(this.doctorBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button doctorBtn;
        private System.Windows.Forms.Button patientBtn;
        private System.Windows.Forms.Button nurseBtn;
        private System.Windows.Forms.Button viewBtn;
    }
}

