using Richter.DesignPattern.Prototype.DeepCopy;

namespace Richter.DesignPattern.Prototype
{
    public class AddressDeepCopy : IDeepCopy<AddressDeepCopy>
    {
        public string CEP { get; set; }
        public string City { get; set; }
        public int Number { get; set; }
        public string Street { get; set; }

        public void CopyTo(AddressDeepCopy target)
        {
            target.CEP = CEP;
            target.City = City;
            target.Number = Number;
            target.Street = Street;
        }
    }
}
