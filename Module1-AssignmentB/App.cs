using Module1_AssignmentB.entity;
using Module1_AssignmentB.iface;
using Module1_AssignmentB.io;

internal class App
{
    private static readonly FileInput inFile = new FileInput("animals.txt");
    private static readonly FileOutput outFile = new FileOutput("animals.txt");

    private static readonly TalkableFactory talkableFactory = new TalkableFactory();

    public static void Main(String[] args)
    {
        List<ITalkable> zoo = talkableFactory.GetTalkablesFromUser();

        outFile.FileOpen(); 

        foreach (ITalkable thing in zoo)
        {
            PrintOut(thing);
        }

        outFile.FileClose();

        inFile.FileOpen();
        inFile.FileRead();
        inFile.FileClose();

        FileInput inData = new FileInput("animals.txt");
        inData.FileOpen(); 
        string? line;
        while ((line = inData.FileReadLine()) != null)
        {
            Console.WriteLine(line);
        }

        inData.FileClose(); 
    }

    public static void PrintOut(ITalkable p)
    {
        Console.WriteLine(p.Name + " says=" + p.Talk());
        outFile.FileWrite(p.Name + " | " + p.Talk());
    }
}