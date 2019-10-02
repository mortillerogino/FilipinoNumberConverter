using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TagalogNumberWordConverter.Tests
{
    [TestClass]
    public class TagalogNumberWordConverterTests
    {
        [TestMethod]
        public void TestAsAWhole()
        {
            int toConvert = 240300567;
            string expected = "Dalawang daan Apatnapong milyon Tatlong daan na libo at Limang daan Animnapo't Pito";

            string actual = FilipinoNumberConverter.ConvertAll(toConvert);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test100Million()
        {
            int toConvert = 100000000;
            string expected = "Isang daan na milyon";

            string actual = FilipinoNumberConverter.ConvertAll(toConvert);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test10Million()
        {
            int toConvert = 10000000;
            string expected = "Sampung milyon";

            string actual = FilipinoNumberConverter.ConvertAll(toConvert);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test1Million()
        {
            int toConvert = 1000000;
            string expected = "Isang milyon";

            string actual = FilipinoNumberConverter.ConvertAll(toConvert);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test999Thousand()
        {
            int toConvert = 999000;
            string expected = "Siyam na daan Siyamnapo't Siyam na libo";

            string actual = FilipinoNumberConverter.ConvertAll(toConvert);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test99Thousand()
        {
            int toConvert = 99000;
            string expected = "Siyamnapo't Siyam na libo";

            string actual = FilipinoNumberConverter.ConvertAll(toConvert);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test8Thousand()
        {
            int toConvert = 8000;
            string expected = "Walong libo";

            string actual = FilipinoNumberConverter.ConvertAll(toConvert);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test123()
        {
            int toConvert = 123;
            string expected = "Isang daan Dalawampo't Tatlo";

            string actual = FilipinoNumberConverter.ConvertAll(toConvert);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test11()
        {
            int toConvert = 11;
            string expected = "Labing Isa";

            string actual = FilipinoNumberConverter.ConvertAll(toConvert);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test6()
        {
            int toConvert = 6;
            string expected = "Anim";

            string actual = FilipinoNumberConverter.ConvertAll(toConvert);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test22()
        {
            int toConvert = 22;
            string expected = "Dalawampo't Dalawa";

            string actual = FilipinoNumberConverter.ConvertAll(toConvert);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test111()
        {
            int toConvert = 111;
            string expected = "Isang daan Labing Isa";

            string actual = FilipinoNumberConverter.ConvertAll(toConvert);

            Assert.AreEqual(expected, actual);
        }
    }
}
