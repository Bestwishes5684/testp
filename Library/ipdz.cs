namespace Library
{
    public class ipdz   
    {
        private List<Student> nuget = new List<Student>();

        public ipdz() { }
        public void Add(Student argument)
        {
            nuget.Add(argument);
        }
        public void Remove(Student argument)
        {
            nuget.Remove(argument);
        }
        public void Change(Student id, Student arg)
        {
            var index = nuget.IndexOf(id);
            nuget[index] = arg;
        }
        public List<Student> Get()
        {
            return nuget;
        }
    }
}