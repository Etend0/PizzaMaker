/*
 * Elijah Hodge
 * CST - 250
 * 03/19/2026
 * Pizza Maker
 * Activity 4
*/

using PizzaMakerClassLibrary.Models;
using PizzaMakerClassLibrary.Services.BusinessLogicLayer;

namespace FrmOrderDetails
{
    public partial class FrmOrderDetails : Form
    {
        // Declare class level variables
        private List<PizzaModel> _pizzaOrder;
        private PizzaLogic _pizzaLogic;

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
