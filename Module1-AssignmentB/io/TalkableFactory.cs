using Module1_AssignmentB.entity;
using Module1_AssignmentB.iface;

namespace Module1_AssignmentB.io
{
    public class TalkableFactory
    {
        private static int MAX_REPEAT_ATTEMPTS = 10;
        
        private bool ParseBool(string? prompt)
        {
            if (prompt != null)
            {
                Console.Write(prompt); 
            }

            string? val = Console.ReadLine();
            switch (val?.ToLower())
            {
                case "true":
                    return true;
                case "false":
                    return false;
                case "1":
                    return true;
                case "0":
                    return false;
                default:
                    return false;
            }
        }

        private (bool, int) ParseIntHandleErr(string? prompt, bool repeat = true, string nullMsg = "You must enter a number!", string formatMsg = "You must enter a number!", int attempt = 0)
        {
            if (prompt != null)
            {
                Console.Write(prompt);
            }

            string? val = Console.ReadLine();

            try
            {
                return (true, Int32.Parse(val));
            } catch (ArgumentNullException)
            {
                Console.WriteLine(nullMsg);
            } catch (FormatException)
            {
                Console.WriteLine(formatMsg);
            } catch (OverflowException)
            {
                // don't need to handle
            }
            
            if (repeat)
            {
                if (attempt < MAX_REPEAT_ATTEMPTS)
                {
                    return ParseIntHandleErr(prompt, repeat, nullMsg, formatMsg, ++attempt);
                }
                else
                {
                    Console.WriteLine("Exceeded max entry attempts.");
                }
            }

            return (false, 0);
        }

        public ITalkable AddTalkable()
        {
            while (true)
            {
                Console.WriteLine("[Teacher, Cat, Dog]");
                Console.Write("Which type of thing would you like to create? ");

                string? type = Console.ReadLine();
                
                switch (type?.ToLower())
                {
                    case "teacher":
                        break;
                    case "cat":
                        break;
                    case "dog":
                        break;
                    default:
                        Console.WriteLine("The type must be [Teacher, Cat, Dog]");
                        continue;
                }

                Console.Write($"What is the name of the {type?.ToLower()}? ");
                string? name = Console.ReadLine();

                if (name == null)
                {
                    Console.WriteLine("The name cannot be null!");
                    continue;
                }

                switch (type?.ToLower())
                {
                    case "teacher":
                        (bool, int) age = ParseIntHandleErr("What is the teacher's age? ");
                        if (!age.Item1)
                        {
                            continue;
                        }
                        return new Teacher(age.Item2, name);
                    case "cat":
                        (bool, int) mousesKilled = ParseIntHandleErr("How many mouses has the cat killed? ");
                        if (!mousesKilled.Item1)
                        {
                            continue;
                        }
                        return new Cat(mousesKilled.Item2, name);
                    case "dog":
                        return new Dog(ParseBool("Is the dog friendly? "), name); 
                }
            }
        }

        public void DeleteTalkable(List<ITalkable> list)
        {            
            if (list.Count == 0)
            {
                Console.WriteLine("The list is empty you cannot delete any!"); 
                return;
            }

            ListTalkables(list);

            (bool, int) ret = ParseIntHandleErr("Which entry do you want to delete? ");

            if (!ret.Item1)
            {
                return;
            }

            int index = ret.Item2 - 1; 
            if (index < 0)
            {
                Console.WriteLine("Cannot delete a negative entry!");
                return; 
            }

            if (index >= list.Count)
            {
                Console.WriteLine("You entered an entry that is greater than the list size!");
                return;
            }

            ITalkable talkable = list[index];
            list.RemoveAt(index);

            Console.WriteLine($"You deleted entry #{ret.Item2}: {talkable}");
        }

        public void ListTalkables(List<ITalkable> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("The list is empty.");
                return; 
            }

            Console.WriteLine("Zoo List => ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {list[i].ToString()}");
            }
        }

        public List<ITalkable> GetTalkablesFromUser()
        {
            List<ITalkable> list = new List<ITalkable>();

            while (true)
            {
                Console.WriteLine("[Add, Delete, List, Submit]");
                Console.Write("What action would you like to do? ");
                string? action = Console.ReadLine();

                switch (action?.ToLower())
                {
                    case "add":
                        list.Add(AddTalkable());
                        break;
                    case "delete":
                        DeleteTalkable(list);
                        break;
                    case "list":
                        ListTalkables(list);
                        break;
                    default:
                        return list;
                }
            }
        }
    }
}
