using StringSearcherInterfaces;

namespace StringSearcherServer
{
  public class StringSearcherService : IStringSearcherService
  {
    public string FindSubStringInGivenStr(string str, string substring)
    {
      return str.Contains(substring) ? substring : "Substring not found!";
    }
  }
}
