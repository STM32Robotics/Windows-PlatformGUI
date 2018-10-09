using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_PlatformGUI
{
    public partial class WindowsPlatform : Form
    {
        public SerialPortProgram portProgram;
        public WindowsPlatform()
        {
            InitializeComponent();
        }

        private void CommandButton_Click(object sender, EventArgs e)
        {
            CommandButton.Text = "Sent! -> " + CommandBox.Text;
            portProgram.SendString(CommandBox.Text);
        }

        private void CommandBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                CommandButton.Text = "Sent! -> " + CommandBox.Text;
                portProgram.SendString(CommandBox.Text);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            CommandButton.Text = "Sent! -> reset";
            UIDLabel.Text = "UID: ?";
            portProgram.SendString("reset");
        }

        private void PingButton_Click(object sender, EventArgs e)
        {
            CommandButton.Text = "Sent! -> ping";
            portProgram.SendString("ping");
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            portProgram.SendString("led off");
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            portProgram.SendString("led green");
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            portProgram.SendString("led blue");
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            portProgram.SendString("led red");
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            portProgram.SendString("led yellow");
        }

        private void buttonCyan_Click(object sender, EventArgs e)
        {
            portProgram.SendString("led cyan");
        }

        private void buttonMagenta_Click(object sender, EventArgs e)
        {
            portProgram.SendString("led magenta");
        }

        private void buttonWhite_Click(object sender, EventArgs e)
        {
            portProgram.SendString("led white");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void authorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.Size = new Size(this.Width / 2, this.Height / 2);
            f.StartPosition = FormStartPosition.Manual;
            f.Left = this.Left + this.Size.Width;
            f.Top = this.Top;
            f.ShowIcon = false;
            //f.MinimizeBox = false;
            f.MaximizeBox = false;
            f.FormBorderStyle = FormBorderStyle.FixedSingle;
            f.Text = "About";

            Label lab = new Label();
            lab.AutoSize = false;
            lab.Text = "Programmed by\n\nTudor Marinescu\nJohn Chan\nHaron Yusuf\n\n\nSTM32F303RE";
            lab.TextAlign = ContentAlignment.MiddleCenter;
            lab.Dock = DockStyle.Fill;

            f.Controls.Add(lab);

            f.Show();
        }

        System.Threading.Thread T;

        private void WindowsPlatform_Load(object sender, EventArgs e)
        {
            T = new System.Threading.Thread(ControllerThread);
            T.Start();
        }

        public void ControllerThread()
        {
            int radius = 5;
            Point RButtonPos = new Point();
            this.Invoke((Action)delegate
            {
                Control c = this.Controls.Find("buttonRightJoystick", true).First();
                c.Invoke((Action)delegate
                {
                    RButtonPos = c.Location;
                });
            });

            Point LButtonPos = new Point();
            this.Invoke((Action)delegate
            {
                Control c = this.Controls.Find("buttonLeftJoystick", true).First();
                c.Invoke((Action)delegate
                {
                    LButtonPos = c.Location;
                });
            });

            while (true)
            {
                portProgram.controller.Update();
                if (portProgram.controller.connected)
                {
                    this.Invoke((Action)delegate
                    {
                        Control c = this.Controls.Find("ControllerButton", true).First();
                        c.Invoke((Action)delegate
                        {
                            c.BackColor = System.Drawing.Color.LimeGreen;
                            c.Text = "Controller Connected";
                        });
                    });

                    this.Invoke((Action)delegate
                    {
                        Control c = this.Controls.Find("labelRightJoyStickX", true).First();
                        c.Invoke((Action)delegate
                        {
                            c.Text = "X: " + portProgram.controller.rightThumb.X;
                        });
                    });

                    this.Invoke((Action)delegate
                    {
                        Control c = this.Controls.Find("buttonA", true).First();
                        c.Invoke((Action)delegate
                        {
                            if(portProgram.controller.AButton)
                            {
                                c.BackColor = Color.Red;
                            }
                            else
                            {
                                c.BackColor = Color.LightGray;
                            }
                        });
                    });

                    this.Invoke((Action)delegate
                    {
                        Control c = this.Controls.Find("buttonB", true).First();
                        c.Invoke((Action)delegate
                        {
                            if (portProgram.controller.BButton)
                            {
                                c.BackColor = Color.Red;
                            }
                            else
                            {
                                c.BackColor = Color.LightGray;
                            }
                        });
                    });

                    this.Invoke((Action)delegate
                    {
                        Control c = this.Controls.Find("buttonX", true).First();
                        c.Invoke((Action)delegate
                        {
                            if (portProgram.controller.XButton)
                            {
                                c.BackColor = Color.Red;
                            }
                            else
                            {
                                c.BackColor = Color.LightGray;
                            }
                        });
                    });

                    this.Invoke((Action)delegate
                    {
                        Control c = this.Controls.Find("buttonY", true).First();
                        c.Invoke((Action)delegate
                        {
                            if (portProgram.controller.YButton)
                            {
                                c.BackColor = Color.Red;
                            }
                            else
                            {
                                c.BackColor = Color.LightGray;
                            }
                        });
                    });

                    this.Invoke((Action)delegate
                    {
                        Control c = this.Controls.Find("buttonLB", true).First();
                        c.Invoke((Action)delegate
                        {
                            if (portProgram.controller.LBButton)
                            {
                                c.BackColor = Color.Red;
                            }
                            else
                            {
                                c.BackColor = Color.LightGray;
                            }
                        });
                    });

                    this.Invoke((Action)delegate
                    {
                        Control c = this.Controls.Find("buttonRB", true).First();
                        c.Invoke((Action)delegate
                        {
                            if (portProgram.controller.RBButton)
                            {
                                c.BackColor = Color.Red;
                            }
                            else
                            {
                                c.BackColor = Color.LightGray;
                            }
                        });
                    });

                    this.Invoke((Action)delegate
                    {
                        Control c = this.Controls.Find("buttonUp", true).First();
                        c.Invoke((Action)delegate
                        {
                            if (portProgram.controller.UpButton)
                            {
                                c.BackColor = Color.Red;
                            }
                            else
                            {
                                c.BackColor = Color.LightGray;
                            }
                        });
                    });

                    this.Invoke((Action)delegate
                    {
                        Control c = this.Controls.Find("buttonDown", true).First();
                        c.Invoke((Action)delegate
                        {
                            if (portProgram.controller.DownButton)
                            {
                                c.BackColor = Color.Red;
                            }
                            else
                            {
                                c.BackColor = Color.LightGray;
                            }
                        });
                    });

                    this.Invoke((Action)delegate
                    {
                        Control c = this.Controls.Find("buttonLeft", true).First();
                        c.Invoke((Action)delegate
                        {
                            if (portProgram.controller.LeftButton)
                            {
                                c.BackColor = Color.Red;
                            }
                            else
                            {
                                c.BackColor = Color.LightGray;
                            }
                        });
                    });

                    this.Invoke((Action)delegate
                    {
                        Control c = this.Controls.Find("buttonRight", true).First();
                        c.Invoke((Action)delegate
                        {
                            if (portProgram.controller.RightButton)
                            {
                                c.BackColor = Color.Red;
                            }
                            else
                            {
                                c.BackColor = Color.LightGray;
                            }
                        });
                    });

                    this.Invoke((Action)delegate
                    {
                        Control c = this.Controls.Find("labelRightJoyStickY", true).First();
                        c.Invoke((Action)delegate
                        {
                            c.Text = "Y: " + portProgram.controller.rightThumb.Y;
                        });
                    });

                    this.Invoke((Action)delegate
                    {
                        Control c = this.Controls.Find("buttonRightJoystick", true).First();
                        c.Invoke((Action)delegate
                        {
                            c.Location = new Point((RButtonPos.X) + (radius * portProgram.controller.rightThumb.X / 20), (RButtonPos.Y) + (radius * -portProgram.controller.rightThumb.Y / 20));
                            if (portProgram.controller.rightThumbDown)
                            {
                                c.BackColor = Color.Red;
                            }
                            else
                            {
                                c.BackColor = Color.White;
                            }
                        });
                    });

                    this.Invoke((Action)delegate
                    {
                        Control c = this.Controls.Find("labelLeftJoyStickX", true).First();
                        c.Invoke((Action)delegate
                        {
                            c.Text = "X: " + portProgram.controller.leftThumb.X;
                        });
                    });

                    this.Invoke((Action)delegate
                    {
                        Control c = this.Controls.Find("labelLeftJoyStickY", true).First();
                        c.Invoke((Action)delegate
                        {
                            c.Text = "Y: " + portProgram.controller.leftThumb.Y;
                        });
                    });

                    this.Invoke((Action)delegate
                    {
                        Control c = this.Controls.Find("buttonLeftJoystick", true).First();
                        c.Invoke((Action)delegate
                        {
                            c.Location = new Point((LButtonPos.X) + (radius * portProgram.controller.leftThumb.X / 20), (LButtonPos.Y) + (radius * -portProgram.controller.leftThumb.Y / 20));
                            if(portProgram.controller.leftThumbDown)
                            {
                                c.BackColor = Color.Red;
                            }
                            else
                            {
                                c.BackColor = Color.White;
                            }
                        });
                    });

                    this.Invoke((Action)delegate
                    {
                        Control c = this.Controls.Find("LeftTriggerButton", true).First();
                        c.Invoke((Action)delegate
                        {
                            c.Text = "" + portProgram.controller.leftTrigger;
                        });
                    });

                    this.Invoke((Action)delegate
                    {
                        Control c = this.Controls.Find("RightTriggerButton", true).First();
                        c.Invoke((Action)delegate
                        {
                            c.Text = "" + portProgram.controller.rightTrigger;
                        });
                    });
                }
                else
                {
                    this.Invoke((Action)delegate
                    {
                        Control c = this.Controls.Find("ControllerButton", true).First();
                        c.Invoke((Action)delegate
                        {
                            c.BackColor = System.Drawing.Color.Red;
                            c.Text = "Controller Not Connected";
                        });
                    });
                }
            }
        }

        private void WindowsPlatform_FormClosing(object sender, FormClosingEventArgs e)
        {
            T.Abort();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SharpDX.XInput.Vibration v = new SharpDX.XInput.Vibration();
            v.LeftMotorSpeed = 32000;
            v.RightMotorSpeed = 32000;
            portProgram.controller.controller.SetVibration(v);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
