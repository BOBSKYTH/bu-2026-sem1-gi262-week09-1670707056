using System;
using System.Collections.Generic;

namespace Assignment
{
    public class StudentSolution
    {
        class Action
        {
            public string Name;
            public int Value;
        }

        #region Lecture

        // LCT01: Stack Syntax
        public (int Count, int Popped, int Peek, int CountAfterPeek) LCT01_StackSyntax()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            int count = stack.Count;
            int popped = stack.Pop();
            int peek = stack.Peek();
            int countAfterPeek = stack.Count;

            return (count, popped, peek, countAfterPeek);
        }

        // LCT02: Queue Syntax
        public (int Count, int Dequeued, int Peek, int CountAfterPeek) LCT02_QueueSyntax()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            int count = queue.Count;
            int dequeued = queue.Dequeue();
            int peek = queue.Peek();
            int countAfterPeek = queue.Count;

            return (count, dequeued, peek, countAfterPeek);
        }

        // LCT03: Action Stack
        public string[] LCT03_ActionStack()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };

            Stack<Action> stack = new Stack<Action>();

            stack.Push(action1);
            stack.Push(action2);
            stack.Push(action3);

            List<string> results = new List<string>();

            while (stack.Count > 0)
            {
                Action action = stack.Pop();
                results.Add(action.Name);
            }

            return results.ToArray();
        }

        // LCT04: Action Queue
        public string[] LCT04_ActionQueue()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };

            Queue<Action> queue = new Queue<Action>();

            queue.Enqueue(action1);
            queue.Enqueue(action2);
            queue.Enqueue(action3);

            List<string> results = new List<string>();

            while (queue.Count > 0)
            {
                Action action = queue.Dequeue();
                results.Add(action.Name);
            }

            return results.ToArray();
        }

        #endregion

        #region Assignment

        // ASN01: Reverse String
        public string ASN01_ReverseString(string str)
        {
            if (str == null) return null;

            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                stack.Push(c);
            }

            string result = "";

            while (stack.Count > 0)
            {
                result += stack.Pop();
            }

            return result;
        }

        // ASN02: Stack Palindrome
        public bool ASN02_StackPalindrome(string str)
        {
            if (str == null) return false;

            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                stack.Push(c);
            }

            foreach (char c in str)
            {
                if (c != stack.Pop())
                {
                    return false;
                }
            }

            return true;
        }

        #endregion

        #region Extra

        // EX01: Parentheses Checker
        public bool EX01_ParenthesesChecker(string str)
        {
            if (str == null) return false;

            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                // Opening brackets
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                // Closing brackets
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char open = stack.Pop();

                    if (c == ')' && open != '(') return false;
                    if (c == '}' && open != '{') return false;
                    if (c == ']' && open != '[') return false;
                }
            }

            return stack.Count == 0;
        }

        #endregion
    }
}