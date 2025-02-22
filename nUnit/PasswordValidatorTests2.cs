using NUnit.Framework;

namespace PasswordValidatorTests2
{
    [TestFixture]
    public class PasswordValidatorTests2
    {
        private PasswordValidator _validator;

        // Setup method to initialize password validator
        [SetUp]
        public void Setup()
        {
            _validator = new PasswordValidator();
        }

        // Test valid password
        [Test]
        public void test_ValidPassword()
        {
            // Arrange
            string password = "Password123";

            // Act
            bool result = _validator.IsValid(password);

            // Assert
            Assert.That(result, Is.True);
        }

        // Test password too short
        [Test]
        public void test_PasswordTooShort()
        {
            // Arrange
            string password = "Pass1";

            // Act
            bool result = _validator.IsValid(password);

            // Assert
            Assert.That(result, Is.False);
        }

        // Test password without uppercase
        [Test]
        public void test_PasswordNoUppercase()
        {
            // Arrange
            string password = "password123";

            // Act
            bool result = _validator.IsValid(password);

            // Assert
            Assert.That(result, Is.False);
        }

        // Test password without digit
        [Test]
        public void test_PasswordNoDigit()
        {
            // Arrange
            string password = "PasswordTest";

            // Act
            bool result = _validator.IsValid(password);

            // Assert
            Assert.That(result, Is.False);
        }
    }
}
