using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ChallengeDarts.Classes
{
    
    public class Game
    {
        private Random _random;
        private int _playerOneScore;
        private int _playerTwoScore;
        private Dart _dart;

        public Game()
        {
            this._random = new Random();
            this._playerOneScore = 0;
            this._playerTwoScore = 0;
            this._dart = new Dart(_random);
        }

        public int PlayerOneScore
        {
            get { return _playerOneScore; }
        }

        public int PlayerTwoScore
        {
            get { return _playerTwoScore; }
        }

        private int Turn()
        {
            int score = 0;
            for (var i=0; i < 3; i++)
            {
                this._dart.Throw();
                score += Score.DartThrow(this._dart.Score, this._dart.Band);
            }
            return score;
        }

        public string Play()
        {
            bool gameOver = false;
            
            while (!gameOver)
            {
                this._playerOneScore += this.Turn();

                if (_playerOneScore >= 300)
                    gameOver = true;
                else
                {
                    this._playerTwoScore += this.Turn();

                    if (_playerTwoScore >= 300)
                        gameOver = true;
                }
            }

            return this._gameResults();
        }

        private string _gameResults()
        {
            StringBuilder sb = new StringBuilder();

            string winner = this._playerOneScore > this._playerTwoScore ? "Player One" : "Player Two";

            sb.Append($"<strong>Player One:</strong> {this._playerOneScore}<br/>");
            sb.Append($"<strong>Player Two:</strong> {this._playerTwoScore}");
            sb.Append("<br/><br/>");
            sb.Append($"<h3>Winner is {winner}!</h3>");

            return sb.ToString();
        }
    }
}