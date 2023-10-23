using Module1_AssignmentB.iface;

namespace Module1_AssignmentB.entity
{
    public class Cat : Pet, ITalkable
    {        
        public int MousesKilled
        {
            get; set;
        }

        public Cat(int mousesKilled, String name) : base(name)
        {
            MousesKilled = mousesKilled;
        }

        public String Talk()
        {
            return "Meow";
        }

        public override String ToString()
        {
            return "Cat: " + "name=" + Name + " mousesKilled=" + MousesKilled;
        }
    }
}
