using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Hacknet_Like {
    public partial class MainBar : Form {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        //------------------Salvataggio posizione main barra------------------------
        const string userRoot = "HKEY_CURRENT_USER";
        const string subkey = "MainBarScreenPosition";
        const string keyName = userRoot + "\\" + subkey;
        const string XvalueName = "XPosition";
        const string YvalueName = "YPosition";
        //--------------------------------------------------------------------------


        protected override void WndProc( ref Message m ) {
            base.WndProc( ref m );
            if(m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }


        public MainBar() {
            InitializeComponent();
            quitButton.MouseEnter += quitButton_MouseEnter;
            quitButton.MouseLeave += quitButton_MouseLeave;
            openTerminalButton.MouseEnter += openTerminalButton_MouseEnter;
            openTerminalButton.MouseLeave += openTerminalButton_MouseLeave;
        }

        private void Form1_Load( object sender, EventArgs e ) {
            this.Location = new System.Drawing.Point( (int)Registry.GetValue( keyName, XvalueName, Screen.PrimaryScreen.Bounds.Width / 2),
                                                      (int)Registry.GetValue( keyName, YvalueName, Screen.PrimaryScreen.Bounds.Height / 2 ) );
        }

        private void quitButton_Click( object sender, EventArgs e ) {
            Registry.SetValue( keyName, XvalueName, this.Location.X );
            Registry.SetValue( keyName, YvalueName, this.Location.Y );
            Application.Exit();
        }

        private void quitButton_MouseEnter( object sender, EventArgs e ) {
            quitButton.BackColor = Utilities.Colors.QuitButtonRed;          
        }
        private void quitButton_MouseLeave( object sender, EventArgs e ) {
            quitButton.BackColor = Utilities.Colors.DefaultGrey;
        }

        private void openTerminalButton_MouseEnter( object sender, EventArgs e ) {
            openTerminalButton.BackColor = Utilities.Colors.TerminalButtonGrey;
        }
        private void openTerminalButton_MouseLeave( object sender, EventArgs e ) {
            openTerminalButton.BackColor = Utilities.Colors.DefaultGrey;
        }

        private void openTerminalButton_Click( object sender, EventArgs e ) {
            Terminal terminalForm = new Terminal();
            terminalForm.Show();
        }
    }
}
