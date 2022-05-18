using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6sigmaileProje
{
    class setAQuestion
    {
        //rastgele soru belirleme fonksiyonu
        public void questionSetRandom(int[] questionString)
        {
            int[] questionNumber = new int[20];

            Random random = new Random();
            for (int i = 0; i < questionNumber.Length; i++)
            {
                questionNumber[i] = random.Next(11, 30);
                questionString[i] = questionNumber[i];
            }
        }
    }
}
