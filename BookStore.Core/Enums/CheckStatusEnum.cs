using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Enums
{
    public enum CheckStatusEnum : byte
    {
        Empty, Match, DoesNotMatch, Existed, NotExisted, Saved, NotSaved, Deleted, Notdeleted, Updated, DoesNotUpdated
    }
}
