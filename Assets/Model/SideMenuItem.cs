using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Model
{
    public class SideMenuItem
    {
        public GameObject MenuItemPrefab { get; private set; }

        public SideMenuItem(GameObject MenuItemPrefab)
        {
            this.MenuItemPrefab = MenuItemPrefab;
        }
    }
}
