namespace Behavioral_Mediator.Interfaces
{
    public interface IMediator
    {
        void Notify(object sender, string events);
    }
}
