using System;

namespace EventCheckpoint
{
  class Program
  {
    static void Main(string[] args)
    {
      string str = "New Line of Text";
      string file = "text.txt";
      var FileWriter = new FileWriter();
      // var display = new DisplayService(file);
      FileWriter.appendString(str, file);


      //   MessageDelegate messageHandler = MessageMethod;
      //   messageHandler("cascascascs", "text.txt");
    }
  }
}
