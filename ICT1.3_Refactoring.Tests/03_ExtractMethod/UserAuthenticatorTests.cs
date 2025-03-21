namespace ICT1._3_Refactoring.Tests.ExtractMethod;

public class UserAuthenticatorTests
{
    private class TestUserAuthenticator : UserAuthenticator
    {
        private readonly Dictionary<string, string> userPasswords;

        public TestUserAuthenticator()
        {
            userPasswords = new Dictionary<string, string>
                {
                    // Pre-computed SHA-256 hash of "password123" is "EF92B778BAFE771E89245B89ECBC08A44A4E166C06659911881F383D4473E94F"
                    { "alice", "EF92B778BAFE771E89245B89ECBC08A44A4E166C06659911881F383D4473E94F" }
                };
        }

        public override string ExecuteQuery(string qry)
        {
            // Simple mock implementation that returns password for valid usernames
            var username = qry.Split("'")[1]; // Basic SQL parsing for test purposes
            return userPasswords.GetValueOrDefault(username, string.Empty);
        }
    }

    private readonly TestUserAuthenticator authenticator;

    public UserAuthenticatorTests()
    {
        authenticator = new TestUserAuthenticator();
    }

    [Theory]
    [InlineData("alice", true)]
    [InlineData("nonexistent", false)]
    [InlineData("", false)]
    [InlineData(null, false)]
    public void AuthenticateUser_WhenValidUsernameThenReturnsTrueElseReturnsFalse(string? username, bool expectedResult)
    {
        // Arrange
        //string username = "alice";
        string password = "password123";

        // Act
        bool result = authenticator.AuthenticateUser(username!, password);

        // Assert
        Assert.Equal(expectedResult, result);
    }


    [Fact]
    public void AuthenticateUser_InvalidPassword_ReturnsFalse()
    {
        // Arrange
        string username = "alice";
        string password = "wrongpassword";

        // Act
        bool result = authenticator.AuthenticateUser(username, password);

        // Assert
        Assert.False(result);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void AuthenticateUser_EmptyOrNullUsername_ReturnsFalse(string? username)
    {
        // Arrange
        string password = "password123";

        // Act
        bool result = authenticator.AuthenticateUser(username!, password);

        // Assert
        Assert.False(result);
    }
}