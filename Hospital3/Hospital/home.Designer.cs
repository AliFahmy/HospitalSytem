namespace Hospital
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.add_newdoc = new System.Windows.Forms.PictureBox();
            this.add_newpatient = new System.Windows.Forms.PictureBox();
            this.findbydisease = new System.Windows.Forms.PictureBox();
            this.findbydoc = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.add_newdoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_newpatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findbydisease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findbydoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // add_newdoc
            // 
            this.add_newdoc.BackColor = System.Drawing.Color.Transparent;
            this.add_newdoc.Image = ((System.Drawing.Image)(resources.GetObject("add_newdoc.Image")));
            this.add_newdoc.Location = new System.Drawing.Point(12, 24);
            this.add_newdoc.Name = "add_newdoc";
            this.add_newdoc.Size = new System.Drawing.Size(129, 37);
            this.add_newdoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.add_newdoc.TabIndex = 0;
            this.add_newdoc.TabStop = false;
            this.add_newdoc.Click += new System.EventHandler(this.add_newdoc_Click);
            // 
            // add_newpatient
            // 
            this.add_newpatient.BackColor = System.Drawing.Color.Transparent;
            this.add_newpatient.Image = ((System.Drawing.Image)(resources.GetObject("add_newpatient.Image")));
            this.add_newpatient.Location = new System.Drawing.Point(310, 24);
            this.add_newpatient.Name = "add_newpatient";
            this.add_newpatient.Size = new System.Drawing.Size(127, 37);
            this.add_newpatient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.add_newpatient.TabIndex = 1;
            this.add_newpatient.TabStop = false;
            this.add_newpatient.Click += new System.EventHandler(this.add_newpatient_Click);
            // 
            // findbydisease
            // 
            this.findbydisease.BackColor = System.Drawing.Color.Transparent;
            this.findbydisease.Image = ((System.Drawing.Image)(resources.GetObject("findbydisease.Image")));
            this.findbydisease.Location = new System.Drawing.Point(310, 120);
            this.findbydisease.Name = "findbydisease";
            this.findbydisease.Size = new System.Drawing.Size(127, 39);
            this.findbydisease.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.findbydisease.TabIndex = 2;
            this.findbydisease.TabStop = false;
            this.findbydisease.Click += new System.EventHandler(this.findbydisease_Click);
            // 
            // findbydoc
            // 
            this.findbydoc.BackColor = System.Drawing.Color.Transparent;
            this.findbydoc.Image = ((System.Drawing.Image)(resources.GetObject("findbydoc.Image")));
            this.findbydoc.Location = new System.Drawing.Point(12, 120);
            this.findbydoc.Name = "findbydoc";
            this.findbydoc.Size = new System.Drawing.Size(129, 39);
            this.findbydoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.findbydoc.TabIndex = 3;
            this.findbydoc.TabStop = false;
            this.findbydoc.Click += new System.EventHandler(this.findbydoc_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(171, 204);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(127, 38);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 4;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(461, 276);
            this.ControlBox = false;
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.findbydoc);
            this.Controls.Add(this.findbydisease);
            this.Controls.Add(this.add_newpatient);
            this.Controls.Add(this.add_newdoc);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.add_newdoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_newpatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findbydisease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findbydoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox add_newdoc;
        private System.Windows.Forms.PictureBox add_newpatient;
        private System.Windows.Forms.PictureBox findbydisease;
        private System.Windows.Forms.PictureBox findbydoc;
        private System.Windows.Forms.PictureBox Exit;
    }
}

