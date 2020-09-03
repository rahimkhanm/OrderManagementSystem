using Microsoft.VisuvalStudio.TestingTools.UnitTesting;
using PayamentGateWay;

namespace UnitTestProject
{
[TestClass]

public class UnitTest1
{
  [TestMethod]
  public void GenrateBookOrderPackiSlip()
  {
       ProductAbstract objAbstract= new ConcreteProuduct();
       IPayamentRepository objBook= objAbstract.GetPaymentDetailsByProductType("Book");
       string expected="Book order packing slip generaed";
       string actuval=objBook.GeneratePackingSlip();
       Assert.AreEqual(expected,actuval);

  }
  
}
}

