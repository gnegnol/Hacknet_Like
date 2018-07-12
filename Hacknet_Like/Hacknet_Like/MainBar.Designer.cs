namespace Hacknet_Like {
    partial class MainBar {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose( bool disposing ) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent() {
            this.openTerminalButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.layoutSaverButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openTerminalButton
            // 
            this.openTerminalButton.BackgroundImage = global::Hacknet_Like.Properties.Resources.ic_picture_in_picture_black_48dp;
            this.openTerminalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openTerminalButton.FlatAppearance.BorderSize = 0;
            this.openTerminalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openTerminalButton.Location = new System.Drawing.Point(335, 10);
            this.openTerminalButton.Name = "openTerminalButton";
            this.openTerminalButton.Size = new System.Drawing.Size(50, 50);
            this.openTerminalButton.TabIndex = 1;
            this.openTerminalButton.UseVisualStyleBackColor = true;
            this.openTerminalButton.Click += new System.EventHandler(this.openTerminalButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackgroundImage = global::Hacknet_Like.Properties.Resources.ic_power_settings_new_black_48dp;
            this.quitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quitButton.FlatAppearance.BorderSize = 0;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Location = new System.Drawing.Point(658, 10);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(50, 50);
            this.quitButton.TabIndex = 0;
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // layoutSaverButton
            // 
            this.layoutSaverButton.BackgroundImage = global::Hacknet_Like.Properties.Resources.ic_web_black_48dp;
            this.layoutSaverButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.layoutSaverButton.FlatAppearance.BorderSize = 0;
            this.layoutSaverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.layoutSaverButton.Location = new System.Drawing.Point(433, 12);
            this.layoutSaverButton.Name = "layoutSaverButton";
            this.layoutSaverButton.Size = new System.Drawing.Size(50, 50);
            this.layoutSaverButton.TabIndex = 2;
            this.layoutSaverButton.UseVisualStyleBackColor = true;
            this.layoutSaverButton.Click += new System.EventHandler(this.layoutSaverButton_Click);
            // 
            // MainBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(720, 70);
            this.Controls.Add(this.layoutSaverButton);
            this.Controls.Add(this.openTerminalButton);
            this.Controls.Add(this.quitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainBar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button openTerminalButton;
        private System.Windows.Forms.Button layoutSaverButton;
    }
}

