using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AytuvorovTK.Sprint3.Task3.V23.Lib
{
    public class DataService : ISprint3Task3V23
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            char[] chars = value.ToCharArray();

            foreach (char c in chars)
            {
                if (c == replaceable)
                {
                    for (int i = 0; i < chars.Length; i++)
                    {
                        if (chars[i] == replaceable)
                        {
                            chars[i] = replacement;
                        }
                    }
                    break; 
                }
            }

            return new string(chars);
        }
    }
}
