namespace Module1_AssignmentB.entity
{
    public abstract class Pet
    {        
        public String Name
        {
            get; set;
        }

        public Pet(String name)
        {
            Name = name; 
        }
    }
}
