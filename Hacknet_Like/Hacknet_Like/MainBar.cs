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
using System.Collections;

namespace Hacknet_Like {
    public partial class MainBar : Form {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        
        Utilities.LayoutContainer layoutContainer;
        public List<Terminal> terminalsOpened = new List<Terminal>();
        
        public void SaveLayoutFile(string fileName = Utilities.xmlLayoutFileName ) {
            layoutContainer.mainBarLocation = this.Location;
            layoutContainer.terminalLocations.Clear();

            foreach(Terminal terminal in terminalsOpened) {
                layoutContainer.terminalLocations.Add( new Utilities.WindowProperties( terminal.Location, (Point)terminal.Size ));
            }
            layoutContainer.Save( Application.StartupPath + "\\" + Utilities.LayoutFilesFolder + "\\" + fileName );
        }

        public void LoadLayoutFile(string fileName = Utilities.xmlLayoutFileName ) {
            if(System.IO.File.Exists( Application.StartupPath + "\\" + Utilities.LayoutFilesFolder + "\\" + fileName )) {
                layoutContainer = Utilities.LayoutContainer.Load( Application.StartupPath + "\\" + Utilities.LayoutFilesFolder + "\\" + fileName );
            }
        }

        public void ApplyLayout() {
            this.Location = layoutContainer.mainBarLocation;

            while(terminalsOpened.Count != 0) {
                terminalsOpened[0].Close();
            }
            terminalsOpened.Clear();

            foreach(Utilities.WindowProperties windowProperty in layoutContainer.terminalLocations) {
                Terminal terminalForm = new Terminal( this );
                terminalsOpened.Add( terminalForm );
                terminalForm.Show();
                terminalForm.Location = windowProperty.location;
                terminalForm.Size = new Size( windowProperty.size );
            }
        }

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
            if(System.IO.File.Exists( Application.StartupPath + "\\" + Utilities.LayoutFilesFolder + "\\" + Utilities.xmlLayoutFileName )) {
                LoadLayoutFile();
                ApplyLayout();
            } else {
                layoutContainer = new Utilities.LayoutContainer();
            }
        }

        private void quitButton_Click( object sender, EventArgs e ) {
            //SaveLayoutFile();
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
            Terminal terminalForm = new Terminal(this);
            terminalsOpened.Add( terminalForm );
            terminalForm.Show();
        }

        private void layoutSaverButton_Click( object sender, EventArgs e ) {
            new LayoutSaverLoader(this).Show();
        }
    }
}
