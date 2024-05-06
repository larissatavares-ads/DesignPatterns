namespace Behavioral_Mediator.Domain.Models
{
    class Component2 : BaseComponent
    {
        public void DoC()
        {
            Console.WriteLine("Component 1 does C.");

            this._mediator.Notify(this, "C");
        }

        public void DoD()
        {
            Console.WriteLine("Component 1 does D.");

            this._mediator.Notify(this, "D");
        }
    }
}
