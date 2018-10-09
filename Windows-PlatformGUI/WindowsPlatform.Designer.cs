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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsPlatform));
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UIDLabel = new System.Windows.Forms.Label();
            this.ControllerButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LeftTriggerButton = new System.Windows.Forms.Button();
            this.RightTriggerButton = new System.Windows.Forms.Button();
            this.VibrateButton = new System.Windows.Forms.Button();
            this.buttonRightJoystick = new System.Windows.Forms.Button();
            this.labelRightJoyStickX = new System.Windows.Forms.Label();
            this.labelRightJoyStickY = new System.Windows.Forms.Label();
            this.labelLeftJoyStickX = new System.Windows.Forms.Label();
            this.labelLeftJoyStickY = new System.Windows.Forms.Label();
            this.buttonLeftJoyStick = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonY = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonLB = new System.Windows.Forms.Button();
            this.buttonRB = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignalLabel
            // 
            this.SignalLabel.AutoSize = true;
            this.SignalLabel.Location = new System.Drawing.Point(9, 47);
            this.SignalLabel.Name = "SignalLabel";
            this.SignalLabel.Size = new System.Drawing.Size(16, 13);
            this.SignalLabel.TabIndex = 0;
            this.SignalLabel.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DATA SIGNAL";
            // 
            // CommandBox
            // 
            this.CommandBox.Location = new System.Drawing.Point(15, 191);
            this.CommandBox.Name = "CommandBox";
            this.CommandBox.Size = new System.Drawing.Size(239, 20);
            this.CommandBox.TabIndex = 2;
            this.CommandBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CommandBox_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Command";
            // 
            // CommandButton
            // 
            this.CommandButton.Location = new System.Drawing.Point(12, 217);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(458, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorsToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // authorsToolStripMenuItem
            // 
            this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            this.authorsToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.authorsToolStripMenuItem.Text = "About";
            this.authorsToolStripMenuItem.Click += new System.EventHandler(this.authorsToolStripMenuItem_Click);
            // 
            // UIDLabel
            // 
            this.UIDLabel.AutoSize = true;
            this.UIDLabel.Location = new System.Drawing.Point(12, 143);
            this.UIDLabel.Name = "UIDLabel";
            this.UIDLabel.Size = new System.Drawing.Size(38, 13);
            this.UIDLabel.TabIndex = 20;
            this.UIDLabel.Text = "UID: ?";
            this.UIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ControllerButton
            // 
            this.ControllerButton.BackColor = System.Drawing.Color.Red;
            this.ControllerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControllerButton.Location = new System.Drawing.Point(272, 251);
            this.ControllerButton.Name = "ControllerButton";
            this.ControllerButton.Size = new System.Drawing.Size(174, 23);
            this.ControllerButton.TabIndex = 21;
            this.ControllerButton.Text = "Controller Not Connected";
            this.ControllerButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "LeftTrigger";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "RightTrigger";
            // 
            // LeftTriggerButton
            // 
            this.LeftTriggerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftTriggerButton.Location = new System.Drawing.Point(272, 223);
            this.LeftTriggerButton.Name = "LeftTriggerButton";
            this.LeftTriggerButton.Size = new System.Drawing.Size(55, 23);
            this.LeftTriggerButton.TabIndex = 24;
            this.LeftTriggerButton.Text = "0";
            this.LeftTriggerButton.UseVisualStyleBackColor = true;
            // 
            // RightTriggerButton
            // 
            this.RightTriggerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightTriggerButton.Location = new System.Drawing.Point(390, 223);
            this.RightTriggerButton.Name = "RightTriggerButton";
            this.RightTriggerButton.Size = new System.Drawing.Size(56, 23);
            this.RightTriggerButton.TabIndex = 25;
            this.RightTriggerButton.Text = "0";
            this.RightTriggerButton.UseVisualStyleBackColor = true;
            // 
            // VibrateButton
            // 
            this.VibrateButton.Location = new System.Drawing.Point(333, 222);
            this.VibrateButton.Name = "VibrateButton";
            this.VibrateButton.Size = new System.Drawing.Size(51, 23);
            this.VibrateButton.TabIndex = 26;
            this.VibrateButton.Text = "Vibrate";
            this.VibrateButton.UseVisualStyleBackColor = true;
            this.VibrateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRightJoystick
            // 
            this.buttonRightJoystick.BackColor = System.Drawing.Color.White;
            this.buttonRightJoystick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRightJoystick.Location = new System.Drawing.Point(382, 104);
            this.buttonRightJoystick.Name = "buttonRightJoystick";
            this.buttonRightJoystick.Size = new System.Drawing.Size(25, 25);
            this.buttonRightJoystick.TabIndex = 27;
            this.buttonRightJoystick.UseVisualStyleBackColor = false;
            // 
            // labelRightJoyStickX
            // 
            this.labelRightJoyStickX.AutoSize = true;
            this.labelRightJoyStickX.Location = new System.Drawing.Point(381, 34);
            this.labelRightJoyStickX.Name = "labelRightJoyStickX";
            this.labelRightJoyStickX.Size = new System.Drawing.Size(26, 13);
            this.labelRightJoyStickX.TabIndex = 28;
            this.labelRightJoyStickX.Text = "X: 0";
            // 
            // labelRightJoyStickY
            // 
            this.labelRightJoyStickY.AutoSize = true;
            this.labelRightJoyStickY.Location = new System.Drawing.Point(381, 47);
            this.labelRightJoyStickY.Name = "labelRightJoyStickY";
            this.labelRightJoyStickY.Size = new System.Drawing.Size(26, 13);
            this.labelRightJoyStickY.TabIndex = 29;
            this.labelRightJoyStickY.Text = "Y: 0";
            // 
            // labelLeftJoyStickX
            // 
            this.labelLeftJoyStickX.AutoSize = true;
            this.labelLeftJoyStickX.Location = new System.Drawing.Point(290, 34);
            this.labelLeftJoyStickX.Name = "labelLeftJoyStickX";
            this.labelLeftJoyStickX.Size = new System.Drawing.Size(26, 13);
            this.labelLeftJoyStickX.TabIndex = 30;
            this.labelLeftJoyStickX.Text = "X: 0";
            // 
            // labelLeftJoyStickY
            // 
            this.labelLeftJoyStickY.AutoSize = true;
            this.labelLeftJoyStickY.Location = new System.Drawing.Point(290, 47);
            this.labelLeftJoyStickY.Name = "labelLeftJoyStickY";
            this.labelLeftJoyStickY.Size = new System.Drawing.Size(26, 13);
            this.labelLeftJoyStickY.TabIndex = 31;
            this.labelLeftJoyStickY.Text = "Y: 0";
            // 
            // buttonLeftJoyStick
            // 
            this.buttonLeftJoyStick.BackColor = System.Drawing.Color.White;
            this.buttonLeftJoyStick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeftJoyStick.Location = new System.Drawing.Point(293, 104);
            this.buttonLeftJoyStick.Name = "buttonLeftJoyStick";
            this.buttonLeftJoyStick.Size = new System.Drawing.Size(25, 25);
            this.buttonLeftJoyStick.TabIndex = 32;
            this.buttonLeftJoyStick.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(293, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(382, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 34;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // buttonA
            // 
            this.buttonA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA.Location = new System.Drawing.Point(272, 179);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(25, 25);
            this.buttonA.TabIndex = 35;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            // 
            // buttonB
            // 
            this.buttonB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonB.Location = new System.Drawing.Point(302, 179);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(25, 25);
            this.buttonB.TabIndex = 36;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            // 
            // buttonY
            // 
            this.buttonY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonY.Location = new System.Drawing.Point(421, 179);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(25, 25);
            this.buttonY.TabIndex = 37;
            this.buttonY.Text = "Y";
            this.buttonY.UseVisualStyleBackColor = true;
            // 
            // buttonX
            // 
            this.buttonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX.Location = new System.Drawing.Point(390, 179);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(25, 25);
            this.buttonX.TabIndex = 37;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonLB
            // 
            this.buttonLB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLB.Location = new System.Drawing.Point(272, 163);
            this.buttonLB.Name = "buttonLB";
            this.buttonLB.Size = new System.Drawing.Size(55, 10);
            this.buttonLB.TabIndex = 38;
            this.buttonLB.UseVisualStyleBackColor = true;
            // 
            // buttonRB
            // 
            this.buttonRB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRB.Location = new System.Drawing.Point(390, 163);
            this.buttonRB.Name = "buttonRB";
            this.buttonRB.Size = new System.Drawing.Size(56, 10);
            this.buttonRB.TabIndex = 39;
            this.buttonRB.UseVisualStyleBackColor = true;
            // 
            // buttonUp
            // 
            this.buttonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUp.Location = new System.Drawing.Point(350, 165);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(15, 15);
            this.buttonUp.TabIndex = 40;
            this.buttonUp.UseVisualStyleBackColor = true;
            // 
            // buttonLeft
            // 
            this.buttonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeft.Location = new System.Drawing.Point(336, 179);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(15, 15);
            this.buttonLeft.TabIndex = 41;
            this.buttonLeft.UseVisualStyleBackColor = true;
            // 
            // buttonRight
            // 
            this.buttonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRight.Location = new System.Drawing.Point(364, 179);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(15, 15);
            this.buttonRight.TabIndex = 42;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDown.Location = new System.Drawing.Point(350, 193);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(15, 15);
            this.buttonDown.TabIndex = 43;
            this.buttonDown.UseVisualStyleBackColor = true;
            // 
            // WindowsPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 286);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonRB);
            this.Controls.Add(this.buttonLB);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.buttonY);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.buttonLeftJoyStick);
            this.Controls.Add(this.labelLeftJoyStickY);
            this.Controls.Add(this.labelLeftJoyStickX);
            this.Controls.Add(this.labelRightJoyStickY);
            this.Controls.Add(this.labelRightJoyStickX);
            this.Controls.Add(this.buttonRightJoystick);
            this.Controls.Add(this.VibrateButton);
            this.Controls.Add(this.RightTriggerButton);
            this.Controls.Add(this.LeftTriggerButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ControllerButton);
            this.Controls.Add(this.UIDLabel);
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
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "WindowsPlatform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robot Platform";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WindowsPlatform_FormClosing);
            this.Load += new System.EventHandler(this.WindowsPlatform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.Label UIDLabel;
        private System.Windows.Forms.Button ControllerButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button LeftTriggerButton;
        private System.Windows.Forms.Button RightTriggerButton;
        private System.Windows.Forms.Button VibrateButton;
        private System.Windows.Forms.Button buttonRightJoystick;
        private System.Windows.Forms.Label labelRightJoyStickX;
        private System.Windows.Forms.Label labelRightJoyStickY;
        private System.Windows.Forms.Label labelLeftJoyStickX;
        private System.Windows.Forms.Label labelLeftJoyStickY;
        private System.Windows.Forms.Button buttonLeftJoyStick;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonLB;
        private System.Windows.Forms.Button buttonRB;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
    }
}

