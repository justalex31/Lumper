using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lumper.Enums
{
    public enum Status
    {
        Created = 10,

        Moderated = 20,

        Active = 30,

        InProgress = 40,

        // оно же мягкое удаление (читать в гугле)
        Closed = 50
    }
}
