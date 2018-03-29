namespace Hospital
{
    partial class findbydisease
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
            this.Data_of_patients_with_disease_table = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Disease = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.search_for_disease = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Data_of_patients_with_disease_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_for_disease)).BeginInit();
            this.SuspendLayout();
            // 
            // Data_of_patients_with_disease_table
            // 
            this.Data_of_patients_with_disease_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_of_patients_with_disease_table.Location = new System.Drawing.Point(2, 53);
            this.Data_of_patients_with_disease_table.Name = "Data_of_patients_with_disease_table";
            this.Data_of_patients_with_disease_table.Size = new System.Drawing.Size(457, 162);
            this.Data_of_patients_with_disease_table.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter The Disease";
            // 
            // Disease
            // 
            this.Disease.Location = new System.Drawing.Point(157, 12);
            this.Disease.Name = "Disease";
            this.Disease.Size = new System.Drawing.Size(136, 20);
            this.Disease.TabIndex = 4;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Image = global::Hospital.Properties.Resources.button_back;
            this.back.Location = new System.Drawing.Point(12, 221);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(100, 50);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.back.TabIndex = 2;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // search_for_disease
            // 
            this.search_for_disease.BackColor = System.Drawing.Color.Transparent;
            this.search_for_disease.Image = global::Hospital.Properties.Resources.button_search;
            this.search_for_disease.Location = new System.Drawing.Point(349, -3);
            this.search_for_disease.Name = "search_for_disease";
            this.search_for_disease.Size = new System.Drawing.Size(100, 50);
            this.search_for_disease.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.search_for_disease.TabIndex = 1;
            this.search_for_disease.TabStop = false;
            this.search_for_disease.Click += new System.EventHandler(this.search_for_disease_Click);
            // 
            // findbydisease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital.Properties.Resources._25465853_1928419437376115_1165748018_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(461, 276);
            this.ControlBox = false;
            this.Controls.Add(this.Disease);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.search_for_disease);
            this.Controls.Add(this.Data_of_patients_with_disease_table);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "findbydisease";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Disease";
            ((System.ComponentModel.ISupportInitialize)(this.Data_of_patients_with_disease_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_for_disease)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Data_of_patients_with_disease_table;
        private System.Windows.Forms.PictureBox search_for_disease;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Disease;
    }
}