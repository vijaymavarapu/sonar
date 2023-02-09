using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace SampleSonarTestSource.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public int getTheNumber(int val)
        {
            if (val <= 0)
            {
                return val;
            }
            int num = int.MaxValue;
            return num + val;  // Noncompliant
        }

        public void DoSomething(string[] strings)
        {
            for (int i = 0; i < strings.Length; i--)  // Noncompliant
            {
                string s = strings[i];  // IndexOutOfRangeException  when i reaches -1
                                        // do stuff
            }
            var x=0;
            if (x < 0)
            {
                new ArgumentException("x must be nonnegative");
            }
        }


    }
}
