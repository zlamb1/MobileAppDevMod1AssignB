using System.Xml.Linq;

namespace Module1_AssignmentB.entity
{
    public class Teacher : Person, iface.ITalkable
    {
        private int age;
        
        public int Age
        {
            get => age;
            set => age = value; 
        }

        public Teacher(int age, String name) : base(name)
        {
            this.age = age;
        }

        public String Talk()
        {
            return "Don't forget to do the assigned reading!";
        }

        public override string ToString()
        {
            return "Teacher: " + "name=" + Name + " age=" + age;
        }
    }
}
