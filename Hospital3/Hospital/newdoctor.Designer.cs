﻿namespace Hospital
{
    partial class newdoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newdoctor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addnewdoc = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.ID_Textbox = new System.Windows.Forms.TextBox();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.Speciality_TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.addnewdoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 50);
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
            this.label2.Location = new System.Drawing.Point(30, 109);
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
            this.label3.Location = new System.Drawing.Point(30, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Specialty";
            // 
            // addnewdoc
            // 
            this.addnewdoc.BackColor = System.Drawing.Color.Transparent;
            this.addnewdoc.Image = global::Hospital.Properties.Resources.button_done;
            this.addnewdoc.Location = new System.Drawing.Point(349, 205);
            this.addnewdoc.Name = "addnewdoc";
            this.addnewdoc.Size = new System.Drawing.Size(100, 50);
            this.addnewdoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addnewdoc.TabIndex = 6;
            this.addnewdoc.TabStop = false;
            this.addnewdoc.Click += new System.EventHandler(this.addnewdoc_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Image = global::Hospital.Properties.Resources.button_back;
            this.back.Location = new System.Drawing.Point(12, 205);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(100, 50);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.back.TabIndex = 7;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ID_Textbox
            // 
            this.ID_Textbox.Location = new System.Drawing.Point(120, 49);
            this.ID_Textbox.Name = "ID_Textbox";
            this.ID_Textbox.Size = new System.Drawing.Size(130, 20);
            this.ID_Textbox.TabIndex = 8;
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(120, 108);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(130, 20);
            this.Name_TextBox.TabIndex = 9;
            // 
            // Speciality_TextBox
            // 
            this.Speciality_TextBox.Location = new System.Drawing.Point(120, 155);
            this.Speciality_TextBox.Name = "Speciality_TextBox";
            this.Speciality_TextBox.Size = new System.Drawing.Size(130, 20);
            this.Speciality_TextBox.TabIndex = 10;
            // 
            // newdoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(461, 272);
            this.ControlBox = false;
            this.Controls.Add(this.Speciality_TextBox);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.ID_Textbox);
            this.Controls.Add(this.back);
            this.Controls.Add(this.addnewdoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "newdoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Doctor";
            ((System.ComponentModel.ISupportInitialize)(this.addnewdoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox addnewdoc;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.TextBox ID_Textbox;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.TextBox Speciality_TextBox;
    }
}