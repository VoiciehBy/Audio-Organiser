using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audio_Organiser
{
    partial class Song
    {
        public override string ToString()
        {

            var f = TagLib.File.Create(Path);

            return f.Tag.FirstAlbumArtist + " - " + f.Tag.Title + " from " + f.Tag.Album;
        }
    }
}
