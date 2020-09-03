//BusinessAccess Layer

Using System;


namespace PaymentGateWay
{


  public interface IProductRepository
  {
    string GeneratePackingSlip();
    void GetAgentCommisionDetails();
  }
  
 public interface IMemeberShipRepository
 {
 
    void ActivateMember();
    void SendNotificationMail();
    void UpgrateMemberShipByMemberId(int memberId);
 }
// Product and MemberShip Abstract class
public abstract class ProductAbstract
{
 public abstract IProductRepository GetPaymentDetailsByProductType(string type);
}
public abstract class MemberShipAbstract
{
 public abstract IMemeberShipRepository GetPaymentDetailsByProductType(string type);
}

public class ConcreteProuduct :ProductAbstract
{
    publick override IProductRepository GetPaymentDetailsByProductType(string type);
    {
      switch(type)
      {
          case "Book":
			return new Book();
          case "PhysicalProudct":
			return new PhysicalProudct();
	  case "Video":
			return new Video();
          default :
			return new Book();
        
      }
    }
}
public class ConcreteMemberShip :MemberShipAbstract
{
    publick override IMemeberShipRepository GetPaymentDetailsByProductType(string type);
    {
      switch(type)
      {
        case "MemberShip":
          return new MemberShip();
          default :
          return new MemberShip();
        
      }
    }
}


}

