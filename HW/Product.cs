using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Categorys Category { get; set; }
        public string Image { get; set; }
    }
    public enum Categorys
    {
        Бытовая_техника,
        Еда
    }
}



