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
    public partial class Note : Form {
        //riferimento al form padre
        MainBar mainBar;
        //distanza degli elementi in px dal bordo sinistro del form
        private const int hBorder = 15;
        //distanza del primo elemento dal bordo superiore del form
        private const int vBorder = 15;
        //spacing tra le note
        private const int SPACING = 5;

        List<NoteRow> noteRows = new List<NoteRow>();
        public class NoteRow {
            public TextBox nota;
            public Button copyButton;
            public Button pasteButton;
            public Button deleteButton;
            public TextBox nome;

            public NoteRow( TextBox textBox, Button copy, Button paste, Button delete, TextBox nome ) {
                nota = textBox;
                copyButton = copy;
                pasteButton = paste;
                deleteButton = delete;
                this.nome = nome;
            }
            public void ApplyToForm( Form form ) {
                form.Controls.Add( nota );
                form.Controls.Add( copyButton );
                form.Controls.Add( pasteButton );
            }
            public void ApplyToControl( Control control ) {
                control.Controls.Add( nota );
                control.Controls.Add( copyButton );
                control.Controls.Add( pasteButton );
                control.Controls.Add( deleteButton );
                control.Controls.Add( nome );
            }
            public void RemoveFromControl(Control control ) {
                control.Controls.Remove( nota );
                control.Controls.Remove( copyButton );
                control.Controls.Remove( pasteButton );
                control.Controls.Remove( deleteButton );
                control.Controls.Remove( nome );
            }

        }
        public Note() {
            InitializeComponent();
        }

        public Note( MainBar mainBar ) {
            InitializeComponent();
            this.mainBar = mainBar;
        }

        private void Note_Load( object sender, EventArgs e ) {
            panel1.Width = this.Width - 20;
            panel1.Height = this.Height - 70;
            AddNoteRowElement();
            this.Resize += OnFormResized;

        }

        private void OnFormResized( object sender, EventArgs e ) {
            panel1.Width = this.Width - 20;
            panel1.Height = this.Height - 70;
            foreach(NoteRow row in noteRows) {
                row.nota.Width = (panel1.Width - row.copyButton.Width - row.pasteButton.Width - 15 * 2 - 70);
            }
        }
        private void AddNoteRowElement() {
            if(noteRows.Count > 0) {
                this.noteRows[noteRows.Count - 1].nota.TextChanged -= OnTextChanged;
            }
            if(noteRows.Count > 0) {
                this.noteRows[noteRows.Count - 1].deleteButton.Enabled = true;
            }
            TextBox newTextBox = new TextBox();
            TextBox newNoteName = new TextBox();
            Button newCopyButton = new Button();
            Button newPasteButton = new Button();
            Button newDeleteButton = new Button();
            newDeleteButton.Width = newDeleteButton.Height;
            newDeleteButton.Location = new Point( hBorder, vBorder + (newTextBox.Height * noteRows.Count) + (SPACING * noteRows.Count) );
            newPasteButton.Text = "Paste";
            newCopyButton.Text = "Copy";
            newTextBox.Multiline = true;
            newTextBox.Location = new System.Drawing.Point( hBorder + newDeleteButton.Width, vBorder + (newTextBox.Height * noteRows.Count) + (SPACING * noteRows.Count ) );
            newTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            newCopyButton.Width = 50;
            newPasteButton.Width = 50;
            newTextBox.Width = (panel1.Width - newCopyButton.Width - newPasteButton.Width - (15 * 2) - 70 - newDeleteButton.Width - newNoteName.Width);
            newNoteName.Location = new Point( hBorder + newDeleteButton.Width + newTextBox.Width, vBorder + (newTextBox.Height * noteRows.Count) + (SPACING * noteRows.Count));
            newPasteButton.Location = new System.Drawing.Point( newDeleteButton.Width + newNoteName.Width + newTextBox.Width + newCopyButton.Width + hBorder, vBorder + (newTextBox.Height * noteRows.Count) + (SPACING * noteRows.Count) );
            newCopyButton.Location = new System.Drawing.Point( newDeleteButton.Width + newNoteName.Width + newTextBox.Width + hBorder, vBorder + (newTextBox.Height * noteRows.Count) + (SPACING * noteRows.Count) );
            newCopyButton.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            newPasteButton.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            newTextBox.Height = newCopyButton.Height;
            noteRows.Add( new NoteRow( newTextBox, newCopyButton, newPasteButton, newDeleteButton, newNoteName ) );
            noteRows[noteRows.Count - 1].ApplyToControl( panel1 );
            this.noteRows[noteRows.Count - 1].nota.TextChanged += OnTextChanged;
            this.noteRows[noteRows.Count - 1].copyButton.Click += CopyTextToClipboard;
            this.noteRows[noteRows.Count - 1].pasteButton.Click += PasteTextFromClipboard;
            this.noteRows[noteRows.Count - 1].deleteButton.Click += DeleteRowClick;
            this.noteRows[noteRows.Count - 1].deleteButton.Enabled = false;
        }

        private void OnTextChanged( object sender, EventArgs e ) {
            AddNoteRowElement();
        }

        private void CopyTextToClipboard( object sender, EventArgs e ) {
            Button button = (Button)sender;
            int i = 0;
            while(noteRows[i].copyButton != button) {
                i++;
            }
            Clipboard.SetText( noteRows[i].nota.Text );
        }

        private void PasteTextFromClipboard( object sender, EventArgs e ) {
            Button button = (Button)sender;
            int i = 0;
            while(noteRows[i].pasteButton != button) {
                i++;
            }
            noteRows[i].nota.Text = Clipboard.GetText();
        }

        protected override void OnClosed( EventArgs e ) {
            base.OnClosed( e );
            mainBar.noteInstance = null;
        }

        private void DeleteRowClick( object sender, EventArgs e ) {
            Button button = (Button)sender;
            int i = 0;
            while(noteRows[i].deleteButton != button) {
                i++;
            }
            RedrawNoteRows( i );
            noteRows[i].RemoveFromControl( panel1 );
            noteRows.RemoveAt( i );

        }
        private void RedrawNoteRows( int index ) {
            for(int i=noteRows.Count - 1; i > index; i--) {
                noteRows[i].nota.Location = noteRows[i - 1].nota.Location;
                noteRows[i].nome.Location = noteRows[i - 1].nome.Location;
                noteRows[i].deleteButton.Location = noteRows[i - 1].deleteButton.Location;
                noteRows[i].copyButton.Location = noteRows[i - 1].copyButton.Location;
                noteRows[i].pasteButton.Location = noteRows[i - 1].pasteButton.Location;
            }
        }
    }
}
