using System.Text;

namespace Module1_AssignmentB.io
{
    public class FileOutput
    {
        private readonly string fileName;
        private StreamWriter fileWriter;

        public FileOutput(string fileName)
        {
            this.fileName = fileName;

        }

        public void FileOpen()
        {
            try
            {
                fileWriter = new StreamWriter(this.fileName);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        public void FileWrite(string line)
        {
            fileWriter.WriteLine(line);
        }

        public void FileClose()
        {
            try
            {
                fileWriter.Close();
            }
            catch (EncoderFallbackException exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
