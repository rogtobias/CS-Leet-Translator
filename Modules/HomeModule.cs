using Nancy;
using Language;

namespace Translator
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _=>
      {
        return View["index.cshtml"];
      };
      Post["/output"] = _=>
      {
        LeetSpeakTranslator.Translate(Request.Form["userSentence"]);
        string final = LeetSpeakTranslator.Convert();
        return View["form-confirm.cshtml", final];
      };
    }
  }
}
