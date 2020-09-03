//Data Access Layer Implementation 

using System;

namespace PaymentGateWay
{
     public class Book :IProductRepository
     {
        public string GeneratePackingSlip()
        {
          return "Book order packing slip generaed ";
        }
        
       public void GetAgentCommisionDetails()
       {
            console.Writeline(" Book order agent commision is 5%");
       }
       
     }
     
   
}
