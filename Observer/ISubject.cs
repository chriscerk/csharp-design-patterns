namespace csharp_design_patterns
{
    public interface ISubject
    {
         void Attach(IObserver o);
         void Detach(IObserver o);
         void Notify(IEvent e);
         object GetState();
    }
}