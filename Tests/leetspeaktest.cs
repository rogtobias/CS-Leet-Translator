using Xunit;

namespace Language
{

  public class LeetSpeakTranslatorTest
  {
    [Fact]
    public void IsTaranslated_ForLetterLittleE_true()
    {
      // LeetSpeakTranslator testTranslate = new LeetSpeakTranslator();
      Assert.Equal(true, LeetSpeakTranslator.Translate("ear"));
    }

    [Fact]
    public void IsTaranslated_ForLetterLittleO_true()
    {
      // LeetSpeakTranslator testTranslate = new LeetSpeakTranslator();
      Assert.Equal(true, LeetSpeakTranslator.Translate("world"));
    }

    [Fact]
    public void IsTaranslated_ForLetterBigI_true()
    {
      // LeetSpeakTranslator testTranslate = new LeetSpeakTranslator();
      Assert.Equal(true, LeetSpeakTranslator.Translate("Ipad"));
    }

    [Fact]
    public void IsTaranslated_ForLetterLittleT_true()
    {
      // LeetSpeakTranslator testTranslate = new LeetSpeakTranslator();
      Assert.Equal(true, LeetSpeakTranslator.Translate("train"));
    }

    [Fact]
    public void IsTaranslated_ForLetterLittleS_true()
    {
      // LeetSpeakTranslator testTranslate = new LeetSpeakTranslator();
      Assert.Equal(true, LeetSpeakTranslator.Translate(" slam"));
    }
  }
}
