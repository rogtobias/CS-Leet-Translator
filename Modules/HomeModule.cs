using Nancy;

namespace Translator
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get[""] = _=>
      {
        
      }
    }
  }
}
