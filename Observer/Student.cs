using System;

namespace csharp_design_patterns
{
    public class Student : IObserver
    {
        private ISubject _subject;
        public string Name;

        public Student(string name)
        {
            Name = name;
        }

        public void Observe(ISubject s)
        {
            _subject = s;
            _subject.Attach(this);
        }

        public void Detach()
        {
            _subject.Detach(this);
            _subject = null;
        }

        public ISubject GetSubject()
        {
            return _subject;
        }

        public void OnNotify(IEvent e)
        {
            var message = new String[]
            {
                Name,
                "'s teacher's ",
                e.GetValue().ToString(),
                " updated to ",
                _subject.GetState().ToString()
            };
            Console.WriteLine(String.Concat(message));
        }
    }
}