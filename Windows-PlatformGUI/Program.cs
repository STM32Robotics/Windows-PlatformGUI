using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using SharpDX.XInput;
using System.Drawing;

namespace Windows_PlatformGUI
{
    public class XController
    {
        public Controller controller;
        public Gamepad gamepad;
        public bool connected = false;
        public int deadband = 2500;
        public Point leftThumb, rightThumb = new Point(0, 0);
        public float leftTrigger, rightTrigger;
        public bool rightThumbDown = false;
        public bool leftThumbDown = false;
        public bool AButton = false;
        public bool BButton = false;
        public bool XButton = false;
        public bool YButton = false;
        public bool LBButton = false;
        public bool RBButton = false;
        public bool UpButton = false;
        public bool DownButton = false;
        public bool LeftButton = false;
        public bool RightButton = false;

        public XController()
        {
            controller = new Controller(UserIndex.One);
            connected = controller.IsConnected;
        }

        public void Update()
        {
            connected = controller.IsConnected;
            if (!connected)
                return;
            gamepad = controller.GetState().Gamepad;

            leftTrigger = gamepad.LeftTrigger;
            rightTrigger = gamepad.RightTrigger;
            
            if(gamepad.LeftThumbX < deadband && gamepad.LeftThumbX > -deadband)
            {
                gamepad.LeftThumbX = 0;
            }
            if (gamepad.LeftThumbY < deadband && gamepad.LeftThumbY > -deadband)
            {
                gamepad.LeftThumbY = 0;
            }
            if (gamepad.RightThumbX < deadband && gamepad.RightThumbX > -deadband)
            {
                gamepad.RightThumbX = 0;
            }
            if (gamepad.RightThumbY < deadband && gamepad.RightThumbY > -deadband)
            {
                gamepad.RightThumbY = 0;
            }

            int leftThumbX = (int)((float)gamepad.LeftThumbX / short.MaxValue * 100.0f);

            int leftThumbY = (int)((float)gamepad.LeftThumbY / short.MaxValue * 100.0f);

            int rightThumbX = (int)((float)gamepad.RightThumbX / short.MaxValue * 100.0f);

            int rightThumbY = (int)((float)gamepad.RightThumbY / short.MaxValue * 100.0f);

            leftThumb = new Point(leftThumbX, leftThumbY);
            rightThumb = new Point(rightThumbX, rightThumbY);

            rightThumbDown = gamepad.Buttons.HasFlag(GamepadButtonFlags.RightThumb);
            leftThumbDown = gamepad.Buttons.HasFlag(GamepadButtonFlags.LeftThumb);
            AButton = gamepad.Buttons.HasFlag(GamepadButtonFlags.A);
            BButton = gamepad.Buttons.HasFlag(GamepadButtonFlags.B);
            XButton = gamepad.Buttons.HasFlag(GamepadButtonFlags.X);
            YButton = gamepad.Buttons.HasFlag(GamepadButtonFlags.Y);
            LBButton = gamepad.Buttons.HasFlag(GamepadButtonFlags.LeftShoulder);
            RBButton = gamepad.Buttons.HasFlag(GamepadButtonFlags.RightShoulder);
            UpButton = gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadUp);
            DownButton = gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadDown);
            LeftButton = gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadLeft);
            RightButton = gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadRight);
        }
    }

    public class SerialPortProgram
    {
        public XController controller;
        WindowsPlatform platform;
        string Buffer = "";
        private SerialPort port = new SerialPort("COM5", 115200, Parity.None, 8, StopBits.One);
        private int Try = 0;
        Timer timer = new Timer();
        public SerialPortProgram(WindowsPlatform plat)
        {
            controller = new XController();
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = 250;
            timer.Enabled = true;
            timer.Start();
            platform = plat;
            port.DataReceived += new SerialDataReceivedEventHandler(port_data);
            port.Handshake = Handshake.None;
            port.ReadBufferSize = 8192;
            port.WriteBufferSize = 128;
            port.ReadTimeout = 5;
            port.WriteTimeout = 5;
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
                else if(Buffer.Contains("UID:"))
                {
                    Control c = platform.Controls.Find("UIDLabel", true).First();
                    c.Invoke((Action)delegate
                    {
                        c.Text = Buffer;
                    });
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
            string[] arr = str.Split(' ');
            arr[0] = arr[0].ToLower();
            string newstr = string.Join(" ", arr);
            //str = str.ToLower();
            port.Write(newstr + '\r');
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
