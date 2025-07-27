using PhoneKeypadApp.Models;
using System.Text;

namespace PhoneKeypadApp.Services
{
    /// <summary>
    /// Provides functionality to decode input strings simulating old mobile phone keypads.
    /// </summary>
    public class KeyPadDecoder
    {
        /// <summary>
        /// Decodes the provided keypad input string and prints the result to the console.
        /// </summary>
        /// <param name="input">
        /// A string of digits and control characters:
        /// Digits (0–9) represent key presses,
        /// space (' ') confirms character selection,
        /// asterisk ('*') performs a backspace,
        /// and hash ('#') ends the input.
        /// </param>
        /// <example>
        /// Example input: "4433555 555666#" prints "HELLO"
        /// </example>
        public void Decode(string input)
        {
            var output = new StringBuilder();
            var currentKey = '\0';
            int pressCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (char.IsDigit(ch))
                {
                    if (ch == currentKey)
                    {
                        pressCount++;
                    }
                    else
                    {
                        AppendCharacter(output, currentKey, pressCount);
                        currentKey = ch;
                        pressCount = 1;
                    }
                }
                else if (ch == ' ')
                {
                    AppendCharacter(output, currentKey, pressCount);
                    currentKey = '\0';
                    pressCount = 0;
                }
                else if (ch == '*')
                {
                    AppendCharacter(output, currentKey, pressCount);
                    if (output.Length > 0)
                        output.Remove(output.Length - 1, 1);
                    currentKey = '\0';
                    pressCount = 0;
                }
                else if (ch == '#')
                {
                    AppendCharacter(output, currentKey, pressCount);
                    break;
                }
            }

            Console.WriteLine(output.ToString());
        }

        /// <summary>
        /// Appends a character to the output based on the key and the number of times it was pressed.
        /// </summary>
        /// <param name="output">The string builder accumulating the decoded message.</param>
        /// <param name="key">The numeric key pressed (e.g., '2').</param>
        /// <param name="count">The number of times the key was pressed.</param>
        private void AppendCharacter(StringBuilder output, char key, int count)
        {
            if (key == '\0' || count == 0) return;

            if (KeypadMapping.Map.TryGetValue(key, out string? letters) && letters != null)
            {
                int index = (count - 1) % letters.Length;
                output.Append(letters[index]);
            }
        }

    }
}
