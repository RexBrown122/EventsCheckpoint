using System;

namespace EventCheckpoint
{
  public class DisplayService
  {
    // display string to console
    // display "File Write Completed" when it received event
    public DisplayService(FileWriter pub) => pub.FileCompleteEvent += sendMessage;

    public void sendMessage(object sender, FileWriteComplete e)
    {
      Console.WriteLine($"Wrote: \"{e.Message}\", File Write Completed");
    }
  }
}