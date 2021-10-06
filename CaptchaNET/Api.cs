using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptchaNET
{
    class Api
    {
        public static int getCaptcha
        {
            get;
            set;
        }
        public static void generateCaptcha()
        {
            Random generate = new Random();
            var gen = generate.Next(1000, 9999);
            getCaptcha = gen;
        }
    }
}
