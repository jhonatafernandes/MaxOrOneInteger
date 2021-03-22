using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaxOrOneInteger.Tests
{
    [TestClass]
    public class MaxOrOneTests
    {
        [TestCategory("Max Or One Tests")]
        [TestMethod("Validate Max Or One")]
        [DataRow(1,2,2)]
        [DataRow(1,1,1)]
        [DataRow(0,0,1)]
        public void ValidateMaxOrOne(int quantity, int otherQuantity, int result)
        {
            var number = 1;

            Assert.AreEqual(number.AddLinesByQuantity(quantity, otherQuantity), result);
        }
    }
}
