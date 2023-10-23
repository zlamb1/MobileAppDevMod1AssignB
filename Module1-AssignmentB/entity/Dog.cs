using Module1_AssignmentB.iface;

namespace Module1_AssignmentB.entity
{
    public class Dog : Pet, ITalkable
    {
        private bool friendly;

        public bool Friendly
        {
            get => friendly;
        }

        public Dog(bool friendly, String name) : base(name)
        {
            this.friendly = friendly;
        }

        public String Talk()
        {
            return "Bark";
        }

        public override String ToString()
        {
            return "Dog: " + "name=" + name + " friendly=" + friendly;
        }
    }
}
