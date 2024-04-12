using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7days7nights_no_0
{
    public class Skin
    {
        public EnumContainer.Skin Id { get; set; }
        public Skin(EnumContainer.Skin id)
        {
            Id = id;
        }

        //public void ChangeShip(string path)
        //{
        //    switch (path)
        //    {
        //        case "Images\\SpaceShipStand.gif":
        //            Player.Skin.Id = (EnumContainer.Skin)0;
        //            break;
        //        case "Images\\Ship2.png":
        //            Player.Skin.Id = (EnumContainer.Skin)1;
        //            break;
        //        case "Images\\Ship3.png":
        //            Player.Skin.Id = (EnumContainer.Skin)2;
        //            break;
        //        case "Images\\Ship4.png":
        //            Player.Skin.Id = (EnumContainer.Skin)3;
        //            break;
        //        default:
        //            break;
        //    }
        //}

    }
}
