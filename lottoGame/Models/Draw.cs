using System;
using System.Collections.Generic;

namespace lottoGame.Models
{
    public class Draw /*: IResults*/
    {
        private int maxNums;
        private List<int> drawResults;
        private List<int> winningTicket;

        public Draw()
        {
            //maxNums = 6;
            // = new Tickets();
            drawResults = new List<int>();
            winningTicket = new List<int>();
        }

        public Results _results => throw new NotImplementedException();

        //public Draw Pick()
        //{
        //    drawResults = lottoBall.
        //    winningTicket.Clear();
        //    foreach(int r in drawResults)
        //    {

        //        if(winningTicket.Count >= 6)
        //        { 
        //            //win
        //        }
        //        else
        //        {
        //            //loss
        //        }
        //    }
        //}


        //	public int Results { get; set; }


        //	List<int> winningNumbers = new List<int>() { 2, 13, 1, 25, 37 };
        //	public struct TicketNumbers
        //	{
        //		public int[] firstNumbers;
        //		public int powerBall;

        //		public TicketNumbers(int[] _firstNumbers, int _powerBall)
        //		{
        //			firstNumbers = _firstNumbers;
        //			powerBall = _powerBall;
        //		}

        //		public TicketNumbers GetTicketNumbers()
        //		{

        //			int[] result = new int[5];
        //			Random random = new Random();
        //			for (int i = 0; i < 5; i++)
        //			{
        //				int num;
        //				do
        //				{
        //					num = random.Next(1, 49);
        //				} while (result.Contains(num));

        //				result[i] = num;
        //			}
        //			int powerBall = random.Next(1, 49);
        //			Array.Sort(result);
        //			return new TicketNumbers(result, powerBall);



        //			//if LotteryNumbers = TicketNumbers
        //			// Icomparable
        //		}
        //		public int CompareTo(Object obj)
        //		{
        //			return ((drawResults)obj).Results.CompareTo(this.Results);
        //		}

        //	}
        //}
    }
}