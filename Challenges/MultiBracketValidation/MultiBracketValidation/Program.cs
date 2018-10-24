using System;

namespace MultiBracketValidation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }

        /// <summary>
        /// This method takes in a string and determines if there is are pairs of brackets, curlies, and parans
        /// </summary>
        /// <param name="value">Takes in a string</param>
        /// <returns>Returns true if there are pairs and false if there aren't</returns>
        public static bool MultiBracketValidation(string value)
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
