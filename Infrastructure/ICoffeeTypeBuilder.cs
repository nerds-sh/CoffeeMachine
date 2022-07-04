
namespace Infrastructure {
    abstract class ICoffeeTypeBuilder {
        protected CoffeeType coffeeType = new CoffeeType();

        public CoffeeType getCoffeeType() {
            addWater();
            addMilk();
            addCoffee();

            return coffeeType;
        }

        protected abstract void addWater();
        protected abstract void addMilk();
        protected abstract void addCoffee();
    }
}