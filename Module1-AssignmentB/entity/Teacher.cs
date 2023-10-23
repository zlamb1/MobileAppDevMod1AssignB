using System.Xml.Linq;

namespace Module1_AssignmentB.entity
{
    public class Teacher : Person, iface.ITalkable
    {        
        public int Age
        {
            get; set;
        }

        public Teacher(int age, String name) : base(name)
        {
            Age = age;
        }

        public String Talk()
        {
            return "Don't forget to do the assigned reading!";
        }

        public override string ToString()
        {
            return "Teacher: " + "name=" + Name + " age=" + Age;
        }
    }
}
