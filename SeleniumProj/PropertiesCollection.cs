using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProj
{
 public   class PropertiesCollection
    {

        enum PropertyType
        {
            Id,
            Name,
            ClassName

        }

        public static IWebDriver driver { get; set; }
    }
}
