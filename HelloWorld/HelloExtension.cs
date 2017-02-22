using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public static class HelloExtension
    {
        public static string ToUKDate(this DateTime val)
        {
            return val.ToString("yyyy-MM-dd");
        }


    }
}
