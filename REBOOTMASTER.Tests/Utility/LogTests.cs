using System.Reflection;
using REBOOTMASTER.Utility;

namespace REBOOTMASTER.Tests.Utility
{
    public class LogTests
    {
        [Fact]
        public void Log_Logger_IsInitialized()
        {
            // Act
            var logger = Log.Logger;

            // Assert
            Assert.NotNull(logger);
        }

        [Fact]
        public void RemoveFilePath_RemovesPathAndPreservesLineNumber()
        {
            // Arrange
            string line = "   at TestNamespace.Class.Method() in C:\\dir\\file.cs:line 123";

            // Use reflection to access private RemoveFilePath method
            var method = typeof(Log).GetMethod("RemoveFilePath", BindingFlags.NonPublic | BindingFlags.Static);
            Assert.NotNull(method);

            // Act
            var result = (string)method!.Invoke(null, new object[] { line })!;

            // Assert
            Assert.Equal("at TestNamespace.Class.Method() :line 123", result.Trim());
        }

        [Fact]
        public void RemoveFilePath_RemovesPathWhenNoLineNumber()
        {
            // Arrange
            string line = "   at TestNamespace.Class.Method() in C:\\dir\\file.cs";
            var method = typeof(Log).GetMethod("RemoveFilePath", BindingFlags.NonPublic | BindingFlags.Static);
            Assert.NotNull(method);

            // Act
            var result = (string)method!.Invoke(null, new object[] { line })!;

            // Assert
            Assert.Equal("at TestNamespace.Class.Method()", result.Trim());
        }

        [Fact]
        public void RemoveFilePath_ReturnsSameWhenNoIn()
        {
            // Arrange
            string line = "   at TestNamespace.Class.Method()";
            var method = typeof(Log).GetMethod("RemoveFilePath", BindingFlags.NonPublic | BindingFlags.Static);
            Assert.NotNull(method);

            // Act
            var result = (string)method!.Invoke(null, new object[] { line })!;

            // Assert
            Assert.Equal("at TestNamespace.Class.Method()", result.Trim());
        }
    }
}