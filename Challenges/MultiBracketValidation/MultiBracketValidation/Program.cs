﻿using System;
using StacksAndQueues.Classes;

namespace MultiBracketValidation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string test1 = "(Vampire)";
            string test2 = "[Werewolf]";
            string test3 = "{Ghoul}";
            string test4 = "({[Dracolisk)";
            string test5 = "({Cemetaur)}";

            Console.WriteLine($"Test 1 expected to Pass: {test1}");
            Console.WriteLine(MultiBracketValidationMethod(test1));
            Console.WriteLine($"Test 2 expected to Pass: {test2}");
            Console.WriteLine(MultiBracketValidationMethod(test2));
            Console.WriteLine($"Test 3 expected to Pass: {test3}");
            Console.WriteLine(MultiBracketValidationMethod(test3));
            Console.WriteLine($"Test 4 expected to Fail: {test4}");
            Console.WriteLine(MultiBracketValidationMethod(test4));
            Console.WriteLine($"Test 5 expected to Fail: {test5}");
            Console.WriteLine(MultiBracketValidationMethod(test5));
        }

        /// <summary>
        /// This method takes in a string and determines if there is are pairs of brackets, curlies, and parans
        /// </summary>
        /// <param name="value">Takes in a string</param>
        /// <returns>Returns true if there are pairs and false if there aren't</returns>
        public static bool MultiBracketValidationMethod(string value)
        {
            Stack BCP = new Stack(null);
            Node bracket = new Node("]");
            Node curly = new Node("}");
            Node paran = new Node(")");

            for (int i = 0; i < value.Length; i++)
            {
                if (value[i].ToString() == "[")
                    BCP.Push(bracket);
                if (value[i].ToString() == "{")
                    BCP.Push(curly);
                if (value[i].ToString() == "(")
                    BCP.Push(paran);

                try
                {
                    if (value[i].ToString() == "]" && (string)BCP.Peek().Value != "]")
                        return false;
                    else if (value[i].ToString() == "]" && (string)BCP.Peek().Value == "]")
                        BCP.Pop();
                    if (value[i].ToString() == "}" && (string)BCP.Peek().Value != "}")
                        return false;
                    else if (value[i].ToString() == "}" && (string)BCP.Peek().Value == "}")
                        BCP.Pop();
                    if (value[i].ToString() == ")" && (string)BCP.Peek().Value != ")")
                        return false;
                    else if (value[i].ToString() == ")" && (string)BCP.Peek().Value == ")")
                        BCP.Pop();
                }
                catch
                {
                    return false;
                }
            }
            if (BCP.Top == null)
                return true;
            else
                return false;
        }
    }
}
