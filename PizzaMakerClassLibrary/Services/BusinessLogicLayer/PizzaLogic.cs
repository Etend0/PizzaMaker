using PizzaMakerClassLibrary.Models;
using PizzaMakerClassLibrary.Services.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

/*
 * Elijah Hodge
 * CST - 250
 * 03/19/2026
 * Pizza Maker
 * Activity 4
*/

namespace PizzaMakerClassLibrary.Services.BusinessLogicLayer
{
    public class PizzaLogic
    {
        // Declare class level variables
        private PizzaDAO _pizzaDAO;

        /// <summary>
        /// Default constructor for PizzaLogic
        /// </summary>
        public PizzaLogic()
        {
            // Initialize the pizzaDAO object
            _pizzaDAO = new PizzaDAO();
        }

        /// <summary>
        /// Add a new pizza to the current order
        /// </summary>
        /// <param name="newPizza"></param>
        /// <returns></returns>
        public (bool isValidPizza, int pizzasInOrder) AddPizzaToOrder(PizzaModel newPizza)
        {
            // Declare and initialize
            int pizzas = -1;

            // Call the DAO AddPizzaToOrder
            pizzas = _pizzaDAO.AddPizzaToOrder(newPizza);
            // Return the pizzas variable
            return (true, pizzas);
        }

        /// <summary>
        /// Get the list of pizzas in the current order
        /// </summary>
        /// <returns></returns>
        public List<PizzaModel> GetPizzaOrder()
        {
            // Get and return the GetPizzaOrder from the DAO
            return _pizzaDAO.GetPizzaOrder();
        }
    }
}
