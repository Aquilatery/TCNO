using System;

namespace TCN
{
    public class NO
    {
        public bool Check(string TCNO)
        {
            if (TCNO.Length == 11)
            {
                int N1 = Convert.ToInt32(TCNO[0].ToString());
                int N2 = Convert.ToInt32(TCNO[1].ToString());
                int N3 = Convert.ToInt32(TCNO[2].ToString());
                int N4 = Convert.ToInt32(TCNO[3].ToString());
                int N5 = Convert.ToInt32(TCNO[4].ToString());
                int N6 = Convert.ToInt32(TCNO[5].ToString());
                int N7 = Convert.ToInt32(TCNO[6].ToString());
                int N8 = Convert.ToInt32(TCNO[7].ToString());
                int N9 = Convert.ToInt32(TCNO[8].ToString());
                int N10 = Convert.ToInt32(TCNO[9].ToString());
                int N11 = Convert.ToInt32(TCNO[10].ToString());
                if (((((N1 + N3 + N5 + N7 + N9) * 7) - (N2 + N4 + N6 + N8)) % 10) != N10)
                {
                    return false;
                }

                return (N1 + N2 + N3 + N4 + N5 + N6 + N7 + N8 + N9 + N10) % 10 == N11;
            }
            else
            {
                return false;
            }
        }

        public string Create(Random Random)
        {
            string R;
            do
            {
                int VE = Random.Next(100000000, 1000000000);
                int N1 = VE % 10;
                int N2 = (VE / 10) % 10;
                int N3 = (VE / 100) % 10;
                int N4 = (VE / 1000) % 10;
                int N5 = (VE / 10000) % 10;
                int N6 = (VE / 100000) % 10;
                int N7 = (VE / 1000000) % 10;
                int N8 = (VE / 10000000) % 10;
                int N9 = VE / 100000000;
                int SP = N1 + N3 + N5 + N7 + N9;
                int DP = N2 + N4 + N6 + N8;
                int First = ((SP * 7) - DP) % 10;
                int Last = (SP + DP + First) % 10;
                R = "" + VE + First + Last;
            } while (R.Contains("-"));
            return R;
        }
    }
}