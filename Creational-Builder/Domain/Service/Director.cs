using Creational_Builder.Interfaces;

namespace Creational_Builder.Domain.Service
{
    public class Director
    {
        private IBuilderHouse _builder;

        public IBuilderHouse Builder
        {
            set { _builder = value; }
        }

        public void BuildMinimalHouse()
        {
            this._builder.BuildWall();
        }

        public void BuildCompleteHouse()
        {
            this._builder.BuildWall();
            this._builder.BuildDoor();
            this._builder.BuildWindow();
        }
    }
}
