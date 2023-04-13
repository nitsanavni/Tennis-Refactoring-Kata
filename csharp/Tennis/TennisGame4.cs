using System;

namespace Tennis
{
    public class TennisGame4 : ITennisGame
    {
        private int player1Score;
        private int player2Score;
        private string player1Name;
        private string player2Name;

        public TennisGame4(string player1Name, string player2Name)
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
            int p1 = player1Score;
            int p2 = player2Score;

            while (p1 > 4 || p2 > 4)
            {
                p1--;
                p2--;
            }

            if (p1 == 0 && p2 == 0) return "Love-All";
            if (p1 == 0 && p2 == 1) return "Love-Fifteen";
            if (p1 == 0 && p2 == 2) return "Love-Thirty";
            if (p1 == 0 && p2 == 3) return "Love-Forty";
            if (p1 == 0 && p2 == 4) return $"Win for {player2Name}";
            if (p1 == 1 && p2 == 0) return "Fifteen-Love";
            if (p1 == 1 && p2 == 1) return "Fifteen-All";
            if (p1 == 1 && p2 == 2) return "Fifteen-Thirty";
            if (p1 == 1 && p2 == 3) return "Fifteen-Forty";
            if (p1 == 1 && p2 == 4) return $"Win for {player2Name}";
            if (p1 == 2 && p2 == 0) return "Thirty-Love";
            if (p1 == 2 && p2 == 1) return "Thirty-Fifteen";
            if (p1 == 2 && p2 == 2) return "Thirty-All";
            if (p1 == 2 && p2 == 3) return "Thirty-Forty";
            if (p1 == 2 && p2 == 4) return $"Win for {player2Name}";
            if (p1 == 3 && p2 == 0) return "Forty-Love";
            if (p1 == 3 && p2 == 1) return "Forty-Fifteen";
            if (p1 == 3 && p2 == 2) return "Forty-Thirty";
            if (p1 == 3 && p2 == 3) return "Deuce";
            if (p1 == 3 && p2 == 4) return $"Advantage {player2Name}";
            if (p1 == 4 && p2 == 0) return $"Win for {player1Name}";
            if (p1 == 4 && p2 == 1) return $"Win for {player1Name}";
            if (p1 == 4 && p2 == 2) return $"Win for {player1Name}";
            if (p1 == 4 && p2 == 3) return $"Advantage {player1Name}";
            if (p1 == 4 && p2 == 4) return "Deuce";
            
            throw new ArgumentException("Invalid score.");
        }
    }
}
