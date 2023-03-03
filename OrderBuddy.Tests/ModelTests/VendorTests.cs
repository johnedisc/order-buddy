using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderBuddy.Models;

namespace OrderBuddy.Tests
{
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor testVendor = new Vendor("test");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }

}
