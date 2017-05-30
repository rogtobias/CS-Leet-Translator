using System;
using System.Collections.Generic;

namespace Language
{
  public class LeetSpeakTranslator
  {
    public static Char[] userArray;
    public static List<string> userChars = new List<string> {};
    public static List<string> newList = new List<string> {};

    public static bool Translate(string userSentence)
    {
      userArray = userSentence.ToCharArray();
      for(int i = 0; i < userArray.Length; i++)
      {
        string element = userArray[i].ToString();
        userChars.Add(element);
      }

      for (int i = 0; i < userChars.Count; i++)
      {
        if (userChars[i] == "e")
        {
          //replace with 3
          userChars[i] = "3";
          newList.Add(userChars[i]);

        }
        else if (userChars[i] == "o")
        {
          //replace with 0
          userChars[i] = "0";
          newList.Add(userChars[i]);

        }
        else if (userChars[i] == "I")
        {
          //replace with 1
          userChars[i] = "1";
          newList.Add(userChars[i]);

        }
        else if (userChars[i] == "t")
        {
          //replace with 7
          userChars[i] = "7";
          newList.Add(userChars[i]);
        }
        else if (userChars[i] == "s" && userChars[i-1] == " ")
        {
          //replace with z
          userChars[i] = "z";
          newList.Add(userChars[i]);

        }
        else
        {
          newList.Add(userChars[i]);
        }
      }
      return false;
    }

    public static string Convert()
    {
      string[] resultArray = newList.ToArray();
      string resultSentence = string.Join("", resultArray);
      return resultSentence;
    }
  }
}
