using PhoneKeypadApp.Services;
using System;

/// <summary>
/// Entry point for the PhoneKeypadApp console application.
/// Demonstrates decoding input strings based on old phone keypad input.
/// </summary>
class Program
{
    /// <summary>
    /// Main method that runs the keypad decoder examples.
    /// </summary>
    /// <param name="args">Command-line arguments (not used).</param>
    static void Main(string[] args)
    {
        var oldPhonePad = new KeyPadDecoder();

        oldPhonePad.Decode("33#");                // Output: E
        oldPhonePad.Decode("227*#");              // Output: B
        oldPhonePad.Decode("4433555 555666#");    // Output: HELLO
        oldPhonePad.Decode("8 88777444666*664#"); // Output: TURING
        oldPhonePad.Decode("4440777332555 5559990926680866605666444660999666887770222666 67266999#"); // ?????

        Console.ReadLine();
    }
}