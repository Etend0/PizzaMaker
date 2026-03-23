using System;
using System.Collections.Generic;
using System.Text;
using PizzaMakerClassLibrary.Models;

/*
 * Elijah Hodge
 * CST - 250
 * 03/20/2026
 * Pizza Maker
 * Activity 4
 */

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

        /// <summary>
        /// Add a pizza to the current order
        /// </summary>
        /// <param name="newPizza"></param>
        /// <returns></returns>
        public int AddPizzaToOrder(PizzaModel newPizza)
        {
            // Add the new pizza to the pizzaOrder list
            _pizzaOrder.Add(newPizza);
            // Return the number of pizzas in pizzaOrder
            return _pizzaOrder.Count;
        }

        /// <summary>
        /// Get the list of pizzas in the current order
        /// </summary>
        /// <returns></returns>
        public List<PizzaModel> GetPizzaOrder()
        {
            // Return the pizzaOrder list
            return _pizzaOrder;
        }
    }
}
