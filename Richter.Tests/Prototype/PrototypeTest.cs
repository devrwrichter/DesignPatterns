using Richter.DesignPattern.Prototype;
using Richter.DesignPattern.Prototype.Help;
using Richter.DesignPattern.Prototype.RecordType;
using System.Collections.Generic;
using Xunit;

namespace Richter.Tests.Prototype
{
    /// <summary>
    /// Design pattern Prototype test
    /// </summary>
    public class PrototypeTest
    {
        [Fact]
        public void ReferenceProblem()
        {
            //Arrange
            var order = new Order
            {
                Items = new List<Product> {
                new Product { Id = 1, Name = "Sabão", Value = 5.00M },
                new Product { Id = 2, Name = "Shampoo", Value = 6.00M } }
            };

            //Action
            var orderCopy = order;
            orderCopy.Items.Add(new Product { Id = 3, Name = "Óleo", Value = 18.00M });

        }

        [Fact]
        public void ReferenceProblemCorrect()
        {
            //Arrange
            var order = new OrderDeepCopy
            {
                Items = new List<Product> {
                new Product { Id = 1, Name = "Sabão", Value = 5.00M },
                new Product { Id = 2, Name = "Shampoo", Value = 6.00M } }, 
                Address =  new AddressDeepCopy { Number = 10 }
            };

            //Action
            OrderDeepCopy orderCopy = order.DeepCopy();

            //Inclusão de item não afeta mais o objeto original
            orderCopy.Items.Add(new Product { Id = 3, Name = "Óleo", Value = 18.00M });
            
            //Alteração do Number não afeta mais o objeto original
            orderCopy.Address.Number = 25;

        }

        [Fact]
        public void SerializableProblemCorrect()
        {
            //Arrange
            var order = new OrderSerializable
            {
                Items = new List<ProductSerializable> {
                new ProductSerializable { Id = 1, Name = "Sabão", Value = 5.00M },
                new ProductSerializable { Id = 2, Name = "Shampoo", Value = 6.00M } },
                Address = new AddressSerializeble { Number = 10 }
            };

            //Action
            OrderSerializable orderCopy = order.DeepCopyWithSerialization();
            orderCopy.Items.Add(new ProductSerializable { Id = 3, Name = "Óleo", Value = 18.00M });
            orderCopy.Address.Number = 25;

        }

        [Fact]
        public void ReferenceRecord()
        {
            //Arrange
            var address = new AddressRecord { CEP = "09999-115", City = "SP", Number = 10, Street = "Rua Pedra" };

            //Action
            var addressCopy = address with { Number = 25 };
        }

        [Fact]
        public void ReferenceIMemberWiseCloneProblem()
        {
            //Arrange
            var order = new OrderWithICloneable
            {
                Items = new List<Product> {
                new Product { Id = 1, Name = "Sabão", Value = 5.00M },
                new Product { Id = 2, Name = "Shampoo", Value = 6.00M } }
            };

            //Action
            var orderCopy = order;
            orderCopy.Items.Add(new Product { Id = 3, Name = "Óleo", Value = 18.00M });

        }
    }
}
