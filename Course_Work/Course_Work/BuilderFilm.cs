using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Course_Work
{
    class BuilderFilm
    {
        public SortableBindingList<Film> catalog = new SortableBindingList<Film>();
        public Film add(string title, int year, string genre, string producer, string description, int time, Image photo )
        {
            Film f = new Film(title, year, genre, producer, description, time, photo);
            return f;
        }
    } 
}
