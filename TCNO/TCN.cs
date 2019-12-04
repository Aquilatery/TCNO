using System;

namespace TCN
{
    public class NO
    {
        public bool Check(string TCNO)
        {
            if (TCNO.Length == 11)
            {
                var N1 = Convert.ToInt32(TCNO[0].ToString());
                var N2 = Convert.ToInt32(TCNO[1].ToString());
                var N3 = Convert.ToInt32(TCNO[2].ToString());
                var N4 = Convert.ToInt32(TCNO[3].ToString());
                var N5 = Convert.ToInt32(TCNO[4].ToString());
                var N6 = Convert.ToInt32(TCNO[5].ToString());
                var N7 = Convert.ToInt32(TCNO[6].ToString());
                var N8 = Convert.ToInt32(TCNO[7].ToString());
                var N9 = Convert.ToInt32(TCNO[8].ToString());
                var N10 = Convert.ToInt32(TCNO[9].ToString());
                var N11 = Convert.ToInt32(TCNO[10].ToString());
                if (((((N1 + N3 + N5 + N7 + N9) * 7) - (N2 + N4 + N6 + N8)) % 10) != N10)
                    return false;
                return (N1 + N2 + N3 + N4 + N5 + N6 + N7 + N8 + N9 + N10) % 10 == N11;
            }
            else
                return false;
        }

        public string Create(Random Random)
        {
            string R;
            do
            {
                var VE = Random.Next(100000000, 1000000000);
                var N1 = VE % 10;
                var N2 = (VE / 10) % 10;
                var N3 = (VE / 100) % 10;
                var N4 = (VE / 1000) % 10;
                var N5 = (VE / 10000) % 10;
                var N6 = (VE / 100000) % 10;
                var N7 = (VE / 1000000) % 10;
                var N8 = (VE / 10000000) % 10;
                var N9 = VE / 100000000;
                var SP = N1 + N3 + N5 + N7 + N9;
                var DP = N2 + N4 + N6 + N8;
                var First = ((SP * 7) - DP) % 10;
                var Last = (SP + DP + First) % 10;
                R = "" + VE + First + Last;
            } while (R.Contains("-"));
            return R;
        }
    }
}