using System;

namespace EventCheckpoint
{
  public class DisplayService
  {
    public DisplayService(FileWriter pub) => pub.FileCompleteEvent += sendMessage;

    public void sendMessage(object sender, FileWriteComplete args)
    {
      Console.WriteLine($"Wrote: \"{args.Message}\", File Write Completed");
    }
  }
}