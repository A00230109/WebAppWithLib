using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppCalc1YoussefNAFAA.Models;

namespace WebAppCalc1YoussefNAFAA.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View(new Calculator());
        }

        [HttpPost]
        public ActionResult Index(Calculator calc, string calculate)
        {
            calc.total = 0;
            switch (calculate)
            {
                case "add":
                    calc.total = calc.number1 + calc.number2;
                    break;
                case "substract":
                    calc.total = calc.number1 - calc.number2;
                    break;
                case "multiply":
                    calc.total = calc.number1 * calc.number2;
                    break;
                case "divide":
                    if (calc.number2 == 0)
                    {
                        
                        calc.message = "Division by Zero ";
                    }
                    else
                    {
                        calc.total = calc.number1 / calc.number2;
                    }
                    break;
                default:
                    
                    break;
            }
            return View(calc);
        }

    }
}