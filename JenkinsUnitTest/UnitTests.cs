using JenkinsTest;
using Xunit;

namespace JenkinsUnitTest
{
    public class UnitTests
    {
        [Fact]
        public void PassingTest()
        {
            var a = new Program();

            Assert.Matches("Hello Jenkins", a.HelloJenkins());
        }

        [Fact]
        public void PassingTest2()
        {
            var a = new Program();

            Assert.Matches("Hello Jenkins", a.HelloJenkins());
        }

        [Fact]
        public void PassingTest3()
        {
            var a = new Program();

            Assert.Equal(2,a.Add(1,1));
        }

        [Fact]
        public void FailingTest()
        {
            var a = new Program();

            Assert.Matches("Hello Jenkinss", a.HelloJenkins());
        }

    }
}
