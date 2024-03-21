using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Tracker
{
    internal class Sanitize
    {
        public static string SanitizeInput(string input)
        {
            //Define patterns that are considered harmful or part of an attack vector
            var patternsToMatch = new List<string> { "SELECT", "DROP", "INSERT", "DELETE", "UPDATE" };

            //Variable to keep track of whether we found something in the last iteration
            bool foundInLastIteration;

            do
            {
                foundInLastIteration = false;

                foreach (var pattern in patternsToMatch)
                {
                    // If the input contains any of the patterns
                    if (input.ToUpper().Contains(pattern))
                    {
                        // Remove the detected pattern
                        input = input.Replace(pattern, "", StringComparison.OrdinalIgnoreCase);
                        foundInLastIteration = true;
                    }
                }
            }
            while (foundInLastIteration); // Keep running until no more patterns are found

            return input;
        }

    }
}
