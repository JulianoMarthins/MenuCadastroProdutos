
namespace LojaInternacional.entities
{
    internal class UsedProduct : Product
    {                   

        // Construtores
        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price)
            : base(name, price)
        {          

        }


        // Métodos
        public override string PriceTag()
        {
            return base.PriceTag();
        }


    }
}
