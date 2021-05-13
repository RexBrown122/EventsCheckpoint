using System;
using System.IO;
using System.Threading.Tasks;

namespace EventCheckpoint
{
  public class FileWriter
  {
    public event EventHandler<FileWriteComplete> FileCompleteEvent;
    public FileWriter() { }

    public static async Task appendString(string str, string txtfile)
    {
      using StreamWriter file = new(txtfile, append: true);
      await file.WriteLineAsync(str);
      FileWriteComplete resultEvent = new FileWriteComplete(str);
      resultEvent.complete(str);

    }

    // public void onRaiseFileWriteCompleteEvent(FileWriteComplete e)
    // { }
    public delegate void MessageDelegate(string message, string textFileName);

    public static void MessageMethod(string message, string textFileName)
    {
      FileWriter asd = new FileWriter();
      Console.WriteLine("hi: " + message);
    }
  }
}