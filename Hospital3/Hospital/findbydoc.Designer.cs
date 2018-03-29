namespace Hospital
{
    partial class findbydoc
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
            this.data_findbyname = new System.Windows.Forms.DataGridView();
            this.Doctor_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbyname = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_findbyname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchbyname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // data_findbyname
            // 
            this.data_findbyname.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.data_findbyname.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_findbyname.Location = new System.Drawing.Point(5, 49);
            this.data_findbyname.Name = "data_findbyname";
            this.data_findbyname.Size = new System.Drawing.Size(451, 173);
            this.data_findbyname.TabIndex = 0;
            // 
            // Doctor_TextBox
            // 
            this.Doctor_TextBox.AccessibleDescription = "";
            this.Doctor_TextBox.AccessibleName = "";
            this.Doctor_TextBox.Location = new System.Drawing.Point(188, 12);
            this.Doctor_TextBox.Name = "Doctor_TextBox";
            this.Doctor_TextBox.Size = new System.Drawing.Size(150, 20);
            this.Doctor_TextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter The Doctor Name";
            // 
            // searchbyname
            // 
            this.searchbyname.BackColor = System.Drawing.Color.Transparent;
            this.searchbyname.Image = global::Hospital.Properties.Resources.button_search;
            this.searchbyname.Location = new System.Drawing.Point(349, -2);
            this.searchbyname.Name = "searchbyname";
            this.searchbyname.Size = new System.Drawing.Size(100, 50);
            this.searchbyname.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchbyname.TabIndex = 4;
            this.searchbyname.TabStop = false;
            this.searchbyname.Click += new System.EventHandler(this.searchbyname_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Image = global::Hospital.Properties.Resources.button_back;
            this.back.Location = new System.Drawing.Point(5, 228);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(100, 50);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.back.TabIndex = 3;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // findbydoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital.Properties.Resources._25465770_1928419614042764_72504135_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(461, 276);
            this.ControlBox = false;
            this.Controls.Add(this.searchbyname);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Doctor_TextBox);
            this.Controls.Add(this.data_findbyname);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "findbydoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Doctor";
            this.Load += new System.EventHandler(this.findbydoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_findbyname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchbyname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_findbyname;
        private System.Windows.Forms.TextBox Doctor_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.PictureBox searchbyname;
    }
}