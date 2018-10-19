using System;
using LinkedList.Classes;

namespace LL_Palindrome
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Node node1 = new Node("R");
            Node node2 = new Node("A");
            Node node3 = new Node("C");
            Node node4 = new Node("E");
            Node node5 = new Node("C");
            Node node6 = new Node("A");
            Node node7 = new Node("R");

            LL LL1 = new LL(node1);

            LL1.Append(node2);
            LL1.Append(node3);
            LL1.Append(node4);
            LL1.Append(node5);
            LL1.Append(node6);
            LL1.Append(node7);

            Node node8 = new Node("H");
            Node node9 = new Node("A");
            Node node10 = new Node("N");
            Node node11 = new Node("N");
            Node node12 = new Node("A");
            Node node13 = new Node("H");

            LL LL2 = new LL(node8);

            LL2.Append(node9);
            LL2.Append(node10);
            LL2.Append(node11);
            LL2.Append(node12);
            LL2.Append(node13);

            Console.WriteLine(PalindromeChecker(LL1));
            Console.WriteLine(PalindromeChecker(LL2));
        }

        public static bool PalindromeChecker(LL LL)
        {
            LL.Current = LL.Head;
            bool isPalindrome = true;
            int counter = 0;
            while (LL.Current != null)
            {
                counter++;
                LL.Current = LL.Current.Next;
            }
            string[] letters = new string[counter];
            LL.Current = LL.Head;
            int i = 0;
            while (LL.Current != null)
            {
                letters[i] = LL.Current.Value.ToString();
                i++;
                LL.Current = LL.Current.Next;
            }
            for (i = 0; i < letters.Length / 2; i++)
            {
                if (letters[i] != letters[letters.Length - 1 - i])
                {
                    isPalindrome = false;
                }
            }
            return isPalindrome;
        }
    }
}
