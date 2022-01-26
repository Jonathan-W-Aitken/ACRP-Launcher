namespace ACRP_Launcher
{
    partial class ACRPLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACRPLauncher));
            this.ACRPLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ACRPLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ACRPLogo
            // 
            this.ACRPLogo.BackColor = System.Drawing.Color.Transparent;
            this.ACRPLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ACRPLogo.BackgroundImage")));
            this.ACRPLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ACRPLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ACRPLogo.Location = new System.Drawing.Point(0, 0);
            this.ACRPLogo.Name = "ACRPLogo";
            this.ACRPLogo.Size = new System.Drawing.Size(921, 535);
            this.ACRPLogo.TabIndex = 0;
            this.ACRPLogo.TabStop = false;
            this.ACRPLogo.Click += new System.EventHandler(this.ACRPLogo_Click);
            // 
            // ACRPLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(921, 535);
            this.Controls.Add(this.ACRPLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ACRPLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACRPLauncher";
            ((System.ComponentModel.ISupportInitialize)(this.ACRPLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ACRPLogo;
    }
}

