namespace csharp_design_patterns
{
    public class TeacherUpdatedEvent : IEvent
    {
        private object _value;

        public TeacherUpdatedEvent(object o)
        {
            _value = o;
        }

        public object GetValue()
        {
            return _value;
        }
    }
}