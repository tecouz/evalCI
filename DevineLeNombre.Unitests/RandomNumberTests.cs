namespace DevineLeNombre.Unitests
{
    [TestClass]
    public class RandomNumberGameTests
    {
        [TestMethod]
        public void Test_Guess_LessThanTarget()
        {
            // Arrange
            var game = new RandomNumberGame();
            int target = game.GetRandomNumber();

            int lowerGuess = target > 1 ? target - 1 : 1;

            // Act
            string result = game.Guess(lowerGuess); // Un nombre plus petit

            // Assert
            Assert.AreEqual("C'est plus grand !", result);
        }

        [TestMethod]
        public void Test_Guess_GreaterThanTarget()
        {
            // Arrange
            var game = new RandomNumberGame();
            int target = game.GetRandomNumber();

            // Act
            string result = game.Guess(target + 1); // Un nombre plus grand

            // Assert
            Assert.AreEqual("C'est plus petit !", result);
        }

        [TestMethod]
        public void Test_Guess_EqualToTarget()
        {
            // Arrange
            var game = new RandomNumberGame();
            int target = game.GetRandomNumber();

            // Act
            string result = game.Guess(target); // Le bon nombre

            // Assert
            Assert.AreEqual($"Bravo ! Vous avez trouvé le nombre mystère {target} en 1 tentatives.", result);
        }

        [TestMethod]
        public void Test_Guess_OutOfBounds_Lower()
        {
            // Arrange
            var game = new RandomNumberGame();

            // Act
            string result = game.Guess(0); // Hors de la plage valide (inf�rieure � 1)

            // Assert
            Assert.AreEqual("Veuillez entrer un nombre entre 1 et 100.", result);
        }

        [TestMethod]
        public void Test_Guess_OutOfBounds_Upper()
        {
            // Arrange
            var game = new RandomNumberGame();

            // Act
            string result = game.Guess(101); // Hors de la plage valide (sup�rieure � 100)

            // Assert
            Assert.AreEqual("Veuillez entrer un nombre entre 1 et 100.", result);
        }

        [TestMethod]
        public void Test_Guess_InvalidInput()
        {
            // Arrange
            var game = new RandomNumberGame();

            // Act
            string result = game.Guess(-1); // Un nombre en dehors de la plage valide

            // Assert
            Assert.AreEqual("Veuillez entrer un nombre entre 1 et 100.", result);
        }
    }
}