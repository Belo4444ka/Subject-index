using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subject_index
{
    public class IndexEntry
    {
        public string Word { get; set; }
        public List<int> pages { get; set; }

        public IndexEntry(string Name) {
            Word = Name;
            pages = new List<int>();
        }

        //метод добавления страницы
        public void AddPage(int page)
        {
            if (!pages.Contains(page))
            { 
                pages.Add(page);
            }
        }
        //метод удаление страницы
        public bool RemovePage(int page) 
        {
            return pages.Remove(page);
        }
    }
}
