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
		  
      		Console.ReadLine();
        
    }
}

