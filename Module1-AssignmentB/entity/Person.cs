namespace Module1_AssignmentB.entity
{
    public abstract class Person
    {
        private String name;

        public String Name
        {
            get => name;
            set => name = value;
        }

        public Person(String name)
        {
            this.name = name;
        }
    }
}
