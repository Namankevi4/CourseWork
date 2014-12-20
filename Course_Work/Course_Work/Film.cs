using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;
using System.Xml.Serialization;
namespace Course_Work
{
    public class Film
    {
        public string title { get; set; }
        public int year { get; set; }
        public string genre { get; set; }
        public string producer { get; set; }
        public int time { get; set; }
        public string description;
        [XmlIgnore]
        public Image Photo;
        Film() { }
        public Film(string Title, int Year, string Genre, string Producer, string Description, int Time, Image photo)
        {
            title = Title;
            year = Year;
            producer = Producer;
            genre = Genre;
            description = Description;
            time = Time;
            this.Photo = photo;
        }        
    }
}
