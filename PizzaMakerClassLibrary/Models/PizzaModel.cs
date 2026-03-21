using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

/*
 * Elijah Hodge
 * CST - 250
 * 03/19/2026
 * Pizza Maker
 * Activity 4
 * */

namespace PizzaMakerClassLibrary.Models
{
    public class PizzaModel
    {
        // Class Properties
        public string ClientName { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> StrangeAddOns { get; set; }
        public string Crust { get; set; }
        public int SauceQty { get; set; }
        public int CheeseQty { get; set; }
        public DateTime DeliveryTime { get; set; }
        public Color PizzaBoxColor { get; set; }
        public decimal Price { get; set; }

        /// <summary>
        /// Default Constructor for Pizza Model
        /// </summary>
        public PizzaModel()
        {
            // Declare the default properties
            ClientName = "Unkown";
            Ingredients = new List<string>();
            StrangeAddOns = new List<string>();
            Crust = "Unknown";
            SauceQty = 0;
            CheeseQty = 0;
            DeliveryTime = DateTime.Now;
            PizzaBoxColor = Color.White;
            Price = 15m;
        }
    }
}