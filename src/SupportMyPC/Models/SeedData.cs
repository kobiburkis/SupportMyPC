using System.Linq;
using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace SupportMyPC.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            if (!context.supportCalls.Any())
            {
                context.supportCalls.AddRange(
               new SupportCall
               {
                   CustID = "1",
                   CustName = "שלום עליכם",
                   CustPhone = "0547343242",
                   RegisteredCust = false,
                   ProblemMachineID = 1,
                   ProblemMachine = "מחשב נייח",
                   ProblemDescription = "מחשב לא נדלק",
                   SupportCallDate = DateTime.Now.ToString(),
                   SupportCallStatusID = 1,
                   SupportCallStatus = "פתוחה"
               },
         new SupportCall
         {
             CustID = "2",
             CustName = "קובי",
             CustPhone = "0547343242",
             RegisteredCust = true,
             ProblemMachineID = 2,
             ProblemMachine = "מחשב נייד",
             ProblemDescription = "מחשב לא נדלק",
             SupportCallDate = DateTime.Now.ToString(),
             SupportCallStatusID = 2,
             SupportCallStatus = "סגורה"
         },
          new SupportCall
          {
              CustID = "3",
              CustName = "אבי",
              CustPhone = "0547343242",
              RegisteredCust = false,
              ProblemMachineID = 1,
              ProblemMachine = "מחשב נייח",
              ProblemDescription = "לא מתחבר לאינטרנט",
              SupportCallDate = DateTime.Now.ToString(),
              SupportCallStatusID = 1,
              SupportCallStatus = "פתוחה"
          }
    );
                context.SaveChanges();
            }
        }
    }
}