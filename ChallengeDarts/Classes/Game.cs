using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeDarts.Classes
{
    public class Game
    {
  
        private Dart _dartOne;
        private Dart _dartTwo;
        
        public Game(Dart dartOne, Dart dartTwo)
        {
            this._dartOne = dartOne;
            this._dartTwo = dartTwo;
        }

        private int Turn(Dart dart)
        {
            int score = 0;
            for (var i=0 i < 3; i++)
            {
                dart.Throw();
                score += Score.DartThrow(dart.Score, dart.Band);
            }
            return score;
        }

    }
}