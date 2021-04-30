using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lottoGame.Models
{
    //DATA MODELSTATE INFO
    public class Results
    {
        public List<int> drawResults { get; }
        public List<int> winningTicket { get; }


        public Results(List<int> DrawResults, List<int> WinningTicket)
        {
            drawResults = DrawResults;
            winningTicket = WinningTicket;
        }

    }
}