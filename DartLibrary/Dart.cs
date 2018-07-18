﻿using System;
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

        enum Bands
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

        public string Band()
        {
            if (!this._initialized)
            {
                throw new Exception("Dart Throw method must be invoked at least once before Band call be called");
            }

            return this._band == Bands.Inner ? "Inner" : this._band == Bands.Outer ? "Outer" : "None";
        }

    }
}