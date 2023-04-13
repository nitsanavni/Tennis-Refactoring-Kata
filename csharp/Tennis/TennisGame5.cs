using System;

namespace Tennis
{
    public class TennisGame5 : ITennisGame
    {
        private int player1Score;
        private int player2Score;
        private string player1Name;
        private string player2Name;

        public TennisGame5(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == player1Name)
                player1Score++;
            else if (playerName == player2Name)
                player2Score++;
            else
                throw new ArgumentException("Invalid player name.");
        }

        public string GetScore()
        {
            if (player1Score == player2Score)
                return GetTiedScore(player1Score);
            
            if (player1Score >= 4 || player2Score >= 4)
                return GetAdvantageOrWinScore();
            
            return GetRegularScore();
        }

        private static string GetTiedScore(int score)
        {
            return score switch
            {
                0 => "Love-All",
                1 => "Fifteen-All",
                2 => "Thirty-All",
                _ => "Deuce"
            };
        }

        private string GetAdvantageOrWinScore()
        {
            var scoreDifference = player1Score - player2Score;

            return scoreDifference switch
            {
                1 => $"Advantage {player1Name}",
                -1 => $"Advantage {player2Name}",
                >= 2 => $"Win for {player1Name}",
                _ => $"Win for {player2Name}"
            };
        }

        private string GetRegularScore()
        {
            return $"{GetScoreName(player1Score)}-{GetScoreName(player2Score)}";
        }

        private static string GetScoreName(int score)
        {
            return score switch
            {
                0 => "Love",
                1 => "Fifteen",
                2 => "Thirty",
                3 => "Forty",
                _ => throw new ArgumentException("Invalid score.")
            };
        }
    }
}