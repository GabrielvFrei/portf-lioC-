using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace atividadeVinho
{
    internal class Vinho
    {
        private String nome;
        private String tipo;
        private double preco;
        private int safra;

        public string mostrarVinho()
        {
            return $"Nome do vinho: {nome} \r\n tipo do vinho: {tipo} \r\n Preço do vinho: {preco}\r\n Safra do Vinho: {safra}";
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome() {
            return this.nome;
        }
        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }
        public string getTipo()
        {
            return this.tipo;
        }
        public void setPreco(double preco)
        {
            this.preco = preco;
        }
        public double getPreco()
        {
            return this.preco;
        }
        public void setSafra(int safra)
        {
            this.safra = safra;
        }
        public int getSafra()
        {
            return this.safra;
        }

        public Boolean verificaPreco() {
            if (preco < 25)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}