using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpPortal_Specflow.Utilities
{
    public  class ElementExtensions
    {
        public static void JsClick(IWebDriver driver,  IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", element);
        }

    }
}
