using lottoGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lottoGame.Interfaces
{
    interface IResults
    {
        Results _results { get; }
        Draw Pick();
    }
}
