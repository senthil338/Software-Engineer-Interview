using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.GeeksForGeeks
{
    class RemoveInvalidParentheses
    {
        private HashSet<String> validExpressions = new HashSet<String>();

        private void recurse(String s, int index, int leftCount, int rightCount, int leftRem,  int rightRem,
            StringBuilder expression)
        {

            // If we reached the end of the string, just check if the resulting expression is
            // valid or not and also if we have removed the total number of left and right
            // parentheses that we should have removed.
            if (index == s.Length)
            {
                if (leftRem == 0 && rightRem == 0)
                    this.validExpressions.Add(expression.ToString());
            }
            else
            {
                char character = s[index];
                int length = expression.Length;
                // The discard case. Note that here we have our pruning condition.
                // We don't recurse if the remaining count for that parenthesis is == 0.
                if ((character == '(' && leftRem > 0) || (character == ')' && rightRem > 0))
                {
                    this.recurse(s, index + 1,
                        leftCount,
                        rightCount,
                        leftRem - (character == '(' ? 1 : 0),
                        rightRem - (character == ')' ? 1 : 0),
                        expression);
                }

                expression.Append(character);

                // Simply recurse one step further if the current character is not a parenthesis.
                if (character != '(' && character != ')')
                    this.recurse(s, index + 1, leftCount, rightCount, leftRem, rightRem, expression);
                else if (character == '(')
                    // Consider an opening bracket.
                    this.recurse(s, index + 1, leftCount + 1, rightCount, leftRem, rightRem, expression);
                else if (rightCount < leftCount)
                    // Consider a closing bracket.
                    this.recurse(s, index + 1, leftCount, rightCount + 1, leftRem, rightRem, expression);
                // Delete for backtracking.
                expression.Clear().Append(expression.ToString().Remove(length));
            }
        }

        public List<String> removeInvalidParentheses(String s)
        {

            int left = 0, right = 0;
            // First, we find out the number of misplaced left and right parentheses.
            for (int i = 0; i < s.Length; i++)
            {
                // Simply record the left one.
                if (s[i] == '(')
                       left++;
                else if (s[i] == ')')
                {
                    // If we don't have a matching left, then this is a misplaced right, record it.
                    right = left == 0 ? right + 1 : right;

                    // Decrement count of left parentheses because we have found a right
                    // which CAN be a matching one for a left.
                    left = left > 0 ? left - 1 : left;
                }
            }
            this.recurse(s, 0, 0, 0, left, right, new StringBuilder());
            return new List<String>(this.validExpressions);
        }
    }
}

