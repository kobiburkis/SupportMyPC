using System;
using System.Collections.Generic;
namespace SupportMyPC.Models
{
    public interface IRepository
    {
        IEnumerable<SupportCall> supportCalls { get; }
    }
}
