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
  [TestMethod]
  public void GenrateProductOrderPackiSlip()
  {
       ProductAbstract objAbstract= new ConcreateFactory();
       IPayamentRepository objBook= objAbstract.GetPaymentDetailsByProductType("Book");
       string expected="Physical order packing slip generaed";
       string actuval=objBook.GeneratePackingSlip();
       Assert.AreEqual(expected,actuval);

  }
  
  [TestMethod]
  public void GenrateVideoOrderPackiSlip()
  {
       ProductAbstract objAbstract= new ConcreateFactory();
       IPayamentRepository objBook= objAbstract.GetPaymentDetailsByProductType("Book");
       string expected="Video packing slip generaed";
       string actuval=objBook.GeneratePackingSlip();
       Assert.AreEqual(expected,actuval);

  }
  
   [TestMethod]
  public void ActiveMemberDetails()
  {
       ProductAbstract objAbstract= new ConcreateFactory();
       IMemeberShipRepository objMember= objAbstract.GetPaymentDetailsByProductType("Book");
          
	try
    {
        objMember.ActivateMember();
        Assert.IsTrue(true);
    }
    catch {
        Assert.IsTrue(false);
    }
	   
       Assert.AreEqual(expected,actuval);

  }
}
  
}
}

