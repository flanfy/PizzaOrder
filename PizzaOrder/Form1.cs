/*Plu_Assignment2
 * Windows form program for ordering pizzas and selecting toppings and cheese/sauce for each
 * 
 * Revision History
 *      Phillip Lu, 2020.06.23
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder
{
    public partial class FormPizzaOrder : Form
    {
        Pizza pizza;
        RadioButton rdb;
        Panel pnlOrderSummary;
        RadioButton selectedPizza = null;
        RadioButton selectedCheese = null;
        RadioButton selectedSauce = null;
        CheckBox selectedToppings = null;
        TextBox Instructions = null; 
        

        int count = 0; //total number of pizzas
        int pizzaNum = 0; //number of current pizza
        public FormPizzaOrder()
        {
            InitializeComponent();
        }

        /// <summary>
        /// user enters quantity of pizzas from 1 - 9 and clicks start order;
        /// radiobutton for each pizza is created in a panel which is now enabled for order customization;
        /// if input is not an integer or not from 1 - 9, a message appears under the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPizzaNum.Text, out count) == true) //tests if input was a number
            {
                if (count > 0 && count < 10) //max 9 pizzas
                {
                    for (int i = 0; i < count; i++)
                    {
                        rdb = new RadioButton();
                        rdb.Location = new Point(15, (160 * i) + 5);
                        rdb.Name = "rdb" + (i + 1).ToString();
                        pnlPizzas.Controls.Add(rdb); //creates a box for each pizza that user requested in panel 
                        rdb.Appearance = Appearance.Button;
                        rdb.Size = new Size(150, 150);

                        pnlInstructions.Enabled = true;
                        pizza = new Pizza(); //creat new pizza object
                        rdb.Tag = pizza; //puts pizza object in pizza button tag
                        lblErrorMessage.Text = "";
                        rdb.Click += new EventHandler(rdb_Click);
                    }
                }
                else
                {
                    lblErrorMessage.Text = "Quantity must be from 1 - 9.";
                }
            }
            else
            {
                lblErrorMessage.Text = "Quantity must be an integer.";
            }
            
        }
        /// <summary>
        /// user selects a pizza and settings for sauce, cheese, toppings, and instructions are loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_Click(object sender, EventArgs e)
        {
            selectedPizza = (RadioButton)sender;
            pizzaNum = int.Parse(selectedPizza.Name.Substring(3)) - 1;
            pizza = (Pizza)rdb.Tag; //retrieves pizza object from pizza button tag

            //loads selected pizza's special instructions in instruction box
            txtInstructions.Text = pizza.Instructions[pizzaNum];

            //load selected pizza toppings by checking boxes of saved toppings if corresponding bool is true
            foreach (var topping in grbToppings.Controls.OfType<CheckBox>()) //assigns variable to each topping checkbox
            {
                int toppingNum = int.Parse(topping.Name.Substring(3)) - 1;

                for (int i = 0; i < 11; i++)
                {
                    if (pizza.ToppingBool[pizzaNum, toppingNum] == true) 
                    {
                        topping.Checked = true;
                    }
                    else
                    {
                        topping.Checked = false;
                    }
                }  
            }

            //load selected pizza cheese by selecting saved cheese button
            switch (pizza.Cheese[pizzaNum]) //loads cheese of clicked pizza
            {
                case "None":
                    rdbCheese0.Checked = true;
                    break;

                case "Light":
                    rdbCheese1.Checked = true;
                    break;

                case "Normal":
                    rdbCheese2.Checked = true;
                    break;

                case "Heavy":
                    rdbCheese3.Checked = true;
                    break;
            }

            //load selected pizza sauce by selecting saved sauce button
            switch (pizza.Sauce[pizzaNum]) //loads sauce of clicked pizza
            {
                case "None":
                    rdbSauce0.Checked = true;
                    break;

                case "Light":
                    rdbSauce1.Checked = true;
                    break;

                case "Normal":
                    rdbSauce2.Checked = true;
                    break;

                case "Heavy":
                    rdbSauce3.Checked = true;
                    break;
            }
        }

        /// <summary>
        /// Lets user select the preferred amount of cheese for the currently selected pizza
        /// saves choice to array in Pizza class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbCheeseChecked(object sender, EventArgs e)
        {
            selectedCheese = (RadioButton)sender;
            pizza = (Pizza)rdb.Tag;

            if (selectedPizza != null) //only saves selection if a pizza is selected
            {
                pizza.Cheese[pizzaNum] = selectedCheese.Text;
            }
        }

        /// <summary>
        /// Lets user select the preferred amount of sauce for the currently selected pizza
        /// saves choice to array in Pizza class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbSauceChecked(object sender, EventArgs e)
        {
            selectedSauce = (RadioButton)sender;
            pizza = (Pizza)rdb.Tag;

            if (selectedPizza != null) //only saves selection if a pizza is selected
            {
                pizza.Sauce[pizzaNum] = selectedSauce.Text;
            }
        }

        /// <summary>
        /// Lets user select the toppings for the currently selected pizza
        /// saves choice to array in Pizza class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkToppings_Changed(object sender, EventArgs e)
        {
            pizza = (Pizza)rdb.Tag;
            selectedToppings = (CheckBox)sender;
            int toppingNum = int.Parse(selectedToppings.Name.Substring(3)) - 1;

            if (selectedPizza != null) //only saves selection if a pizza is selected
            {
                //adds toppings to pizza if checkbox is checked and sets a bool to true; removes and sets to false otherwise
                if (selectedToppings.Checked == true)
                {
                    pizza.Toppings[pizzaNum, toppingNum] = selectedToppings.Text;
                    pizza.ToppingBool[pizzaNum, toppingNum] = true;
                }

                else
                {
                    pizza.Toppings[pizzaNum, toppingNum] = "";
                    pizza.ToppingBool[pizzaNum, toppingNum] = false;
                }
            }
        }

        /// <summary>
        /// saves user input to selected pizza's info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtInstructions_Leave(object sender, EventArgs e)
        {
            Instructions = (TextBox)sender;
            pizza = (Pizza)rdb.Tag;

            if (selectedPizza != null) //only saves selection if a pizza is selected
            {
                pizza.Instructions[pizzaNum] = txtInstructions.Text;
            }
        }

        /// <summary>
        /// Displays information of all pizzas in user's order in a new section on the right side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            pizza = (Pizza)rdb.Tag;
            txtInstructions.Clear();

            //disables rest of form
            pnlPizzaNum.Enabled = false;
            pnlPizzas.Enabled = false;
            pnlInstructions.Enabled = false;

            pnlOrderSummary = new Panel();
            Label lblOrderSummary = new Label();
            Label lblOrders = new Label();
            Panel pnlOrders = new Panel();
            TextBox txtOrders = new TextBox();
            Button btnNewOrder = new Button();

            //panel container for all order summary elements below
            pnlOrderSummary.Location = new Point(620, 25);
            pnlOrderSummary.Size = new Size(320, 630);
            Controls.Add(pnlOrderSummary);

            //title
            //lblOrderSummary.Location = new Point(0, 0);
            lblOrderSummary.Location = new Point(0, 0);
            lblOrderSummary.Font = new Font("Arial", 18);
            lblOrderSummary.Size = new Size(200, 50);
            lblOrderSummary.Text = "Order Summary:";
            pnlOrderSummary.Controls.Add(lblOrderSummary);

            //new order button
            btnNewOrder.Location = new Point(20, 550);
            btnNewOrder.Size = new Size(279, 36);
            btnNewOrder.BackColor = Color.LightGreen;
            btnNewOrder.Text = "Start New Order";
            pnlOrderSummary.Controls.Add(btnNewOrder);

            //order info panel
            pnlOrders.Location = new Point(10, 50);
            pnlOrders.Size = new Size(300, 450);
            pnlOrders.AutoScroll = true;
            pnlOrderSummary.Controls.Add(pnlOrders);
            pnlPizzas.BorderStyle = BorderStyle.None;
            pnlOrders.Controls.Add(lblOrders);

            btnNewOrder.Click += new EventHandler(btnNewOrder_Click);
            int toppingCount = 0; //counts number of total toppings across all pizzas; used to determine space required for order info

            for (int i = 0; i < count; i++)
            {
                string[] toppingArray = new string[count];

                for (int j = 0; j < 11; j++)
                {
                    if (pizza.Toppings[i, j].Length > 0)
                    {
                        toppingArray[i] += $"    {pizza.Toppings[i, j]}\r\n"; //combines toppings in each pizza's topping array into a single string
                        toppingCount++;
                    }
                }

                //sets special instructions and toppings list to N/A if none available
                if (pizza.Instructions[i] == "")
                {
                    pizza.Instructions[i] = "N/A";
                }

                if (toppingArray[i] == null)
                {
                    toppingArray[i] += "N/A\r\n";
                }

                lblOrders.Size = new Size(250, ((count * 90) + (toppingCount * 15))); //size of pizza order info using number of total pizzas and toppings
                lblOrders.Text += $"Pizza {i + 1}:\r\nSauce: {pizza.Sauce[i]}\r\nCheese: {pizza.Cheese[i]}\r\n" +
                $"Toppings:\r\n{toppingArray[i]}Instructions: {pizza.Instructions[i]}\r\n \r\n"; //prints pizza info
            }
            //resets counters for new order
            toppingCount = 0;
            count = 0;
        }

        /// <summary>
        /// Resets form to the state before the user began their order and clears all pizza info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            pizza = (Pizza)rdb.Tag;

            pnlPizzaNum.Enabled = true;
            pnlPizzas.Enabled = true;
            pnlInstructions.Enabled = false;
            txtPizzaNum.Clear();
            Controls.Remove(pnlOrderSummary); //removes all elements involved with the order summary

            //removes and rebuilds pnlPizzas to reset pizza radiobuttons; was having trouble trying to only remove the buttons
            Controls.Remove(pnlPizzas);
            pnlPizzas = new Panel();
            pnlPizzas.Size = new Size(200, 461);
            pnlPizzas.AutoScroll = true;
            pnlPizzas.Location = new Point(28, 145);
            pnlPizzas.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pnlPizzas);
            
            this.Size = new Size(622,664); //resets window to initial size
            
            //resets pizza info
            for (int i = 0; i < count; i++)
            {
                pizza.Cheese[i] = "";
                pizza.Sauce[i] = "";
                
                pizza.Instructions[i] = "";
                pnlPizzas.Controls.Remove(rdb);
                for (int j = 0; j < 11; j++)
                {
                    pizza.Toppings[i,j] = "";
                }
            } 
        }
    }
}
