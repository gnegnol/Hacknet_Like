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
        MainBar mainBar;
        private string prompt = "C:\\Users\\" + username + ">";

        public Terminal() {
            InitializeComponent();
        }
        public Terminal(MainBar mb) {
            InitializeComponent();
            mainBar = mb;
        }

        private void Terminal_Load( object sender, EventArgs e ) {
            terminalTextBox.Text = firstOpenText + "C:\\Users\\" + username + ">";
            terminalTextBox.SelectionStart = terminalTextBox.SelectionLength = 0;
            terminalTextBox.KeyPress += terminalTextBox_KeyPressed;
            terminalTextBox.KeyDown += terminalTextBox_KeyDown;
        }
        protected override void OnClosed(EventArgs e ) {
            base.OnClosed(e);
            mainBar.terminalsOpened.Remove( this );
        }

        private void terminalTextBox_KeyDown( object sender, KeyEventArgs e ) {
            // If the caret is anywhere else, set it back when a key is pressed.
            if(!IsCaretAtWritablePosition() && !(e.Control || IsTerminatorKey( e.KeyCode ))) {
                MoveCaretToEndOfText();
            }

            // Prevent caret from moving before the prompt
            if(e.KeyCode == Keys.Left && IsCaretJustBeforePrompt()) {
                e.Handled = true;
            } else if(e.KeyCode == Keys.Down) {
                //if(commandHistory.DoesNextCommandExist()) {
                //    ReplaceTextAtPrompt( commandHistory.GetNextCommand() );
                //}
                e.Handled = true;
            } else if(e.KeyCode == Keys.Up) {
                //if(commandHistory.DoesPreviousCommandExist()) {
                //    ReplaceTextAtPrompt( commandHistory.GetPreviousCommand() );
                //}
                e.Handled = true;
            } else if(e.KeyCode == Keys.Right) {
                // Performs command completion
                //string currentTextAtPrompt = GetTextAtPrompt();
                //string lastCommand = commandHistory.LastCommand;

                //if(lastCommand != null && (currentTextAtPrompt.Length == 0 || lastCommand.StartsWith( currentTextAtPrompt ))) {
                //    if(lastCommand.Length > currentTextAtPrompt.Length) {
                //        this.AddText( lastCommand[currentTextAtPrompt.Length].ToString() );
                //    }
                //}
            }
        }
        private void terminalTextBox_KeyPressed( object sender, KeyPressEventArgs e ) {
            // Handle backspace
            if(e.KeyChar == (char)8 && IsCaretJustBeforePrompt()) {
                e.Handled = true;
                return;
            }

            if(IsTerminatorKey( e.KeyChar )) {
                e.Handled = true;
                string currentCommand = GetTextAtPrompt();
                if(currentCommand.Length != 0) {
                    printLine();
                    //((ShellControl)this.Parent).FireCommandEntered( currentCommand );
                    //commandHistory.Add( currentCommand );
                }
                printPrompt();
            }
        }


        private void printPrompt() {
            string currentText = terminalTextBox.Text;
            if(currentText.Length != 0 && currentText[currentText.Length - 1] != '\n')
                printLine();
            AddText( prompt );
        }

        private void printLine() {
            AddText( System.Environment.NewLine );
        }

        private string GetCurrentLine() {
            if(terminalTextBox.Lines.Length > 0)
                return (string)terminalTextBox.Lines.GetValue( terminalTextBox.Lines.GetLength( 0 ) - 1 );
            else
                return "";
        }

        private string GetTextAtPrompt() {
            return GetCurrentLine().Substring( prompt.Length );
        }

        private void ReplaceTextAtPrompt( string text ) {
            string currentLine = GetCurrentLine();
            int charactersAfterPrompt = currentLine.Length - prompt.Length;

            if(charactersAfterPrompt == 0)
                AddText( text );
            else {
                terminalTextBox.Select( terminalTextBox.TextLength - charactersAfterPrompt, charactersAfterPrompt );
                terminalTextBox.SelectedText = text;
            }
        }

        private bool IsCaretAtCurrentLine() {
            return terminalTextBox.TextLength - terminalTextBox.SelectionStart <= GetCurrentLine().Length;
        }

        private void MoveCaretToEndOfText() {
            terminalTextBox.SelectionStart = terminalTextBox.TextLength;
            terminalTextBox.ScrollToCaret();
        }

        private bool IsCaretJustBeforePrompt() {
            return IsCaretAtCurrentLine() && GetCurrentCaretColumnPosition() == prompt.Length;
        }

        private int GetCurrentCaretColumnPosition() {
            string currentLine = GetCurrentLine();
            int currentCaretPosition = terminalTextBox.SelectionStart;
            return (currentCaretPosition - terminalTextBox.TextLength + currentLine.Length);
        }

        private bool IsCaretAtWritablePosition() {
            return IsCaretAtCurrentLine() && GetCurrentCaretColumnPosition() >= prompt.Length;
        }

        private void SetPromptText( string val ) {
            string currentLine = GetCurrentLine();
            terminalTextBox.Select( 0, prompt.Length );
            terminalTextBox.SelectedText = val;

            prompt = val;
        }

        public string Prompt
        {
            get { return prompt; }
            set { SetPromptText( value ); }
        }

        //public string[] GetCommandHistory() {
        //    return commandHistory.GetCommandHistory();
        //}

        public void WriteText( string text ) {
            AddText( text );
        }


        private bool IsTerminatorKey( Keys key ) {
            return key == Keys.Enter;
        }

        private bool IsTerminatorKey( char keyChar ) {
            return ((int)keyChar) == 13;
        }

        // Substitute for buggy AppendText()
        private void AddText( string text ) {
            terminalTextBox.Text += text;
            MoveCaretToEndOfText();
        }
    }
}
