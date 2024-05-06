using Behavioral_Mediator.Domain.Models;
using Behavioral_Mediator.Interfaces;

namespace Behavioral_Mediator.Domain
{
    class ConcreteMediator : IMediator
    {
        private Component1 _component1;
        private Component2 _component2;

        public ConcreteMediator(Component1 component1, Component2 component2)
        {
            _component1 = component1;
            this._component1.SetMediator(this);

            _component2 = component2;
            this._component2.SetMediator(this);
        }

        public void Notify(object sender, string events)
        {
            if (events == "A")
            {
                Console.WriteLine("Mediator reacts on A and triggers following operations:");
                this._component2.DoC();
            }
            if (events == "D") 
            {
                Console.WriteLine("Mediator reacts on D and triggers following operations:");
                this._component1.DoB();
                this._component2.DoC();
            }
        }
    }
}
