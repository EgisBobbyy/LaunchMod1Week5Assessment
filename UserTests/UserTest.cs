using LaunchMod1Week5Assessment;
using System.Xml.Linq;

namespace UserTests
{
    public class UserTest
    {
        // Test
        [Fact]
        public void IsCreated()
        {
            var user = new User("Eagan", "eagan@email.com", "password123");

            Assert.Equal("Eagan", user.Name);
            Assert.Equal("eagan@email.com", user.Email);
            Assert.Equal("password123", user.Password);
            Assert.False(user.IsLoggedIn);
        }

        // Test
        [Fact]
        public void SetUpComplete_ChecksForAttributes()
        {
            var user = new User("Eagan", "eagan@email.com", "password123");

            user.IsSetupComplete();

            Assert.True(user.Name);
            Assert.True(user.Email);
            Assert.True(user.Password);
        }

        // Test
        [Fact]
        public void CreatePassword_CreatesPassword()
        {
            var user = new User("Eagan", "eagan@email.com", "password123");

            user.CreatePassword();


        }

        // Test
        [Fact]
        public void LogOut_MeansNotLoggedIn()
        {
            var user = new User("Eagan", "eagan@email.com", "password123");

            user.LogOut();

            Assert.False(user.IsLoggedIn);
        }
    }
}