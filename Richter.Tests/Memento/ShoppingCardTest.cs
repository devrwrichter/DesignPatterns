using FluentAssertions;
using Richter.DesignPattern.Memento;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Richter.Tests.Memento
{
    public class ShoppingCardTest
    {
        [Fact]
        public void Add_Product_ShouldBeOk()
        {
            //Arrange
            var product = new Product { Name = "Product A", Value = 100.0M };
            ShoppingCard card = new();

            //Action
            card.Add(product);

            //Assert
            card.Products.FirstOrDefault().Should().Be(product);
        }

        [Fact]
        public void Undo_MementoUndo_ShouldBeRemoveProduct()
        {
            //Arrange
            var product = new Product { Name = "Product A", Value = 100.0M };
            var product2 = new Product { Name = "Product B", Value = 80.0M };
            ShoppingCard card = new();

            //Action
            card.Add(product);
            card.Add(product2);
            card.Undo();

            //Assert
            card.Products.FirstOrDefault().Should().Be(product);
        }

        [Fact]
        public void Undo_Redo_Memento_ShouldBeReturnTheProduct()
        {
            //Arrange
            var product = new Product { Name = "Product A", Value = 100.0M };
            var product2 = new Product { Name = "Product B", Value = 80.0M };
            ShoppingCard card = new();

            //Action
            card.Add(product);
            card.Add(product2);
            card.Undo();
            

            //Assert
            card.Products.FirstOrDefault().Should().Be(product);

            //Action 2 
            card.Redo();

            //Assert 2
            card.Products.FirstOrDefault().Should().Be(product);
            card.Products.LastOrDefault().Should().Be(product2);
        }


        [Fact]
        public void Restore_RestoreSpecificState_ShouldBeOk()
        {
            //Arrange
            var product = new Product { Name = "Product A", Value = 100.0M };
            var product2 = new Product { Name = "Product B", Value = 80.0M };
            var product3 = new Product { Name = "Product C", Value = 60.0M };
            var product4 = new Product { Name = "Product D", Value = 40.0M };
            ShoppingCard card = new();

            //Action
            card.Add(product);
            card.Add(product2);
            card.Add(product3);
            var state = card.Add(product4);


            //Assert
            card.Products.Should().HaveCount(4);

            //Action 2 
            card.Remove(product2);

            //Assert 2
            card.Products.Should().HaveCount(3);

            //Action 3
            card.Restore(state);
            card.Products.Should().HaveCount(4);
        }
    }
}
