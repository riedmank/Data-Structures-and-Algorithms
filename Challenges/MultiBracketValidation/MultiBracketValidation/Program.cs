using System;

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

            Console.WriteLine($"Test 1 expected to Pass: {test1}");
            Console.WriteLine(MultiBracketValidationMethod(test1));
            Console.WriteLine($"Test 2 expected to Pass: {test2}");
            Console.WriteLine(MultiBracketValidationMethod(test2));
            Console.WriteLine($"Test 3 expected to Pass: {test3}");
            Console.WriteLine(MultiBracketValidationMethod(test3));
            Console.WriteLine($"Test 4 expected to Fail: {test4}");
            Console.WriteLine(MultiBracketValidationMethod(test4));
        }

        /// <summary>
        /// This method takes in a string and determines if there is are pairs of brackets, curlies, and parans
        /// </summary>
        /// <param name="value">Takes in a string</param>
        /// <returns>Returns true if there are pairs and false if there aren't</returns>
        public static bool MultiBracketValidationMethod(string value)
        {
            int bracket = 0;
            int curly = 0;
            int paran = 0;
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i].ToString() == "[") bracket++;
                if (value[i].ToString() == "]") bracket--;
                if (value[i].ToString() == "{") curly++;
                if (value[i].ToString() == "}") curly--;
                if (value[i].ToString() == "(") paran++;
                if (value[i].ToString() == ")") paran--;
            }
            if (bracket == 0 && curly == 0 && paran == 0) return true;
            else return false;
        }
    }
}
