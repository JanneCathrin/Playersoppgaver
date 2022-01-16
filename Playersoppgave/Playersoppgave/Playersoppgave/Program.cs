using System;

namespace Playersoppgave
{
    class Program
    {
        static void Main(string[] args)
        {
         

            
            var players = new[]
            { 
                new Player("Per", 10), 
                new Player("Pål", 10), 
                new Player("Espen", 10) 
            
            };

            for (var round = 1; round <= 10; round++)
            {
                var playerIndex1 = players[0].RandomGen.Next(players.Length);
                var playerIndex2 = (playerIndex1 + 1 + players[1].RandomGen.Next(2)) % players.Length;
                var player1 = players[playerIndex1];
                var player2 = players[playerIndex2];
                player1.Play(player2);
            }

            foreach (var player in players)
            {
                player.ShowNameAndPoints();
            }

        }
    }
}
