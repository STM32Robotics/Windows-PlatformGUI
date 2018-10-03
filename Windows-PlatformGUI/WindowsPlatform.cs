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
    }
}
