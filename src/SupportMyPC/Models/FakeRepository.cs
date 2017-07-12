using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportMyPC.Models
{
    public class FakeRepository : IRepository
    {
        public IEnumerable<SupportCall> supportCalls => new List<SupportCall> {
        new SupportCall { SupportCallId = 1111,
                          CustID = "1",
                          CustName = "שלום עליכם",
                          CustPhone ="0547343242",
                          RegisteredCust =false,
                          ProblemMachineID = 1,
                          ProblemMachine ="מחשב נייח",
                          ProblemDescription ="מחשב לא נדלק",
                          SupportCallDate = DateTime.Now.ToString(),
                          SupportCallStatusID = 1,
                          SupportCallStatus = "פתוחה"
        },
         new SupportCall { SupportCallId = 2222,
                          CustID = "2",
                          CustName = "קובי",
                          CustPhone ="0547343242",
                          RegisteredCust =true,
                          ProblemMachineID = 2,
                          ProblemMachine ="מחשב נייד",
                          ProblemDescription ="מחשב לא נדלק",
                          SupportCallDate = DateTime.Now.ToString(),
                          SupportCallStatusID = 2,
                          SupportCallStatus = "סגורה"
        },
          new SupportCall { SupportCallId = 3333,
                          CustID = "3",
                          CustName = "אבי",
                          CustPhone ="0547343242",
                          RegisteredCust =false,
                          ProblemMachineID = 1,
                          ProblemMachine ="מחשב נייח",
                          ProblemDescription ="לא תחשבר לאינטרנט",
                          SupportCallDate = DateTime.Now.ToString(),
                          SupportCallStatusID = 1,
                          SupportCallStatus = "פתוחה"
        }
    };
    }
}
