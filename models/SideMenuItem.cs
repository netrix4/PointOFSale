using PointOfSale.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PointOfSale.models
{
    public class SideMenuItem
    {
        public string Name { get; set; }
        public Enums.SideMenuType MenuType { get; set; }
        public SideMenuItem(string Name, Enums.SideMenuType MenuType)
        {
            this.Name = Name;
            this.MenuType = MenuType;
        }

    }
}
