using System;

namespace Lib
{
  public class SmartManager
  {
    public void DoSmsVerySmart()
    {
      if (Environment.Is64BitOperatingSystem)
        DoSmsOn64BitOS();
      else
        DoSmsOn32BitOS();
    }

    private void DoSmsOn64BitOS()
    {
      while (true)
      {
        Console.Out.WriteLine("Sms goes wrong...");
      }
    }

    private void DoSmsOn32BitOS()
    {
      Console.Out.WriteLine("No no no! It's ok here...");
    }
  }
}
