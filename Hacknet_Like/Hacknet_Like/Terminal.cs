using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hacknet_Like {
    public partial class Terminal : Form {
        string firstOpenText = "Microsoft Windows [Version 10.0.17134.112]" + Environment.NewLine +
                                     "(c) 2018 Microsoft Corporation. All rights reserved." + Environment.NewLine + Environment.NewLine;
        const string username = "LadyGay69";

        private void UpdateCmdTextboxLocation() {
            Point cmdLocation = new Point();

            Image fakeImage = new Bitmap( 1, 1 );
            Graphics graphics = Graphics.FromImage( fakeImage );
            SizeF size = graphics.MeasureString( terminalTextBox.Lines[terminalTextBox.Lines.Length - 1], terminalTextBox.Font );

            cmdLocation.Y = (int)(terminalTextBox.Lines.Length * size.Height) - 14;
            cmdLocation.X = (int)(terminalTextBox.Lines[terminalTextBox.Lines.Length - 1].Length * 8.3); //8.5

            cmdTextbox.Location = cmdLocation;
        }

        public Terminal() {
            InitializeComponent();
        }

        private void Terminal_Load( object sender, EventArgs e ) {
            terminalTextBox.Text = firstOpenText + "C:\\Users\\" + username + ">";
            terminalTextBox.SelectionStart = terminalTextBox.SelectionLength = 0;
            cmdTextbox.KeyPress += cmdTextbox_KeyPressed;
            UpdateCmdTextboxLocation();
        }

        private void cmdTextbox_KeyPressed( object sender, KeyPressEventArgs e ) {
            if(e.KeyChar == (char)13) {
                string cmdText = cmdTextbox.Text;
                if(cmdTextbox.Text.Contains( "\r" )) {
                    cmdText = cmdText.Substring( 2, cmdText.Length - 2 );
                }
                
                terminalTextBox.Text += cmdText + Environment.NewLine + "C:\\Users\\" + username + ">";
                
                cmdTextbox.Text = "";
                
                UpdateCmdTextboxLocation();
            }
        }

        private void cmdTextbox_TextChanged( object sender, EventArgs e ) {
            UpdateCmdTextboxLocation();
        }
    }
}
