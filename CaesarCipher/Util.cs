namespace CaesarCipher
{
    public static class Util
    {
        /// <summary>
        /// Remove whitespaces from input text
        /// </summary>
        /// <param name="input">Input text</param>
        /// <returns>Text without whitespaces</returns>
        public static string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }
    }
}
