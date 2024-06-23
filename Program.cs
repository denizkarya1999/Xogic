using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ProcessWords
{
    class Program
    {
        static string status; //Sets the status of the person based on the string.
        static bool Processing_Is_Successful = false; //A boolean expression to check whether process was succesful or not.
        static void Main()
        {
            // Prompt user to enter data.
            Console.WriteLine("Describe the person here: ");
            Console.WriteLine();
            Console.Write("->" + " ");

            // Input words from the user
            string? input = Console.ReadLine();

            // Trim the string into words
            string[] words = ParseWords(input);

            // Perform the operation and get a result.
           Processing_Is_Successful = processWords("checkStudent", words);

            Console.WriteLine();

            // If process is succesful, print out the status. Otherwise print an error message.
            if (Processing_Is_Successful)
            {
                Console.WriteLine("Occupation Detected: " + status);
            }
            else
            {
                Console.WriteLine("An error occured identifying the data. - E001"); //E001 - Unable to process data.
            }
        }

        // Detect every single word and put them in a string.
        static string[] ParseWords(string input)
        {
            // Use a regular expression to find words.
            MatchCollection matches = Regex.Matches(input, @"\b\w+\b");

            // A variable to store the words.
            List<string> words = new List<string>();

            // In each Regex match, add the value to the list.
            foreach (Match match in matches)
            {
                words.Add(match.Value);
            }

            // Return the list as an array.
            return words.ToArray();
        }

        // Determine the actions based on command and the word recieved.
        static bool processWords(string command, string[] words)
        {
            // Check the command and perform the action.
            switch (command)
            {
                case "checkStudent":
                    if (Student.checkStudentStatus(words)){
                        status = "Student";
                    }
                    return Student.checkStudentStatus(words);
            }
            return false;
        }
    }
}