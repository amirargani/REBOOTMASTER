using System.Text;
using REBOOTMASTER.Utility;

namespace REBOOTMASTER.Tests.Utility
{
    public class SecurityTests
    {
        [Fact]
        public void CreateSHA256Hash_ReturnsConsistentHash()
        {
            // Arrange
            string input = "TestPassword123";

            // Act
            string hash1 = Security.CreateSHA256Hash(input);
            string hash2 = Security.CreateSHA256Hash(input);

            // Assert
            Assert.NotNull(hash1);
            Assert.Equal(hash1, hash2);
        }

        [Fact]
        public void CreateSHA256Hash_ReturnsDifferentHashForDifferentInput()
        {
            // Arrange
            string input1 = "TestPassword123";
            string input2 = "DifferentPassword";

            // Act
            string hash1 = Security.CreateSHA256Hash(input1);
            string hash2 = Security.CreateSHA256Hash(input2);

            // Assert
            Assert.NotEqual(hash1, hash2);
        }

        [Fact]
        public void CreateEncryptedDataBase64_And_GetString_WorkTogether()
        {
            // Arrange
            string originalText = "SensitiveData_456";

            // Act
            string encryptedBase64 = Security.CreateEncryptedDataBase64(originalText);
            string decryptedText = Security.GetString(encryptedBase64);

            // Assert
            Assert.Equal(originalText, decryptedText);
        }

        [Fact]
        public void EncryptData_And_DecryptData_WorkTogether()
        {
            // Arrange
            byte[] originalData = Encoding.UTF8.GetBytes("BinarySensitiveData");
            byte[] key = new byte[32];
            System.Security.Cryptography.RandomNumberGenerator.Fill(key);

            // Act
            byte[] iv;
            byte[] encryptedData = Security.EncryptData(originalData, key, out iv);
            byte[] decryptedData = Security.DecryptData(encryptedData, key, iv);

            // Assert
            Assert.Equal(originalData, decryptedData);
        }

        [Fact]
        public void GetString_ReturnsNull_ForEmptyInput()
        {
            // Act
            string result = Security.GetString("");

            // Assert
            Assert.Null(result);
        }
    }
}