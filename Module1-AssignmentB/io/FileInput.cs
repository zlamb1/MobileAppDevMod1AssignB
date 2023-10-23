namespace Module1_AssignmentB.io
{
    public class FileInput
    {
        private readonly string fileName;
        private StreamReader fileReader;

        public FileInput(string fileName)
        {
            this.fileName = fileName;
        }

        public void FileOpen()
        {
            try
            {
                fileReader = new StreamReader(fileName);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        public void FileRead()
        {
            try
            {
                String? line = fileReader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = fileReader.ReadLine();
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string? FileReadLine()
        {
            try
            {
                return fileReader.ReadLine();
            } catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            return null;
        }

        public void FileClose()
        {
            fileReader.Close();
        }
    }
}
