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
            bool isValid = false;

            // Validate the pizza to make sure it has a client name, crust, at least one ingredient, and some sauce and cheese
            if (!string.IsNullOrEmpty(newPizza.ClientName) && newPizza.ClientName != "Unkown"
                && !string.IsNullOrEmpty(newPizza.Crust) && newPizza.Crust != "Unknown"
                && newPizza.Ingredients.Count > 0
                && newPizza.SauceQty > 0
                && newPizza.CheeseQty > 0)
            {
                // Set isValid to true
                isValid = true;
                // Call the DAO AddPizzaToOrder
                pizzas = _pizzaDAO.AddPizzaToOrder(newPizza);
            }

            // Return the isValid and pizzas variables
            return (isValid, pizzas);
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

        /// <summary>
        /// Write the pizza order to a text file
        /// </summary>
        /// <returns></returns>
        public bool WriteOrderToFile()
        {
            // Get and return the WriteOrderToFile from the DAO
            return _pizzaDAO.WriteOrderToFile();
        }
    }
}
