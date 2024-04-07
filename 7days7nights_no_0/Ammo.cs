using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7days7nights_no_0
{
    internal class Ammo
    {
        public Image bullett { get; set; }


        public int x { get; set; }
        public int y { get; set; }
        public int speed { get; set; }
        public Ammo(Image bullett)
        {
            this.bullett = bullett;
        }
    }
}
