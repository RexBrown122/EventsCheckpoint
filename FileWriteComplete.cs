using System;

namespace EventCheckpoint
{
  public class FileWriteComplete : EventArgs
  {
    public string Message { get; set; }

    public FileWriteComplete(string message)
    {
      Message = message;
    }

    public void complete(string message)
    {

    }
  }
}