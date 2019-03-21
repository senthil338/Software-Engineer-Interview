using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    public class OpenCloseSymbolsCheck
    {
        public static bool checkOpenClose()
        {
            string str = "{[[(())]}}}";
            bool flag = true;
            bool result = true; ;
            while (flag)
            {
                if (str.Length > 0)
                {
                    switch (str[0])
                    {
                        case '{':
                            {
                                if (str[str.Length - 1] == '}')
                                {
                                    str = str.Remove(0, 1);
                                    str = str.Remove(str.Length - 1, 1);

                                }
                                else
                                {
                                    result = false;
                                    return false;
                                }
                                break;
                            }
                        case '[':
                            {
                                if (str[str.Length - 1] == ']')
                                {
                                    str = str.Remove(0, 1);
                                    str = str.Remove(str.Length - 1, 1);
                                }
                                else
                                {
                                    result = false;
                                    return false;
                                }
                                break;
                            }
                        case '(':
                            {
                                if (str[str.Length - 1] == ')')
                                {
                                    str = str.Remove(0, 1);
                                    str = str.Remove(str.Length - 1, 1);
                                }
                                else
                                {
                                    result = false;
                                    return false;
                                }
                                break;
                            }
                        default:
                            {
                                return true;
                            }
                    }
                }
                else
                {
                    flag = false;
                }
                //return false;
            }
            return result;

        }
    }
}
