using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;
namespace Course_Work
{
    [Serializable]
    public class Film
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Producer { get; set; }
        public int Time { get; set; }
        public string Description;
        public string Format { get; set; }
        public Image Photo;
        Film() { }
        public Film(string title, int year, string genre, string producer, string description, int time, Image photo, string format)
        {
            Title = title;
            Year = year;
            Producer = producer;
            Genre = genre;
            Description = description;
            Time = time;
            this.Photo = photo;
            Format = format;
        }        
    }
}
