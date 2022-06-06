using System;
using System.ServiceModel;

namespace StringSearcherServer
{
  class Program
  {
    public static void Main(string[] args)
    {
      using (var host = new ServiceHost(typeof(StringSearcherService)))
      {
        host.Open();
        Console.WriteLine("Server was started");
        Console.WriteLine("Press <Enter> to close the servier");
        Console.ReadLine();
      }
    }
  }
}
