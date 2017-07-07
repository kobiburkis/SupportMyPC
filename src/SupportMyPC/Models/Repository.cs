using System;
using System.Collections.Generic;
namespace SupportMyPC.Models
{
    public static class Repository
    {
        private static List<SupportCall> supportCalls = new List<SupportCall>();
        public static IEnumerable<SupportCall> SupportCalls
        {
            get
            {
                return supportCalls;
            }
        }
        public static void AddSupportCall(SupportCall sCall)
        {
            supportCalls.Add(sCall);
        }
    }
}
