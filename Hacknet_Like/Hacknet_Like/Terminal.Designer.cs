namespace Hacknet_Like {
    partial class Terminal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Terminal));
            this.terminalTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // terminalTextBox
            // 
            this.terminalTextBox.BackColor = System.Drawing.Color.Black;
            this.terminalTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.terminalTextBox.Font = new System.Drawing.Font("Ubuntu Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terminalTextBox.ForeColor = System.Drawing.Color.White;
            this.terminalTextBox.Location = new System.Drawing.Point(0, 0);
            this.terminalTextBox.Multiline = true;
            this.terminalTextBox.Name = "terminalTextBox";
            this.terminalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.terminalTextBox.Size = new System.Drawing.Size(824, 374);
            this.terminalTextBox.TabIndex = 1;
            this.terminalTextBox.Text = "Microsoft Windows [Version 10.0.17134.112]\r\n(c) 2018 Microsoft Corporation. All r" +
    "ights reserved.\r\n\r\nC:\\Users\\LadyGay69>";
            this.terminalTextBox.WordWrap = false;
            this.terminalTextBox.TextChanged += new System.EventHandler(this.terminalTextBox_TextChanged);
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(824, 374);
            this.Controls.Add(this.terminalTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Terminal";
            this.Text = "Terminal";
            this.Load += new System.EventHandler(this.Terminal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox terminalTextBox;
    }
}