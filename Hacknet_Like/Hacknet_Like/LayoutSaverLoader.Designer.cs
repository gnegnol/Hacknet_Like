namespace Hacknet_Like {
    partial class LayoutSaverLoader {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LayoutSaverLoader));
            this.closePrompt = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.loadLayoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loadGroup = new System.Windows.Forms.GroupBox();
            this.saveGroup = new System.Windows.Forms.GroupBox();
            this.saveFileName = new System.Windows.Forms.TextBox();
            this.saveLayoutButton = new System.Windows.Forms.Button();
            this.loadGroup.SuspendLayout();
            this.saveGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // closePrompt
            // 
            this.closePrompt.BackgroundImage = global::Hacknet_Like.Properties.Resources.ic_close_black_48dp;
            this.closePrompt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closePrompt.FlatAppearance.BorderSize = 0;
            this.closePrompt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closePrompt.Location = new System.Drawing.Point(516, 0);
            this.closePrompt.Name = "closePrompt";
            this.closePrompt.Size = new System.Drawing.Size(30, 30);
            this.closePrompt.TabIndex = 2;
            this.closePrompt.UseVisualStyleBackColor = true;
            this.closePrompt.Click += new System.EventHandler(this.closePrompt_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 29);
            this.comboBox1.TabIndex = 3;
            // 
            // loadLayoutButton
            // 
            this.loadLayoutButton.BackgroundImage = global::Hacknet_Like.Properties.Resources.outline_load_alt_black_18dp;
            this.loadLayoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loadLayoutButton.FlatAppearance.BorderSize = 0;
            this.loadLayoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadLayoutButton.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadLayoutButton.Location = new System.Drawing.Point(3, 44);
            this.loadLayoutButton.Name = "loadLayoutButton";
            this.loadLayoutButton.Size = new System.Drawing.Size(64, 39);
            this.loadLayoutButton.TabIndex = 4;
            this.loadLayoutButton.UseVisualStyleBackColor = true;
            this.loadLayoutButton.Click += new System.EventHandler(this.loadLayoutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Layout Manager";
            // 
            // loadGroup
            // 
            this.loadGroup.Controls.Add(this.comboBox1);
            this.loadGroup.Controls.Add(this.loadLayoutButton);
            this.loadGroup.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadGroup.Location = new System.Drawing.Point(12, 55);
            this.loadGroup.Name = "loadGroup";
            this.loadGroup.Size = new System.Drawing.Size(209, 125);
            this.loadGroup.TabIndex = 6;
            this.loadGroup.TabStop = false;
            this.loadGroup.Text = "Load";
            // 
            // saveGroup
            // 
            this.saveGroup.Controls.Add(this.saveFileName);
            this.saveGroup.Controls.Add(this.saveLayoutButton);
            this.saveGroup.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveGroup.Location = new System.Drawing.Point(288, 55);
            this.saveGroup.Name = "saveGroup";
            this.saveGroup.Size = new System.Drawing.Size(246, 125);
            this.saveGroup.TabIndex = 7;
            this.saveGroup.TabStop = false;
            this.saveGroup.Text = "Save";
            // 
            // saveFileName
            // 
            this.saveFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saveFileName.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFileName.Location = new System.Drawing.Point(99, 54);
            this.saveFileName.Name = "saveFileName";
            this.saveFileName.Size = new System.Drawing.Size(141, 21);
            this.saveFileName.TabIndex = 5;
            this.saveFileName.Text = "layout1.xml";
            // 
            // saveLayoutButton
            // 
            this.saveLayoutButton.BackgroundImage = global::Hacknet_Like.Properties.Resources.outline_save_alt_black_18dp;
            this.saveLayoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.saveLayoutButton.FlatAppearance.BorderSize = 0;
            this.saveLayoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveLayoutButton.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLayoutButton.Location = new System.Drawing.Point(6, 35);
            this.saveLayoutButton.Name = "saveLayoutButton";
            this.saveLayoutButton.Size = new System.Drawing.Size(87, 56);
            this.saveLayoutButton.TabIndex = 4;
            this.saveLayoutButton.UseVisualStyleBackColor = true;
            this.saveLayoutButton.Click += new System.EventHandler(this.saveLayoutButton_Click);
            // 
            // LayoutSaverLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(546, 192);
            this.Controls.Add(this.saveGroup);
            this.Controls.Add(this.loadGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closePrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LayoutSaverLoader";
            this.ShowInTaskbar = false;
            this.Text = "LayoutSaverLoader";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LayoutSaverLoader_Load);
            this.loadGroup.ResumeLayout(false);
            this.saveGroup.ResumeLayout(false);
            this.saveGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closePrompt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button loadLayoutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox loadGroup;
        private System.Windows.Forms.GroupBox saveGroup;
        private System.Windows.Forms.TextBox saveFileName;
        private System.Windows.Forms.Button saveLayoutButton;
    }
}