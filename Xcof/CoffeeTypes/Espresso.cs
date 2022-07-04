
using Infrastructure;

namespace Xcof.CoffeeTypes {
    class EspressoBuilder : ICoffeeTypeBuilder
    {
        public EspressoBuilder() {
            coffeeType.name = "Espresso";
        }

        protected override void addCoffee() {
            coffeeType.coffeeAmount = 50;
        }

        protected override void addMilk() {
            coffeeType.milkAmount = 0;
        }

        protected override void addWater() {
            coffeeType.waterAmount = 10;
        }
    }
}
