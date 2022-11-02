using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Titular
{
    public class Cliente
    {
        //Propriedades autoimplementada: quando não é necessario fazer nenhuma validação
        public string Nome { get; set; }
        public string Profissao { get; set; }

        private decimal _cpf;

        //Propriedades
        public decimal Cpf { get { return this._cpf; } set { this._cpf = value.ToString().Length == 11 ? value : this._cpf; } }

        //metodo construtor
        public Cliente(string nome, decimal cpf, string profissao)
        {
            this.Nome = nome;
            this._cpf = cpf;
            this.Profissao = profissao;
        }

        //metodo para printar os dados do objeto
        public void MostrarDados()
        {
            Console.WriteLine("Titular : " + this.Nome);
            Console.WriteLine("Cpf : " + this.Cpf);
            Console.WriteLine("Profissao : " + this.Profissao);
        }
    }
}
