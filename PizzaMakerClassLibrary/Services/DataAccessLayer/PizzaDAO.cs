using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elijah Hodge
 * CST - 250
 * 07/20/2026
 * Pizza Maker
 * Activity 4
*/

namespace PizzaMakerClassLibrary.Services.DataAccessLayer
{
    internal class PizzaDAO
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
