using System;
using System.Text.RegularExpressions;

namespace DotNetClassLib
{
    public class User
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Returns the username, generate by:
        /// - concatenating the firstname and lastname with a single full-stop
        /// - with all non-alpha characters removed
        /// - all lower case
        /// </summary>
        public string Username
        {
            get
            {
                throw new NotImplementedException(); 
            }
        }

        /// <summary>
        /// Checks that the Firstname and Lastname are not empty and not longer than 100 characters.
        /// Checks that the Description contains less than 50 words.
        /// </summary>
        public bool IsValid
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
