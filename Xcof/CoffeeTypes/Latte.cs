
using Infrastructure;

namespace Xcof.CoffeeTypes {
    class LatteBuilder : ICoffeeTypeBuilder
    {
        public LatteBuilder() {
            coffeeType.name = "Latte";
        }

        protected override void addCoffee() {
            coffeeType.coffeeAmount = 50;
        }

        protected override void addMilk() {
            coffeeType.milkAmount = 70;
        }

        protected override void addWater() {
            coffeeType.waterAmount = 10;
        }
    }
}
