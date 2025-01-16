using System;

namespace DevineLeNombre
{
    public class RandomNumberGame
    {
        private int randomNumber;
        private int attempt;

        public RandomNumberGame()
        {
            Random random = new Random();
            randomNumber = random.Next(1, 101);
            attempt = 0;
        }

        public string Guess(int proposal)
        {
            attempt++;

            if (proposal < 1 || proposal > 100)
            {
                return "Veuillez entrer un nombre entre 1 et 100.";
            }

            if (proposal < randomNumber)
            {
                return "C'est plus grand !";
            }
            else if (proposal > randomNumber)
            {
                return "C'est plus petit !";
            }
            else
            {
                return $"Bravo ! Vous avez trouvé le nombre mystère {randomNumber} en {attempt} tentatives.";
            }
        }

        public int GetAttempts() => attempt;
        public int GetRandomNumber() => randomNumber;
    }
}
