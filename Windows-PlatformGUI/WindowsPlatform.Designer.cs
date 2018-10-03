namespace Windows_PlatformGUI
{
    partial class WindowsPlatform
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
            this.SignalLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CommandBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CommandButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.PingButton = new System.Windows.Forms.Button();
            this.RobotStatus = new System.Windows.Forms.Button();
            this.StatusCheck = new System.Windows.Forms.Label();
            this.LEDButton = new System.Windows.Forms.Button();
            this.buttonOff = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonMagenta = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonWhite = new System.Windows.Forms.Button();
            this.buttonCyan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignalLabel
            // 
            this.SignalLabel.AutoSize = true;
            this.SignalLabel.Location = new System.Drawing.Point(9, 35);
            this.SignalLabel.Name = "SignalLabel";
            this.SignalLabel.Size = new System.Drawing.Size(16, 13);
            this.SignalLabel.TabIndex = 0;
            this.SignalLabel.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DATA SIGNAL";
            // 
            // CommandBox
            // 
            this.CommandBox.Location = new System.Drawing.Point(15, 161);
            this.CommandBox.Name = "CommandBox";
            this.CommandBox.Size = new System.Drawing.Size(239, 20);
            this.CommandBox.TabIndex = 2;
            this.CommandBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CommandBox_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Command";
            // 
            // CommandButton
            // 
            this.CommandButton.Location = new System.Drawing.Point(12, 187);
            this.CommandButton.Name = "CommandButton";
            this.CommandButton.Size = new System.Drawing.Size(239, 57);
            this.CommandButton.TabIndex = 4;
            this.CommandButton.Text = "Send Command";
            this.CommandButton.UseVisualStyleBackColor = true;
            this.CommandButton.Click += new System.EventHandler(this.CommandButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(179, 106);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // PingButton
            // 
            this.PingButton.Location = new System.Drawing.Point(12, 106);
            this.PingButton.Name = "PingButton";
            this.PingButton.Size = new System.Drawing.Size(75, 23);
            this.PingButton.TabIndex = 7;
            this.PingButton.Text = "Ping";
            this.PingButton.UseVisualStyleBackColor = true;
            this.PingButton.Click += new System.EventHandler(this.PingButton_Click);
            // 
            // RobotStatus
            // 
            this.RobotStatus.BackColor = System.Drawing.Color.Red;
            this.RobotStatus.Enabled = false;
            this.RobotStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RobotStatus.Location = new System.Drawing.Point(179, 77);
            this.RobotStatus.Name = "RobotStatus";
            this.RobotStatus.Size = new System.Drawing.Size(75, 23);
            this.RobotStatus.TabIndex = 8;
            this.RobotStatus.Text = "Offline";
            this.RobotStatus.UseVisualStyleBackColor = false;
            // 
            // StatusCheck
            // 
            this.StatusCheck.AutoSize = true;
            this.StatusCheck.Location = new System.Drawing.Point(176, 61);
            this.StatusCheck.Name = "StatusCheck";
            this.StatusCheck.Size = new System.Drawing.Size(37, 13);
            this.StatusCheck.TabIndex = 9;
            this.StatusCheck.Text = "Status";
            // 
            // LEDButton
            // 
            this.LEDButton.BackColor = System.Drawing.Color.LightGray;
            this.LEDButton.Enabled = false;
            this.LEDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LEDButton.Location = new System.Drawing.Point(12, 77);
            this.LEDButton.Name = "LEDButton";
            this.LEDButton.Size = new System.Drawing.Size(75, 23);
            this.LEDButton.TabIndex = 10;
            this.LEDButton.Text = "LED Color";
            this.LEDButton.UseVisualStyleBackColor = false;
            // 
            // buttonOff
            // 
            this.buttonOff.BackColor = System.Drawing.Color.LightGray;
            this.buttonOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOff.Location = new System.Drawing.Point(93, 77);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(10, 10);
            this.buttonOff.TabIndex = 11;
            this.buttonOff.UseVisualStyleBackColor = false;
            this.buttonOff.Click += new System.EventHandler(this.buttonOff_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRed.Location = new System.Drawing.Point(93, 90);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(10, 10);
            this.buttonRed.TabIndex = 12;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBlue.Location = new System.Drawing.Point(109, 90);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(10, 10);
            this.buttonBlue.TabIndex = 14;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGreen.Location = new System.Drawing.Point(109, 77);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(10, 10);
            this.buttonGreen.TabIndex = 13;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonMagenta
            // 
            this.buttonMagenta.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonMagenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMagenta.Location = new System.Drawing.Point(125, 90);
            this.buttonMagenta.Name = "buttonMagenta";
            this.buttonMagenta.Size = new System.Drawing.Size(10, 10);
            this.buttonMagenta.TabIndex = 16;
            this.buttonMagenta.UseVisualStyleBackColor = false;
            this.buttonMagenta.Click += new System.EventHandler(this.buttonMagenta_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYellow.Location = new System.Drawing.Point(125, 77);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(10, 10);
            this.buttonYellow.TabIndex = 15;
            this.buttonYellow.UseVisualStyleBackColor = false;
            this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
            // 
            // buttonWhite
            // 
            this.buttonWhite.BackColor = System.Drawing.Color.White;
            this.buttonWhite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWhite.Location = new System.Drawing.Point(141, 90);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(10, 10);
            this.buttonWhite.TabIndex = 18;
            this.buttonWhite.UseVisualStyleBackColor = false;
            this.buttonWhite.Click += new System.EventHandler(this.buttonWhite_Click);
            // 
            // buttonCyan
            // 
            this.buttonCyan.BackColor = System.Drawing.Color.Aqua;
            this.buttonCyan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCyan.Location = new System.Drawing.Point(141, 77);
            this.buttonCyan.Name = "buttonCyan";
            this.buttonCyan.Size = new System.Drawing.Size(10, 10);
            this.buttonCyan.TabIndex = 17;
            this.buttonCyan.UseVisualStyleBackColor = false;
            this.buttonCyan.Click += new System.EventHandler(this.buttonCyan_Click);
            // 
            // WindowsPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 256);
            this.Controls.Add(this.buttonWhite);
            this.Controls.Add(this.buttonCyan);
            this.Controls.Add(this.buttonMagenta);
            this.Controls.Add(this.buttonYellow);
            this.Controls.Add(this.buttonBlue);
            this.Controls.Add(this.buttonGreen);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonOff);
            this.Controls.Add(this.LEDButton);
            this.Controls.Add(this.StatusCheck);
            this.Controls.Add(this.RobotStatus);
            this.Controls.Add(this.PingButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CommandButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CommandBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SignalLabel);
            this.Name = "WindowsPlatform";
            this.Text = "Robot Platform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignalLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CommandBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CommandButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button PingButton;
        private System.Windows.Forms.Button RobotStatus;
        private System.Windows.Forms.Label StatusCheck;
        private System.Windows.Forms.Button LEDButton;
        private System.Windows.Forms.Button buttonOff;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonMagenta;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonWhite;
        private System.Windows.Forms.Button buttonCyan;
    }
}

