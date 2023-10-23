namespace Module1_AssignmentB.entity
{
    public abstract class Pet
    {
        protected String name;
        
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Pet(String name)
        {
            this.name = name; 
        }
    }
}
