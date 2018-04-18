namespace csharp_design_patterns
{
    public interface IObserver
    {
        ISubject GetSubject();
        void OnNotify(IEvent e);
        void Observe(ISubject s);
        void Detach();
    }
}