using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Collections;

namespace Hacknet_Like {
    public class Utilities {
        public const string xmlLayoutFileName = "layout.xml";        
        public const string LayoutFilesFolder = "Layouts";
        public const string xmlNoteFileName = "notes.xml";

        public class Colors {
            public static System.Drawing.Color QuitButtonRed = System.Drawing.Color.FromArgb( 128, 0, 0 );
            public static System.Drawing.Color DefaultGrey = System.Drawing.Color.FromArgb( 255, 64, 64, 64 );
            public static System.Drawing.Color TerminalButtonGrey = System.Drawing.Color.FromArgb( 153, 153, 153 );
        }

        public struct WindowProperties {
            public System.Drawing.Point location;
            public System.Drawing.Point size;

            public WindowProperties( System.Drawing.Point _location, System.Drawing.Point _size) {
                location = _location;
                size = _size;
            }
        }
        public struct NoteInfo {
            public string noteName;
            public string noteContent;

            public NoteInfo(string name, string content) {
                noteName = name;
                noteContent = content;
            }
        }

        [XmlRoot]
        public class NotesContainer {
            [XmlArray( "NoteInfos" )]
            [XmlArrayItem( "NoteInfo" )]
            public List<NoteInfo> noteInfos = new List<NoteInfo>();

            public void Save( string path ) {
                var serializer = new XmlSerializer( typeof( NotesContainer ) );
                using(var stream = new FileStream( path, FileMode.Create )) {
                    serializer.Serialize( stream, this );
                }

            }
            public static NotesContainer Load( string path ) {
                var serializer = new XmlSerializer( typeof( NotesContainer ) );
                using(var stream = new FileStream( path, FileMode.Open )) {
                    return serializer.Deserialize( stream ) as NotesContainer;
                }
            }
        }

        [XmlRoot]
        public class LayoutContainer {
            public System.Drawing.Point mainBarLocation;
            public System.Drawing.Point noteLocation;
            public System.Drawing.Point noteSize;
            public bool noteOpened;

            [XmlArray( "TerminalLocations" )]
            [XmlArrayItem( "Location" )]
            public List<WindowProperties> terminalLocations = new List<WindowProperties>();

            public void Save(string path) {
                var serializer = new XmlSerializer( typeof( LayoutContainer ) );
                using(var stream = new FileStream( path, FileMode.Create )) {
                    serializer.Serialize( stream, this );
                }

            }
            public static LayoutContainer Load( string path ) {
                var serializer = new XmlSerializer( typeof( LayoutContainer ) );
                using(var stream = new FileStream( path, FileMode.Open )) {
                    return serializer.Deserialize( stream ) as LayoutContainer;
                }
            }
        }
    }
}
