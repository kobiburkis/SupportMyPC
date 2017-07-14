using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportMyPC.Models.ViewModels
{
    public class SupportCallListViewModel
    {
        public IEnumerable<SupportCall> supportCalls { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
