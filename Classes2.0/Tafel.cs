using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2._0
{
    class Tafel
    {
        private int width;
        private int height;
        public Tafel(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public void ShowData()
        {
            Console.WriteLine("The Width of the table is {0} and the height is {1}", width,height);
        }
    }

}
