/*Pizza Class
 * Contains information of each pizza
 * 
 * Revision History
 *      Phillip Lu, 2020.06.23
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PizzaOrder
{
    class Pizza
    {
        public string[] Sauce = new string[9] { "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal" };
        public string[] Cheese = new string[9] { "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal" };
        public string[] Instructions = new string[9] { "", "", "", "", "", "", "", "", "" };
        public string[,] Toppings = new string[9,11] {
            { "", "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "", "" },
        };
        public bool[,] ToppingBool = new bool[9, 11] 
        { 
            { false, false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false, false }, 
            { false, false, false, false, false, false, false, false, false, false, false }, 
            { false, false, false, false, false, false, false, false, false, false, false }, 
            { false, false, false, false, false, false, false, false, false, false, false }, 
            { false, false, false, false, false, false, false, false, false, false, false }, 
            { false, false, false, false, false, false, false, false, false, false, false }, 
            { false, false, false, false, false, false, false, false, false, false, false }, 
            { false, false, false, false, false, false, false, false, false, false, false }, 
        };
        
        public Pizza()
        {
        }
    }
}
