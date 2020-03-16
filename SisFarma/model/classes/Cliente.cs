using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisFarma.model.classes
{
    class Cliente
    {
        private int id;
        private String nome;
        private String cpf;
        private String rg;
        private DateTime dataNasc;
        private String sexo;
        private String telefone;
        private String cep;
        private String cidade;
        private String logradouro;
        private int numero;

        public Cliente()
        {

        }

        public Cliente(int id,string nome,string cpf,string rg,
            DateTime dataNasc,string sexo,string telefone,string cep,
            string cidade,string logradouro,int numero)  
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.rg = rg;
            this.dataNasc = dataNasc;
            this.sexo = sexo;
            this.telefone = telefone;
            this.cep = cep;
            this.cidade = cidade;
            this.logradouro = logradouro;
            this.numero = numero;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public String CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public DateTime DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }

        public String Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }

        public String CEP
        {
            get { return cep; }
            set { cep = value; }
        }

        public String Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }


        public String Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public String Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public String Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { this.numero = value; }
        }

    }
}
