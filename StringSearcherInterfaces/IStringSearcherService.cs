using System.ServiceModel;

namespace StringSearcherInterfaces
{
  [ServiceContract]
  public interface IStringSearcherService
  {
    [OperationContract]
    string FindSubStringInGivenStr(string str, string substring);
  }
}
