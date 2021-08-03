using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoiceGenerate;


namespace CanInvoiceGeneratorTesting
{
    [TestClass]
    public class CabInvoiceTesting
    {

        // UC 1- TC 1.1 Calculate fare for Normal Rides
        [TestMethod]
        [TestCategory("CalculatingNormalFare")]
        public void Return_TotalFare_ForNormalRide()
        {
            CabInvoiceCalculate cabInvoiceCalculate = new CabInvoiceCalculate();
            double distance = 6.3;
            int time = 15;
            double fare = cabInvoiceCalculate.CalculateFare(distance, time);
            double expected = 78.0;
            Assert.AreEqual(expected, fare);

        }
        // UC 1- TC 1.2 Through exception if given Invalid Values
        [TestMethod]
        [TestCategory("CalculatingNormalFare")]
        public void Return_TotalFare_ForRide_InvalidDistance()
        {
            string expected = "Distance should be Greater than zero";
            try
            {
                CabInvoiceCalculate cabInvoiceCalculate = new CabInvoiceCalculate();
                double distance = -1;
                int time = 10;
                double fare = cabInvoiceCalculate.CalculateFare(distance, time);

            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.message);
            }
        }

    }
}