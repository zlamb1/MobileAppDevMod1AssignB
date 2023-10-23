namespace Module1_AssignmentB.entity
{
    public abstract class Person
    {
        public String Name
        {
            get; set;
        }

        public Person(String name)
        {
            Name = name;
        }
    }
}
