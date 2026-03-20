using System;
using System.Collections.Generic;
using System.Text;

/*
 * Elijah Hodge
 * CST - 250
 * 03/20/2026
 * Pizza Maker
 * Activity 4
 * */

namespace PizzaMakerClassLibrary.Services.DataAccessLayer
{
    public class PizzaDAO
    {
        // Class level variables
        private List<PizzaModel> _pizzaOrder;

        /// <summary>
        /// Default constructor for the pizza DAO
        /// </summary>
        public PizzaDAO()
        {
            _pizzaOrder = new List<PizzaModel>();
        }
    }
}
