using Module1_AssignmentB.iface;

namespace Module1_AssignmentB.entity
{
    public class Dog : Pet, ITalkable
    {
        public bool Friendly
        {
            get; set;
        }

        public Dog(bool friendly, String name) : base(name)
        {
            Friendly = friendly;
        }

        public String Talk()
        {
            return "Bark";
        }

        public override String ToString()
        {
            return "Dog: " + "name=" + Name + " friendly=" + Friendly;
        }
    }
}
