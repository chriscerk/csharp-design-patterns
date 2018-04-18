using System.Collections.Generic;

namespace csharp_design_patterns
{
    public class Teacher : ISubject
    {
        private List<IObserver> _students;
        private object _state;
        
        public Teacher(object o)
        {
            _students = new List<IObserver>();
            _state = o;
        }

        public void Attach(IObserver o)
        {
            if(o.GetSubject() != null)
                _students.Add(o);
            else
                o.Observe(this);
        }

        public void Attach(List<Student> students)
        {
            students.ForEach(o => Attach(o));
        }

        public void Detach(IObserver s)
        {
            _students.Remove(s);
        }

        public object GetState()
        {
            return _state;
        }

        public void Notify(IEvent e)
        {
            _students.ForEach(s => s.OnNotify(e));
        }

        public void UpdateName(object o)
        {
            _state = o;
            var e = new TeacherUpdatedEvent("Name");
            Notify(e);
        }
    }
}