namespace Palindrome
{
    public class PalindromeChecker : IPalindromeChecker
    {
        public bool IsPalindrome(string phrase)
        {
            string noSpacePhrase = phrase.Replace(" ", string.Empty);
            string noSpaceLowerPhrase = noSpacePhrase.ToLower();

            return IsPalindromeInternal(noSpaceLowerPhrase);
        }

        private bool IsPalindromeInternal(string phrase)
        {
            if (phrase.Length < 2)
            {
                return true;
            }

            return phrase.Substring(0, 1) == phrase.Substring(phrase.Length - 1, 1) &&
                   IsPalindromeInternal(phrase.Substring(1, phrase.Length - 2));
        }
    }
}