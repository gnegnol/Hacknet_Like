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
    public partial class LayoutSaverLoader : Form {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        string[] layoutFiles;

        MainBar mainbar;

        protected override void WndProc( ref Message m ) {
            base.WndProc( ref m );
            if(m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        public LayoutSaverLoader() {
            InitializeComponent();
        }
        public LayoutSaverLoader(MainBar instance) {
            InitializeComponent();
            mainbar = instance;
        }

        private void LayoutSaverLoader_Load( object sender, EventArgs e ) {
            closePrompt.MouseEnter += quitButton_MouseEnter;
            closePrompt.MouseLeave += quitButton_MouseLeave;

            layoutFiles = System.IO.Directory.GetFiles( Application.StartupPath, "*.xml" );
            foreach(string filePath in layoutFiles) {
                comboBox1.Items.Add( System.IO.Path.GetFileName( filePath ) );
            }
            comboBox1.SelectedItem = comboBox1.Items[0];
        }

        private void closePrompt_Click( object sender, EventArgs e ) {
            this.Close();
        }

        private void quitButton_MouseEnter( object sender, EventArgs e ) {
            closePrompt.BackColor = Utilities.Colors.QuitButtonRed;
        }
        private void quitButton_MouseLeave( object sender, EventArgs e ) {
            closePrompt.BackColor = Utilities.Colors.DefaultGrey;
        }

        private void saveLayoutButton_Click( object sender, EventArgs e ) {
            if(!saveFileName.Text.Contains( ".xml") ){
                saveFileName.Text += ".xml";
            }
            mainbar.SaveLayoutFile( saveFileName.Text);
            MessageBox.Show( "Layout saved correctly!", "Saving" );
        }

        private void loadLayoutButton_Click( object sender, EventArgs e ) {
            mainbar.LoadLayoutFile( (string)comboBox1.SelectedItem );
            mainbar.ApplyLayout();
        }
    }
}
