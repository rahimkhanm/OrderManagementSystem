//Presentation Layer

﻿using System;
using System.Collections.Generic;

namespace OrderManagement
{
    public class Program
    {
          string paymentOrderType;
	  string packingSlipDetails;
          console.WriteLine(" Please enter product type");
          paymentOrderType=console.ReadLine();
          ProductAbstract objAProduct=new ConcreteProuduct();
          MemberShipAbstract objAMembership= new ConcreteMemberShip();
          
	  if(paymentOrderType=="Book")
	  {
		 IProductRepository objBook=objProduct.GetPaymentDetailsByProductType(paymentOrderType); 
		 packingSlipDetails=objBook.GeneratePaySlip();
		 objBook.GetCommisionDetails();
		 Console.WriteLine(packingSlipDetails);
	  }
	   else if (paymentOrderType=="PhysicalProudct")
	  {

		  IProductRepository objPhysicalProduct=objProduct.GetPaymentDetailsByProductType(paymentOrderType); 
		  packingSlipDetails=objPhysicalProduct.GeneratePaySlip();
		  objPhysicalProduct.GetCommisionDetails();
	  } 
	    else if (paymentOrderType=="Vedio")
	  {

		  IProductRepository objPhysicalProduct=objProduct.GetPaymentDetailsByProductType(paymentOrderType); 
		  packingSlipDetails=objPhysicalProduct.GeneratePaySlip();

	  }
	    else if (paymentOrderType=="MemberShip")
	  {

		  IPayamentRepository objMemberShip=objAMembership.GetPaymentDetailsByType(paymentOrderType); 
		  packingSlipDetails=objMemberShip.GeneratePaySlip();
		 //if member need to be activate need call below method
		 objMemberShip.ActivateMember();

		 //for member updatetion
		 objMemberShip.UpgrateMemberShipByMemberId(123);
		 //send Activation/updatetion mail to member
		 objMemberShip.SendNotificationMail();
	  }
		  
      		Console.ReadLine();
        
    }
}

