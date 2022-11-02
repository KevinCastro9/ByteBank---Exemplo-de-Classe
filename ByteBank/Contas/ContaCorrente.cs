using ByteBank.Titular;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Contas
{
    //Classe conta corrente do banco ByteBank
    public class ContaCorrente
    {       
        public Cliente Titular { get; set; } //referenciando a classe Cliente dentro do classe ContaCorrente

        //Variaveis
        private int _numeroAgencia;
        private double _saldo = 100;

        public string Conta { get; set; }  //Propriedade autoimplementada: quando não é necessario fazer nenhuma validação

        //Propriedades  
        public int NumeroAgencia { get { return this._numeroAgencia; } private set { this._numeroAgencia = value > 0 ? value : this._numeroAgencia; } } //Private set deixa a propriedade visivel apenas dentro da classe
        public double Saldo { get { return this._saldo; } set { this._saldo = value > 0 ? value : this._saldo; } }


        //metodo construtor
        public ContaCorrente(Cliente titular, int numeroAgencia, string conta)
        {
            Titular = titular;
            NumeroAgencia = numeroAgencia;
            Conta = conta;
        }

        //metodo para depositar um novo valor a conta somando o mesmo com o saldo.
        public void DepositarValor(double valor)
        {
            this._saldo += valor;
        }

        //metodo para sacar um valor da conta subtraindo o mesmo do saldo.
        public bool SacarValor(double valor)
        {
            if (valor <= this._saldo)
            {
                this._saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        //metodo para transferir um valor de uma conta para a outra subtraindo o valor e somando ao destino
        public bool TranferirValor(double valor, ContaCorrente destino)
        {
            if (this._saldo < valor)
            {

                return false;
            }
            else
            {
                SacarValor(valor);
                destino.DepositarValor(valor);
                return true;
            }
        }

        //metodo para printar os dados do objeto
        public void MostrarDados()
        {
            Console.WriteLine("Titular : " + this.Titular.Nome);
            Console.WriteLine("Cpf : " + this.Titular.Cpf);
            Console.WriteLine("Profissao : " + this.Titular.Profissao);
            Console.WriteLine("Conta : " + this.Conta);
            Console.WriteLine("Número Agência : " + this._numeroAgencia);
            Console.WriteLine($"Saldo da conta João R$ {string.Format("{0:0.00}", this._saldo)}");
        }
    }
}
