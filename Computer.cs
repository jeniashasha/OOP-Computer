using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
  
    class Computer
    {
        public string model;
        public int price;
        public int numberOfProcessors;
        public float screenSize;
        public bool isTurnOn = true;

        public int TellMeThePrice()
        {
            Console.WriteLine($"the price is {price}");
            return price;
        }
        public float TellMeTheScreenSize()
        {
            Console.WriteLine($"the screen size is {screenSize}");
            return screenSize;
        }
        public void TurnOn()
        {
            if (isTurnOn)
            {
                Console.WriteLine($"{model} is already on!");
            }
            else
            {
                isTurnOn = false;
                Console.WriteLine($"turning on {model}");
            }
        }
        public void TurnOff()
        {
            if (!isTurnOn)
            {
                Console.WriteLine($"{model} is turning off");
            }
        }
        public void AddProcessor(int processors)
        {
            numberOfProcessors = numberOfProcessors + processors;
            Console.WriteLine($"{model} has got {processors} new processors and now has got {numberOfProcessors}");
        }

        public override string ToString()
        {
            return $"Class Computer model = {model} number of processors = {numberOfProcessors} screen size = {screenSize}";
        }
    }
}
