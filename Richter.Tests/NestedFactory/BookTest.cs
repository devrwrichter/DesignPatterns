using FluentAssertions;
using Richter.DesignPattern.NestedFactory;
using Xunit;

namespace Richter.Tests.NestedFactory
{
    public class BookTest
    {
        [Fact]
        public void Factory_Book_ShouldBeOk()
        {
            //Arrange & Action
            var result = Book.Factory.GetBook("John Grogan", "Marley and Me");

            //Assert
            result.Author.Should().Be("John Grogan");
            result.Title.Should().Be("Marley and Me");
        }
    }
}
