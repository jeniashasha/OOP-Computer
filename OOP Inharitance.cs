abstract class Vehicle
    {
        public int _numberOfWheels;
        public string _model;
        public int _maxNumOfPassengers;
        public int _maxSpeed;
    
        public  void PrintNumberOfWheels()
        {
        Console.WriteLine($"The vehicle has {_numberOfWheels}");
        }
        public  void PrintModel()
        {
            Console.WriteLine($"The model is {_model}");
        }
        public abstract void GetMaxNumOfPassengers();
        public abstract void GetMaxSpeed();

        public override string ToString()
        {
            return $"[Vehicle]: model: {_model} number of wheels: {_numberOfWheels} max number of passengers: {_maxNumOfPassengers} max speed: {_maxSpeed}";
        }
    }
}
Car c = new Car();


        public int _numberOfDoors;
        public override void GetMaxNumOfPassengers()
        {
            Console.WriteLine($"maximum number of passengers: {_maxNumOfPassengers}");
        }
        public override void GetMaxSpeed()
        {
            Console.WriteLine($"maximum speed: {_maxSpeed}");
        }
        public void GetNumberOfDoors()
        {
            Console.WriteLine($"number of doors is {_numberOfDoors}");
        }
        public override string ToString()
        {
            return $"Car: number of doors: {_numberOfDoors}" + base.ToString();



        }
    }

}
Motorcycle m = new Motorcycle();


        public int _numberOfHandBrakes;
        public override void GetMaxNumOfPassengers()
        {
            Console.WriteLine($"maximum number of passengers: {_maxNumOfPassengers}");
        }
        public override void GetMaxSpeed()
        {
            Console.WriteLine($"maximum speed: {_maxSpeed}");
        }




        public override string ToString()
        {
            return $"Motorcycle: number of hand brakes: {_numberOfHandBrakes}" + base.ToString();
        }
    }
}
   Car toyota = new Car()
            {
                _numberOfWheels = 4,
                _model = "Corolla",
                _maxNumOfPassengers = 5,
                _maxSpeed = 180,
                _numberOfDoors = 4
            };
            Console.WriteLine(toyota);
            toyota.PrintNumberOfWheels();
            toyota.PrintModel();
            toyota.GetMaxNumOfPassengers();
            toyota.GetMaxSpeed();
            toyota.GetNumberOfDoors();
        }
           
        
        public override string ToString()
        {
            return $"Car: toyota:" +  base.ToString();
            {

            }


        }
    }
}
