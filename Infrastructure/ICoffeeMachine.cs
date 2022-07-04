
namespace Infrastructure {
    interface ICoffeeMachine {
        protected bool ValidateSensors();
        public void StartMachine();
        public void Select(string coffeeName);
        public void MakeCoffee();
    }
}