namespace MovieTicketBookingSystem.PLL
{
    partial class Welcome
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
            this.Exit_button = new System.Windows.Forms.Button();
            this.Login_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Exit_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Exit_button.FlatAppearance.BorderSize = 0;
            this.Exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button.Location = new System.Drawing.Point(687, 468);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(73, 33);
            this.Exit_button.TabIndex = 92;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Login_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Login_button.FlatAppearance.BorderSize = 0;
            this.Login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.Location = new System.Drawing.Point(560, 468);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(73, 33);
            this.Login_button.TabIndex = 91;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Project.Properties.Resources.COVER;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 559);
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 538);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Welcome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Welcome_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}