using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Windows_PlatformGUI
{
    public class SerialPortProgram
    {
        WindowsPlatform platform;
        string Buffer = "";
        private SerialPort port = new SerialPort("COM5", 115200, Parity.None, 8, StopBits.One);
        private int Try = 0;
        Timer timer = new Timer();
        public SerialPortProgram(WindowsPlatform plat)
        {
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = 250;
            timer.Enabled = true;
            timer.Start();
            platform = plat;
            port.DataReceived += new SerialDataReceivedEventHandler(port_data);
            port.Handshake = Handshake.None;
            port.ReadBufferSize = 8192;
            port.WriteBufferSize = 128;
            port.ReadTimeout = 2;
            port.WriteTimeout = 2;
            port.Open();
            port.DiscardInBuffer();
            port.DiscardOutBuffer();
            port.DtrEnable = true;
            port.RtsEnable = true;
        }

        bool OnlineCheck = false;
        bool OnlineCheckReceived = false;
        bool IsOnline = false;
        void timerTick(object sender, EventArgs e)
        {
            if(OnlineCheckReceived == false)
            {
                IsOnline = false;
                Control d = platform.Controls.Find("RobotStatus", true).First();
                d.Invoke((Action)delegate
                {
                    d.Text = "Offline";
                    d.BackColor = System.Drawing.Color.Red;
                });
            }
            else
            {
                IsOnline = true;
                Control d = platform.Controls.Find("RobotStatus", true).First();
                d.Invoke((Action)delegate
                {
                    d.Text = "Online";
                    d.BackColor = System.Drawing.Color.LightGreen;
                });
            }

            SendString("online");
            OnlineCheck = true;
            OnlineCheckReceived = false;
        }

        private void port_data(object sender, SerialDataReceivedEventArgs e)
        {
            char x = (char)port.ReadChar();
            if (x == '\r')
            {
                if (OnlineCheck && Buffer.Contains("Online"))
                {
                    OnlineCheck = false;
                    OnlineCheckReceived = true;
                }
                else if(Buffer.Contains("led"))
                {
                    if(Buffer.Contains("green"))
                    {
                        Control c = platform.Controls.Find("LEDButton", true).First();
                        c.Invoke((Action)delegate
                        {
                            c.BackColor = System.Drawing.Color.Green;
                        });
                    }
                    else if (Buffer.Contains("red"))
                    {
                        Control c = platform.Controls.Find("LEDButton", true).First();
                        c.Invoke((Action)delegate
                        {
                            c.BackColor = System.Drawing.Color.Red;
                        });
                    }
                    else if (Buffer.Contains("blue"))
                    {
                        Control c = platform.Controls.Find("LEDButton", true).First();
                        c.Invoke((Action)delegate
                        {
                            c.BackColor = System.Drawing.Color.Blue;
                        });
                    }
                    else if (Buffer.Contains("yellow"))
                    {
                        Control c = platform.Controls.Find("LEDButton", true).First();
                        c.Invoke((Action)delegate
                        {
                            c.BackColor = System.Drawing.Color.Yellow;
                        });
                    }
                    else if (Buffer.Contains("off"))
                    {
                        Control c = platform.Controls.Find("LEDButton", true).First();
                        c.Invoke((Action)delegate
                        {
                            c.BackColor = System.Drawing.Color.LightGray;
                        });
                    }
                    else if (Buffer.Contains("magenta"))
                    {
                        Control c = platform.Controls.Find("LEDButton", true).First();
                        c.Invoke((Action)delegate
                        {
                            c.BackColor = System.Drawing.Color.Magenta;
                        });
                    }
                    else if (Buffer.Contains("cyan"))
                    {
                        Control c = platform.Controls.Find("LEDButton", true).First();
                        c.Invoke((Action)delegate
                        {
                            c.BackColor = System.Drawing.Color.Cyan;
                        });
                    }
                    else if (Buffer.Contains("white"))
                    {
                        Control c = platform.Controls.Find("LEDButton", true).First();
                        c.Invoke((Action)delegate
                        {
                            c.BackColor = System.Drawing.Color.White;
                        });
                    }
                }
                else if(!Buffer.Contains("Is Online"))
                {
                    Try++;
                    Control c = platform.Controls.Find("SignalLabel", true).First();
                    c.Invoke((Action)delegate
                    {
                        c.Text = "DATA: (" + Try + ") -> " + Buffer;
                    });
                }
                Buffer = "";
            }
            else
            {
                Buffer += x;
            }
            port.DiscardInBuffer();
        }

        public void SendString(string str)
        {
            str = str.ToLower();
            port.Write(str + '\r');
            port.DiscardOutBuffer();
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WindowsPlatform plat = new WindowsPlatform();
            plat.portProgram = new SerialPortProgram(plat);
            Application.Run(plat);
        }
    }
}
