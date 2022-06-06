using StringSearcherInterfaces;
using System;
using System.ServiceModel;

namespace StringSearcherClient
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var channel = new ChannelFactory<IStringSearcherService>("StringSearcherServiceEndpoint");
      var proxy = channel.CreateChannel();
      var res = proxy.FindSubStringInGivenStr("Something in the way...", "n the");
      Console.WriteLine($"Sunstring is *{res}*");
      Console.ReadLine();
    }
  }
}
