using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeDarts
{
    
    public class Dart
    {
        
        private Random _random;
        private Bands _band;
        private int _score;
        private bool _initialized = false;

        public int Score
        {
            get { return this._score;  }
        }

        public Bands Band
        {
            get { return this._band; }
        }

        public enum Bands
        {
            None,
            Inner,
            Outer
        }

        
        public Dart(Random random)
        {
            
            this._random = random;
        }

        public void Throw()
        {
            this._initialized = true;
            this._score = this._random.Next(20);
            int multiplierChance = this._random.Next(1, 100);

            if (this._score == 0)
                this._band = multiplierChance > 6 ? Bands.Outer : Bands.Inner;
            else
                this._band = multiplierChance < 6 ? Bands.Inner : multiplierChance > 95 ? Bands.Outer : Bands.None;

        }

    }
}