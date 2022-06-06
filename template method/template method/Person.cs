using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_method
{
    internal abstract class Person
    {
        protected void getUp()
        {
            Console.WriteLine("get up");
        }

        protected void goToWork()
        {
            Console.WriteLine("go to work");
        }
        protected abstract void Work();
        protected void relax()
        {
            Console.WriteLine("relax one hour");
        }
        protected void returnToHome()
        {
            Console.WriteLine("return to home");
        }
        public void all()
        {
            getUp();
            goToWork(); 
            Work();
            relax();
            returnToHome();
        }
    }
}
