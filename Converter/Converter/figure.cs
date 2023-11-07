using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class figure
    {
        public string Name;
        public int Width;
        public int Height;

        public figure() {
          
        }

        public figure(string name, int width, int height)
        {
            Name = name;
            Width = width;
            Height = height;
        }
        public void wrinfo() 
        {
            Console.WriteLine("Фигура: " + this.Name);
            Console.WriteLine("Ширина: " + this.Width);
            Console.WriteLine("Высота: " + this.Height);
        }
    }
}
