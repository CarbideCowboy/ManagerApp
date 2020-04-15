﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Realms;

namespace ManagerApp.Models
{
    public class Order : RealmObject
    {
        [PrimaryKey]
        public string _id { get; set; }
        public IList<OrderItem> menuItems { get; }
        public string waitstaff_id { get; set; }
        public bool send_to_kitchen { get; set; }
        public string time_completed { get; set; } //This way I'm only looking at paid for, completed orders. Not on going
        public Order() { }
        // Copy constructor
        public Order(Order o)
        {
            _id = o._id;
            // Deep copy of each menu item
            foreach (OrderItem m in o.menuItems)
                menuItems.Add(m);

            waitstaff_id = o.waitstaff_id;
            send_to_kitchen = o.send_to_kitchen;
        }

    }
}
