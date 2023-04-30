namespace Richter.DesignPattern.AbstractFactory
{
    internal class Hamburguer : ILunch
    {
        public string GetDescription()
        {
            return "Alface, Maionese, Pão, Haburguer e Bacon!";
        }
    }
}
