using System;

namespace PaymentGateWay
{
     public class MemberShip :IMemberShipRepository
     {
        public void ActivateMember()
        {
        // To do need to added properties to add the the member
           console.Writeline(" Member added sucessfully");
        }
        
       public void SendNotificationMail()
       {
            console.Writeline(" Mail sucessfully sent to member");
       }
       
       public void UpgradeMemberPlan(int memberId)
       {
           console.Writeline(" Membership sucessfully added for member id {0}",memberId);
       }
       
     }
     
     
    
}
