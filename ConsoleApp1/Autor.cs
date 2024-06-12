using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string Name { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
