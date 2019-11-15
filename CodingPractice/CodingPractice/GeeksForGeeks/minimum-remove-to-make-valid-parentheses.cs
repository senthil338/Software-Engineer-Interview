using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.GeeksForGeeks
{
    class minimum_remove_to_make_valid_parentheses
    {
        public String minRemoveToMakeValid(String s)
        {
            Stack<int> st = new Stack<int>();
            StringBuilder sb = new StringBuilder();
            int i = 0;
            foreach(char c in s.ToCharArray())
            {
                if (c == '(' || c == ')')
                {
                    if (st.Count==0)
                    {
                        st.Push(i);
                    }
                    else
                    {
                        if (c == ')' && s[st.Peek()] == '(')
                        {
                            st.Pop();
                        }
                        else
                        {
                            st.Push(i);
                        }
                    }
                }
                i++;
            }
            sb.Append(s);
            string str = sb.ToString();
            while (st.Count!=0)
            {
                int t = st.Pop();
                str = str.Remove(t);
            }
            return str;
        }
    }
}
