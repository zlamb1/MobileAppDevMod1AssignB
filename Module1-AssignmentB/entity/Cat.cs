using Module1_AssignmentB.iface;

namespace Module1_AssignmentB.entity
{
    public class Cat : Pet, ITalkable
    {
        private int mousesKilled;
        
        public int MousesKilled
        {
            get => mousesKilled;
            set => mousesKilled = value;
        }

        public Cat(int mousesKilled, String name) : base(name)
        {
            this.mousesKilled = mousesKilled;
        }

        public String Talk()
        {
            return "Meow";
        }

        public override String ToString()
        {
            return "Cat: " + "name=" + name + " mousesKilled=" + mousesKilled;
        }
    }
}
