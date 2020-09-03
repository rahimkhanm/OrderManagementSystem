using System;

namespace PaymentGateWay
{
     public class PhysicalProduct :IProductRepository
     {
        public string GeneratePackingSlip()
        {
          return "Physical order packing slip generaed ";
        }
        
       public void GetAgentCommisionDetails()
       {
            console.Writeline(" Product Oder agent commision percentage is 10%");
       }
       
     }
       
    
}

