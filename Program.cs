using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer myLenovo = new Computer();
            {
                myLenovo.model = "ThinkPad";
                myLenovo.price = 2500;
                myLenovo.numberOfProcessors = 2;
                myLenovo.screenSize = 14.5f;
                myLenovo.TellMeThePrice();
                myLenovo.TellMeTheScreenSize();
                myLenovo.TurnOn();
                myLenovo.TurnOff();
                myLenovo.AddProcessor(4);

            }


            Computer myAsus = new Computer()
            {
                model = "ZenBook",
                price = 4750,
                numberOfProcessors = 4,
                screenSize = 14.2f,
            isTurnOn = true
            };
        Console.WriteLine(myAsus);

            Console.WriteLine(myAsus.TellMeTheScreenSize());
            
            myAsus.TurnOn();
            myAsus.AddProcessor(8);
        
            

            Computer myHp = new Computer();
            {
                myHp.model = "EliteBook";
                myHp.price = 3800;
                myHp.numberOfProcessors = 8;
                myHp.screenSize = 14.6f;
                myHp.TellMeThePrice();
                myHp.TellMeTheScreenSize();
                myHp.TurnOn();
                myHp.TurnOff();
                myHp.AddProcessor(2);
            }
            Console.WriteLine(myHp);
        }
    }
}
