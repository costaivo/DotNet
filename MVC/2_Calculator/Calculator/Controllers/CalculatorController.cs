using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {

            if (Request["txt"] != null)
            {
                if (Request["txt"][Request["txt"].Length - 1] == '+' || Request["txt"][Request["txt"].Length - 1] == '-' || 
                    Request["txt"][Request["txt"].Length - 1] == '*' || Request["txt"][Request["txt"].Length - 1] == '/')
                {
                    ViewBag.flag = 0;
                    ViewBag.result = Request["txt"];
                }
                else
                {
                    ViewBag.result = GetResult(Request["txt"]);
                    ViewBag.flag = 1;
                }
            }
            return View();
        }

        public string GetResult(string str)
        {
            List<char> symbleList = new List<char>();
            char[] charSymble = { '+', '-', '*', '/' };
            string[] st = str.Split(charSymble);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '+' || str[i] == '-' || str[i] == '*' || str[i] == '/')
                {
                    symbleList.Add(str[i]);
                }
            }
            double result = Convert.ToDouble(st[0]);
            for (int i = 1; i < st.Length; i++)
            {
                double num = Convert.ToDouble(st[i]);
                int j = i - 1;
                switch (symbleList[j])
                {
                    case '+':
                        result = result + num;
                        break;
                    case '-':
                        result = result - num;
                        break;
                    case '*':
                        result = result * num;
                        break;
                    case '/':
                        result = result / num;
                        break;
                    default:
                        result = 0.0;
                        break;
                }
            }
            return result.ToString();
        }
    }
}