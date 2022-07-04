
using Infrastructure;

namespace Xcof {
    class CoffeeMachine : ICoffeeMachine {
        List<ISensor> senzori = new List<ISensor>();
        ICoffeeTypeBuilder coffeeBuilder = null;

        public CoffeeMachine() {
            senzori.Add(new Sensors.WaterSensor());
            senzori.Add(new Sensors.MilkSensor());
            senzori.Add(new Sensors.CoffeeSensor());
        }

        public bool ValidateSensors() {
            foreach(ISensor s in senzori) {
                if(!s.Check())
                    return false;
            }

            return true;
        }

        public void StartMachine() {
            ValidateSensors();
        }

        public void Select(string coffeeName) {
            switch(coffeeName) {
                case "Espresso":
                    this.coffeeBuilder = new CoffeeTypes.EspressoBuilder();
                    break;
                case "Latte":
                    this.coffeeBuilder = new CoffeeTypes.LatteBuilder();
                    break;
                default:
                    throw new Exception("Not a Xcof coffee type.");
            }
        }
        
        public void MakeCoffee() {
            CoffeeType kafeaua = coffeeBuilder.getCoffeeType();
            //fa kafeaua
        }
    }
}