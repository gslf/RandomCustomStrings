using System.Text;

namespace Promezio.RandomCustomStrings {

    /// <summary>
    /// Provides functionality to generate random strings based on specific configurations.
    /// </summary>
    public static class RandomCustomStrings {

        /// <summary>
        /// Generates a random string based on the specified configuration.
        /// </summary>
        /// <param name="config">The configuration settings for generating the random string.</param>
        /// <returns>A randomly generated string based on the given configuration.</returns>
        public static string Generate(StringConfig config) {
            Random random = new Random();
            StringBuilder builder = new StringBuilder(config.Lenght);
            string seed = config.BuildSeedString();

            if (!string.IsNullOrEmpty(seed)) {
                for (int i = 0; i < config.Lenght; i++) {
                    builder.Append(seed[random.Next(seed.Length)]);
                }
            }

            return builder.ToString();
        }
    }

    /// <summary>
    /// Represents the configuration for generating a random string, including options for character types.
    /// </summary>
    public class StringConfig {

        // Seeds preconfiguration
        private string _uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string _lowercase = "abcdefghijklmnopqrstuvwxyz";
        private string _numbers = "0123456789";
        private string _specialChars = ",.;:-_*()%$&?!=/";

        /// <summary>
        /// The length of the string to be generated.
        /// </summary>
        public int Lenght {  get; set; }

        /// <summary>
        /// Custom characters to be included in the string generation, if any.
        /// </summary>
        public string? CustomChars { get; set; }

        /// <summary>
        /// Determines if uppercase characters should be included.
        /// </summary>
        public bool ContainUppercase { get; set; }

        /// <summary>
        /// Determines if lowercase characters should be included.
        /// </summary>
        public bool ContainLowercase { get; set; }

        /// <summary>
        /// Determines if numeric characters should be included.
        /// </summary>
        public bool ContainNumbers { get; set; }

        /// <summary>
        /// Determines if special characters should be included.
        /// </summary>
        public bool ContainSpecialChars { get; set; }

        /// <summary>
        /// Determines if custom characters provided should be included.
        /// </summary>
        public bool ContainCustomChars {  get; set; }


        /// <summary>
        /// Initializes a new instance of the StringConfig class with specific settings.
        /// </summary>
        /// <param name="lenght">Length of the string to be generated.</param>
        /// <param name="customChars">Custom characters to include in the string.</param>
        /// <param name="containUppercase">Include uppercase characters if true.</param>
        /// <param name="containLowercase">Include lowercase characters if true.</param>
        /// <param name="containNumbers">Include numeric characters if true.</param>
        /// <param name="containSpecialChars">Include special characters if true.</param>
        /// <param name="containCustomChars">Include provided custom characters if true.</param>
        public StringConfig(int lenght, 
            string customChars = "", 
            bool containUppercase = false,
            bool containLowercase = true,
            bool containNumbers = false,
            bool containSpecialChars = false,
            bool containCustomChars = false) {

            Lenght = lenght;
            CustomChars = customChars;
            ContainUppercase = containUppercase;
            ContainLowercase = containLowercase;
            ContainNumbers = containNumbers;
            ContainSpecialChars = containSpecialChars;
            ContainCustomChars = containCustomChars;

        }

        /// <summary>
        /// Builds the string used as a seed for random generation, incorporating all character type settings.
        /// </summary>
        /// <returns>A string containing all characters that can be used for generating the random string.</returns>
        public string BuildSeedString() {
            StringBuilder builder = new StringBuilder();
            
            if (ContainUppercase) {
                builder.Append(_uppercase);
            }

            if(ContainLowercase) {
                builder.Append(_lowercase);
            }

            if(ContainNumbers) {
                builder.Append(_numbers);
            }

            if(ContainSpecialChars) {
                builder.Append(_specialChars);
            }

            if(ContainCustomChars) {
                builder.Append(CustomChars);
            }
            return builder.ToString();
        }

    }
}
