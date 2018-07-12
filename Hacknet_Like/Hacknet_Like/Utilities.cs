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

        public class Colors {
            public static System.Drawing.Color QuitButtonRed = System.Drawing.Color.FromArgb( 128, 0, 0 );
            public static System.Drawing.Color DefaultGrey = System.Drawing.Color.FromArgb( 255, 64, 64, 64 );
            public static System.Drawing.Color TerminalButtonGrey = System.Drawing.Color.FromArgb( 153, 153, 153 );
        }

        [XmlRoot]
        public class LayoutContainer {
            public System.Drawing.Point mainBarLocation;

            [XmlArray( "TerminalLocations" )]
            [XmlArrayItem( "Location" )]
            public List<System.Drawing.Point> terminalLocations;

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
