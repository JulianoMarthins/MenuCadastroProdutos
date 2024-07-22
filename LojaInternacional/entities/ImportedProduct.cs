using System.Globalization;

namespace LojaInternacional.entities
{
    internal class ImportedProduct : Product
    {        
        public double customFee { get; set; }


        public ImportedProduct()
        {
        }

        public ImportedProduct(double customFee, string name, double price) 
            : base(name, price){

            this.customFee = customFee;
        }


        public override string PriceTag()
        {
            base.price += this.customFee;
            string impostoFormatado = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", this.customFee);
            string valorFormatado = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", this.price);
            return base.PriceTag() + $"\nImpostos: {impostoFormatado}";
        }


        public double TotalPrice(double taxaAlfandega)
        {
            return this.price + taxaAlfandega;           
        }
    }
}
