using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P3M03BranchTheFlowOfCodeUsingTheSwitchCaseConstruct {

    public static class Program {

        public static void Main() {
            // Use the switch statement
            string fruit = "banana";
            switch (fruit) {
                case "apple":
                    Console.WriteLine($"App will display information for apple.");
                    break;
                case "banana":
                    Console.WriteLine($"App will display information for banana.");
                    break;
                case "cherry":
                    Console.WriteLine($"App will display information for cherry.");
                    break;
            }

            // example 2
            int employeeLevel = 200;
            string employeeName = "John Smith";
            string title = "";
            switch (employeeLevel) {
                case 100:
                case 105: // multiple cases can be handled the same way
                    title = "Junior Associate";
                    break;
                case 200:
                    title = "Senior Associate";
                    break;
                case 300:
                    title = "Manager";
                    break;
                case 400:
                    title = "Senior Manager";
                    break;
                default:
                    title = "Associate";
                    break;
            }
            Console.WriteLine($"{employeeName}, {title}");

            // Code challenge: rewrite if-elseif-else using a switch statement
            // SKU = Stock Keeping Unit. 
            // SKU value format: <product #>-<2-letter color code>-<size code>
            string sku = "01-MN-L";
            string[] product = sku.Split('-');
            string type = "";
            string color = "";
            string size = "";
            if (product[0] == "01") {
                type = "Sweat shirt";
            } else if (product[0] == "02") {
                type = "T-Shirt";
            } else if (product[0] == "03") {
                type = "Sweat pants";
            } else {
                type = "Other";
            }
            if (product[1] == "BL") {
                color = "Black";
            } else if (product[1] == "MN") {
                color = "Maroon";
            } else {
                color = "White";
            }
            if (product[2] == "S") {
                size = "Small";
            } else if (product[2] == "M") {
                size = "Medium";
            } else if (product[2] == "L") {
                size = "Large";
            } else {
                size = "One Size Fits All";
            }
            Console.WriteLine($"Product: {size} {color} {type}");

            // solution
            // SKU = Stock Keeping Unit
            sku = "01-MN-L";
            product = sku.Split('-');
            type = "";
            color = "";
            size = "";
            switch (product[0]) {
                case "01":
                    type = "Sweat shirt";
                    break;
                case "02":
                    type = "T-Shirt";
                    break;
                case "03":
                    type = "Sweat pants";
                    break;
                default:
                    type = "Other";
                    break;
            }
            switch (product[1]) {
                case "BL":
                    color = "Black";
                    break;
                case "MN":
                    color = "Maroon";
                    break;
                default:
                    color = "White";
                    break;
            }
            switch (product[2]) {
                case "S":
                    size = "Small";
                    break;
                case "M":
                    size = "Medium";
                    break;
                case "L":
                    size = "Large";
                    break;
                default:
                    size = "One Size Fits All";
                    break;
            }
            Console.WriteLine($"Product: {size} {color} {type}");
        }

    }

}