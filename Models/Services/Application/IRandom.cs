using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcapi.Models.Services.Application
{
    public interface IRandom
    {
        int GetRandomNumber ();
    }
}