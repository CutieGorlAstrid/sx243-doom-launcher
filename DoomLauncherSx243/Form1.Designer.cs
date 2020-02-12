namespace DoomLauncherSx243
{
    partial class MainWindow
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
            this.iwadSelect = new System.Windows.Forms.ComboBox();
            this.iwadLabel = new System.Windows.Forms.Label();
            this.launchButton = new System.Windows.Forms.Button();
            this.pwadSelect = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sourcePortLabel = new System.Windows.Forms.Label();
            this.chooseSPButton = new System.Windows.Forms.Button();
            this.chooseSourcePort = new System.Windows.Forms.OpenFileDialog();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // iwadSelect
            // 
            this.iwadSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iwadSelect.FormattingEnabled = true;
            this.iwadSelect.Location = new System.Drawing.Point(54, 9);
            this.iwadSelect.Name = "iwadSelect";
            this.iwadSelect.Size = new System.Drawing.Size(183, 21);
            this.iwadSelect.TabIndex = 0;
            // 
            // iwadLabel
            // 
            this.iwadLabel.AutoSize = true;
            this.iwadLabel.Location = new System.Drawing.Point(12, 12);
            this.iwadLabel.Name = "iwadLabel";
            this.iwadLabel.Size = new System.Drawing.Size(36, 13);
            this.iwadLabel.TabIndex = 1;
            this.iwadLabel.Text = "IWAD";
            // 
            // launchButton
            // 
            this.launchButton.Location = new System.Drawing.Point(232, 314);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(75, 23);
            this.launchButton.TabIndex = 4;
            this.launchButton.Text = "Launch";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pwadSelect
            // 
            this.pwadSelect.FormattingEnabled = true;
            this.pwadSelect.Location = new System.Drawing.Point(13, 85);
            this.pwadSelect.Name = "pwadSelect";
            this.pwadSelect.ScrollAlwaysVisible = true;
            this.pwadSelect.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.pwadSelect.Size = new System.Drawing.Size(292, 225);
            this.pwadSelect.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "PWADs";
            // 
            // sourcePortLabel
            // 
            this.sourcePortLabel.AutoSize = true;
            this.sourcePortLabel.Location = new System.Drawing.Point(130, 41);
            this.sourcePortLabel.Name = "sourcePortLabel";
            this.sourcePortLabel.Size = new System.Drawing.Size(68, 13);
            this.sourcePortLabel.TabIndex = 3;
            this.sourcePortLabel.Text = "Source port: ";
            // 
            // chooseSPButton
            // 
            this.chooseSPButton.Location = new System.Drawing.Point(13, 36);
            this.chooseSPButton.Name = "chooseSPButton";
            this.chooseSPButton.Size = new System.Drawing.Size(111, 23);
            this.chooseSPButton.TabIndex = 7;
            this.chooseSPButton.Text = "Choose source port";
            this.chooseSPButton.UseVisualStyleBackColor = true;
            this.chooseSPButton.Click += new System.EventHandler(this.chooseSPButton_Click);
            // 
            // chooseSourcePort
            // 
            this.chooseSourcePort.Filter = "Executable files|*.exe";
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(12, 314);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(164, 23);
            this.helpButton.TabIndex = 8;
            this.helpButton.Text = "I\'m not seeing all my PWADs...";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 349);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.chooseSPButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pwadSelect);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.sourcePortLabel);
            this.Controls.Add(this.iwadLabel);
            this.Controls.Add(this.iwadSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "SpeedStriker243\'s Doom Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox iwadSelect;
        private System.Windows.Forms.Label iwadLabel;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.ListBox pwadSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sourcePortLabel;
        private System.Windows.Forms.Button chooseSPButton;
        private System.Windows.Forms.OpenFileDialog chooseSourcePort;
        private System.Windows.Forms.Button helpButton;
    }
}

