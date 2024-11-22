using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_on_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q.1>
                //savings account
            SavingsAccount s1 = new SavingsAccount(1102,5000);
            s1.Deposit(2000);

            Console.WriteLine();
            s1.Withdraw(1000);
            Console.WriteLine(s1);
            //curentAccount
            CurrentAccount c1 = new CurrentAccount(456, 6000);
            c1.Deposit(1000);
            Console.WriteLine(c1);
            c1.Withdraw(2000);
            Console.WriteLine(c1);

            //Q.2
            //Circle
            Circle cr = new Circle(6);
            cr.CalculateArea();
            cr.CalculatePerimeter();
            Console.WriteLine(cr);
            //triangle
            Triangle tr = new Triangle(23, 10,1,2,3);
            tr.CalculateArea();
            tr.CalculatePerimeter();
            Console.WriteLine(tr);


            //Q.4
            //spacecraft
            SpaceCraft sc = new SpaceCraft();
            sc.FlyObj();
            
            //Airplane
            Airplane ap = new Airplane();
            ap.FlyObj();
            
            Helicopter hp = new Helicopter();
            hp.FlyObj();
            
        }
    }
}
