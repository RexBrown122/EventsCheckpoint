using System;
using System.IO;
using System.Threading.Tasks;

namespace EventCheckpoint
{
  public class FileWriter
  {
    public event EventHandler<FileWriteComplete> FileCompleteEvent;
    public FileWriter() { }

    public void appendString(string str, string txtfile)
    {
      using StreamWriter file = new(txtfile, append: true);
      file.WriteLine(str);
      onRaiseFileWriteCompleteEvent(new FileWriteComplete(str));
    }

    protected virtual void onRaiseFileWriteCompleteEvent(FileWriteComplete message)
    {
      EventHandler<FileWriteComplete> raiseEvent = FileCompleteEvent;
      raiseEvent(this, message);
    }
  }
}