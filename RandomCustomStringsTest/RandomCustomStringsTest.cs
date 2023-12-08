using Promezio.RandomCustomStrings;

namespace RandomCustomStringsTest {
    [TestClass]
    public class RandomCustomStringsTest {
        [TestMethod]
        public void TestStandardConfig() {
            StringConfig config = new StringConfig(10);
            string randomString = RandomCustomStrings.Generate(config);
            
            Assert.IsTrue(randomString.All(char.IsLower));
            Assert.AreEqual(10, randomString.Length);
        }

        [TestMethod]
        public void TestEmptyConfig() {
            StringConfig config = new StringConfig(10, containLowercase: false);
            string randomString = RandomCustomStrings.Generate(config);

            Assert.AreEqual(0, randomString.Length);
        }

        [TestMethod]
        public void TestFullConfig() {
            StringConfig config = new StringConfig(10,
                    containLowercase: true,
                    containNumbers: true,
                    containUppercase: true,
                    containSpecialChars: true);

            string randomString = RandomCustomStrings.Generate(config);

            Assert.AreEqual(10, randomString.Length);
        }

        [TestMethod]
        public void TestCusomStringConfig() {
            StringConfig config = new StringConfig(10,
                    containLowercase: false,
                    customChars: "@",
                    containCustomChars: true);

            string randomString = RandomCustomStrings.Generate(config);

            Assert.AreEqual("@@@@@@@@@@", randomString);

        }
    }
}