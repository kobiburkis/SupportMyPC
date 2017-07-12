using System.Collections.Generic;

namespace SupportMyPC.Models
{
    public class EFRepository : IRepository
    {
        private ApplicationDbContext context;
        public EFRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<SupportCall> supportCalls => context.supportCalls;
    }
}
