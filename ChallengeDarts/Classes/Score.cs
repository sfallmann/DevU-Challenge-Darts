using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ChallengeDarts.Classes
{
    public class Score
    {
        public static int  DartThrow(int score, Dart.Bands band)
        {
            if (score == 0)
                return band == Dart.Bands.Inner ? 50 : 25;

            return band == Dart.Bands.None ? score : band == Dart.Bands.Outer ? score * 2 : score * 3;
        }
    }

    
}