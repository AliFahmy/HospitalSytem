namespace Hospital
{
    partial class newpatient
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Disease = new System.Windows.Forms.TextBox();
            this.Doctor_ID_textbox = new System.Windows.Forms.TextBox();
            this.Date_textbox = new System.Windows.Forms.TextBox();
            this.add_patient = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.add_patient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(53, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Disease";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doctor ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = " Appointment Date";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(180, 8);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(124, 20);
            this.ID.TabIndex = 5;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(180, 48);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(124, 20);
            this.Name.TabIndex = 6;
            // 
            // Disease
            // 
            this.Disease.Location = new System.Drawing.Point(180, 95);
            this.Disease.Name = "Disease";
            this.Disease.Size = new System.Drawing.Size(124, 20);
            this.Disease.TabIndex = 7;
            // 
            // Doctor_ID_textbox
            // 
            this.Doctor_ID_textbox.Location = new System.Drawing.Point(180, 141);
            this.Doctor_ID_textbox.Name = "Doctor_ID_textbox";
            this.Doctor_ID_textbox.Size = new System.Drawing.Size(124, 20);
            this.Doctor_ID_textbox.TabIndex = 8;
            // 
            // Date_textbox
            // 
            this.Date_textbox.Location = new System.Drawing.Point(180, 186);
            this.Date_textbox.Name = "Date_textbox";
            this.Date_textbox.Size = new System.Drawing.Size(124, 20);
            this.Date_textbox.TabIndex = 9;
            // 
            // add_patient
            // 
            this.add_patient.BackColor = System.Drawing.Color.Transparent;
            this.add_patient.Image = global::Hospital.Properties.Resources.button_done;
            this.add_patient.Location = new System.Drawing.Point(349, 208);
            this.add_patient.Name = "add_patient";
            this.add_patient.Size = new System.Drawing.Size(100, 50);
            this.add_patient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.add_patient.TabIndex = 11;
            this.add_patient.TabStop = false;
            this.add_patient.Click += new System.EventHandler(this.add_patient_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Image = global::Hospital.Properties.Resources.button_back;
            this.back.Location = new System.Drawing.Point(6, 210);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(100, 50);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.back.TabIndex = 0;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_click);
            // 
            // newpatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital.Properties.Resources._25465853_1928419437376115_1165748018_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(461, 272);
            this.ControlBox = false;
            this.Controls.Add(this.back);
            this.Controls.Add(this.add_patient);
            this.Controls.Add(this.Date_textbox);
            this.Controls.Add(this.Doctor_ID_textbox);
            this.Controls.Add(this.Disease);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Patient";
            ((System.ComponentModel.ISupportInitialize)(this.add_patient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Disease;
        private System.Windows.Forms.TextBox Doctor_ID_textbox;
        private System.Windows.Forms.TextBox Date_textbox;
        private System.Windows.Forms.PictureBox add_patient;
        private System.Windows.Forms.PictureBox back;
    }
}