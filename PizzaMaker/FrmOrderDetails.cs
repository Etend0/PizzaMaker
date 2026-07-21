using PizzaMakerClassLibrary.Models;
using PizzaMakerClassLibrary.Services.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Elijah Hodge
 * CST - 250
 * 07/20/2026
 * Pizza Maker
 * Activity 4
*/

namespace PizzaMaker
{
    public partial class FrmOrderDetails : Form
    {
        // Declare class level variables
        private List<PizzaModel> _pizzaOrder;
        private PizzaLogic _pizzaLogic;

        /// <summary>
        /// Parameterized constroctor for FrmOrderDetails
        /// </summary>
        /// <param name="_pizzaOrderList"></param>
        /// <param name="pizzaBusinessLogic"></param>
        public FrmOrderDetails(List<PizzaModel> _pizzaOrderList, PizzaLogic pizzaBusinessLogic)
        {
            // Initialize the form
            InitializeComponent();
            // Initialize the class level variables
            _pizzaOrder = _pizzaOrderList;
            _pizzaLogic = pizzaBusinessLogic;
        }

        /// <summary>
        /// Display the pizzas on the form
        /// </summary>
        public void DisplayPizzas()
        {
            // Clear the label
            lblOrderDetails.Text = "";

            // Loop through the pizza order list
            foreach (PizzaModel pizza in _pizzaOrder)
            {
                // Display the pizza details on the label
                lblOrderDetails.Text +=
                    $"Name: {pizza.ClientName}\n" +
                    $"Ingredients: {string.Join(", ", pizza.Ingredients)}\n" +
                    $"Strange Add-Ons: {string.Join(", ", pizza.StrangeAddOns)}\n" +
                    $"Crust: {pizza.Crust}\n" +
                    $"Sauce: {pizza.SauceQty}\n" +
                    $"Cheese: {pizza.CheeseQty}\n" +
                    $"Delivery Time: {pizza.DeliveryTime}\n" +
                    $"Pizza Box Color: {pizza.PizzaBoxColor.Name}\n" +
                    $"Price: ${pizza.Price}\n\n";
            }
        }
    }
}
