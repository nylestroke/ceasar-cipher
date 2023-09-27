namespace CaesarCipher
{
    public static class CaesarTool
    {
        /// <summary>
        /// Encrypt text using Ceasar Cipher
        /// </summary>
        /// <param name="inputText">Input text</param>
        /// <param name="shift">Shift value</param>
        /// <returns>Encrypted text</returns>
        public static string Encrypt(string inputText, int shift)
        {
            // Get data from text area and remove whitespaces from it
            var textToEncrypt = Util.RemoveWhitespace(inputText);
            // Local variable to introduce new encrypted text
            var cipherText = string.Empty;

            // Loop through all characters in text and shift it to 3 times
            foreach (var character in textToEncrypt)
            {
                // Add shifted letter to local variable
                char encoded = (char)(character + shift);

                // Check if we are not over alphabet length
                if ((int)encoded > 90)
                {
                    encoded = (char)((int)encoded - 26);
                }

                // save encrypted text
                cipherText += encoded;
            }

            // Set ciphered text to output area
            return cipherText;
        }

        /// <summary>
        /// Encrypt text using Ceasar Cipher (V2)
        /// </summary>
        /// <param name="inputText">Input text</param>
        /// <param name="shift">Shift value</param>
        /// <returns>Encrypted text</returns>
        public static string EncryptV2(string inputText, int shift)
        {
            // Array with all characters in alphabet (uppercase) and including poland characters
            char[] chars = new char[] { 'A', 'Ą', 'B', 'C', 'Ć', 'D', 'E', 'Ę', 'F', 'G', 'H', 'I', 'J', 'K', 'L',
                           'Ł', 'M', 'N', 'Ń', 'O', 'Ó', 'P', 'R', 'S', 'Ś', 'T', 'U', 'W', 'Y', 'Z', 'Ź', 'Ż' };

            // Input text
            inputText = inputText.ToUpper();
            // Encrypted text
            string encryptedText = string.Empty;

            // Loop through all characters in input text
            foreach (char c in inputText)
            {
                // Get index of character in ASCII table
                int index = Array.FindIndex(chars, x => x == c);
                // Check if index is greater than 0
                if (index >= 0)
                {
                    // Add 3 to index
                    index += shift;

                    // Check if index is greater than chars length
                    if (index > chars.Length - 1)
                    {
                        // Subtract 26 from index
                        index -= chars.Length;
                    }

                    // Add encrypted character to encrypted text
                    encryptedText += chars[index];
                }
            }

            // Return encrypted text
            return encryptedText;
        }
    }
}
