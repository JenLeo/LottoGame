using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace lottoGame.Models
{
    public class Tickets
    {
        private Random random;

        public Tickets()
        {
            random = new Random();
        }

        public List<int> Numbers(int sumNumbers, int minNumbers, int maxNumbers)
        {
            List<int> DrawResults = new List<int>();
            List<int> drawList = new List<int>();

            int numberDrawn;

            if (maxNumbers - minNumbers + 1 < sumNumbers) return DrawResults;

            for (int i = minNumbers; i <= maxNumbers; i++)
            {
                drawList.Add(i);
            }
            for (int j = 0; j < sumNumbers; j++)
            {
                numberDrawn = random.Next(minNumbers, (maxNumbers + 1) - j);
                DrawResults.Add(drawList[numberDrawn - 1]);
                drawList.RemoveAt(numberDrawn - 1);
            }
            return DrawResults;
        }
    }

    //    public int Results { get; set; }
    //    public struct LotteryNumbers
    //    {
    //        public int[] firstNumbers;
    //        public int powerBall;

    //        public LotteryNumbers(int[] _firstNumbers, int _powerBall)
    //        {
    //            firstNumbers = _firstNumbers;
    //            powerBall = _powerBall;
    //        }


    //    }
    //    public LotteryNumbers GetLotteryNumbers()
    //    {
    //        {
    //            int[] result = new int[5];
    //            Random random = new Random();
    //            for (int i = 0; i < 5; i++)
    //            {
    //                int num;
    //                do
    //                {
    //                    num = random.Next(1, 49);
    //                } while (result.Contains(num));

    //                result[i] = num;
    //            }
    //            int powerBall = random.Next(1, 49);
    //            Array.Sort(result);
    //            return new LotteryNumbers(result, powerBall);
    //        }
    //    }
    //}
}