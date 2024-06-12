using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
    }
}
