using Creational_Builder.Domain.Model;
using Creational_Builder.Interfaces;

namespace Creational_Builder.Domain.Service
{
    public class ConcreteBuilderHouse : IBuilderHouse
    {
        private House _house = new House();

        public ConcreteBuilderHouse()
        {
            this.Reset();
        }

        public void Reset() 
        {
            this._house = new House();
        }

        public void BuildWall()
        {
            this._house.Add("Wall");
        }

        public void BuildDoor()
        {
            this._house.Add("Door");
        }

        public void BuildWindow()
        {
            this._house.Add("Window");
        }

        // resetar para dar espaço para uma nova criação
        public House GetHouse()
        {
            House result = this._house;

            this.Reset();

            return result;
        }
    }
}
