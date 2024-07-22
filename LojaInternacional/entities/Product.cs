using System.Globalization;

namespace LojaInternacional.entities
{
    internal class Product
    {        
        public string name { get; set; }
        public double price { get; set; }

        
        public Product()
        {
        }

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        
        public virtual string PriceTag()
        {
            string valorFormatado = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", this.price);
            return $"Name: {this.name}\nPrice: {valorFormatado}";
        }
    }
}
