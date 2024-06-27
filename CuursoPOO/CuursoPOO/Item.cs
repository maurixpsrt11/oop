using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CuursoPOO
{
    public class Item
    {
        private const int PadraoQuant = 1;
       public int Quantidade { get; set; } ///caso queirra  só pegar  sem tratar
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public decimal Total => Preco * Quantidade;

        public string totalFormatado => Total.ToString("C");// C = Curency = Moeda
       

        public Item()
        {
            Quantidade = PadraoQuant;
        }

        public void exibeQuant()
        {
            /// codigo aqui 
        }

        public  static  Item CriarBola()
        {
            var bola = new Item();
            bola.Nome = "JABulane";
            bola.Quantidade = 1;
            bola.Preco = 2.2M;
            return bola;
        }


    }


    

}
