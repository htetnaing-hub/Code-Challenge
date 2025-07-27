using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneKeypadApp.Models
{
    /// <summary>
    /// Represents the character mappings for a classic mobile phone keypad.
    /// </summary>
    public class KeypadMapping
    {
        /// <summary>
        /// A dictionary that maps numeric keypad characters (0–9) to their corresponding letter groups.
        /// </summary>
        /// <remarks>
        /// For example, '2' maps to "ABC", '3' to "DEF", and so on.
        /// </remarks>
        public static readonly Dictionary<char, string> Map = new Dictionary<char, string>
        {
            { '1', "&'(" },
            { '2', "ABC" },
            { '3', "DEF" },
            { '4', "GHI" },
            { '5', "JKL" },
            { '6', "MNO" },
            { '7', "PQRS" },
            { '8', "TUV" },
            { '9', "WXYZ" },
            { '0', " " },
        };
    }
}
