using System.Reflection;

namespace REBOOTMASTER.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Program_IsAlreadyRunning_ReturnsBoolean()
        {
            // Since Program is internal and its methods are private/internal, 
            // we use reflection to call IsAlreadyRunning for testing.
            
            var programType = typeof(REBOOTMASTER.Main).Assembly.GetType("REBOOTMASTER.Program");
            Assert.NotNull(programType);

            var method = programType.GetMethod("IsAlreadyRunning", BindingFlags.Static | BindingFlags.NonPublic);
            Assert.NotNull(method);

            var result = method.Invoke(null, null);
            Assert.IsType<bool>(result);
        }
    }
}