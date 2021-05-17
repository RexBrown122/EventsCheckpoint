namespace EventCheckpoint
{
  class Program
  {
    static void Main(string[] args)
    {
      string str = "New Line of Text";
      string file = "text.txt";
      var FileWriter = new FileWriter();
      var display = new DisplayService(FileWriter);
      // var display2 = new DisplayService(FileWriter);
      FileWriter.appendString(str, file);
    }
  }
}