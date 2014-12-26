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
        public void add(Film f)
        {
            catalog.Add(f);
        }
        public void change(Film f, int index)
        {
            catalog[index] = f;
        }
        public Film index(int index)
        {
            return catalog[index];
        }
        public void delete(int index)
        {
            catalog.RemoveAt(index);
        }
    } 
}
