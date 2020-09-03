using System;

namespace PaymentGateWay
{
     public class PhysicalProduct :IProductRepository
     {
        public string GeneratePackingSlip()
        {
          return "Video packing slip generaed ";
        }
        
       public void GetAgentCommisionDetails()
       {
            console.Writeline(" Vedio agent commision percentage is 10%");
       }
       
     }
       
    
}
