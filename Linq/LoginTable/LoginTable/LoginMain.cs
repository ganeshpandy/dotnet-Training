using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginTable
{
     class LoginMain
    {
        public static List<LoginDetails> LoadDetails()
        {

            List<LoginDetails> details = new List<LoginDetails>()
            {
                new LoginDetails(){Name="Alex",Email="Alex@123",Password="Alex1341",ConfirmPassword="Alex1341",Phno=24176876},
                new LoginDetails(){Name="Bolt",Email="Bolt@123",Password="Bolt2421",ConfirmPassword="Bolt2421",Phno=86756548},
                new LoginDetails(){Name="Charles",Email="Charles@123",Password="Charles1324",ConfirmPassword="Charles1324",Phno=24252533},
                new LoginDetails(){Name="Jack",Email="Jack@123",Password="Jack3542",ConfirmPassword="Jack3542",Phno=678564453},
            };

            return details;
        }
    }
}
