using System.IO;

namespace EventCheckpoint
{
    public class FileWriter
    {
        public FileWriter()
        {

        }

        public void appendString()
        {
            StreamWriter file = new("Text.txt", append: true);
            file.WriteLine("New Line of Text");
        }

        public void onRaiseFileWriteCompleteEvent(FileWriteComplete e)
        {
            
        }
    }
}