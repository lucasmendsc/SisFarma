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
        private DateTime data_nasc;
        private String sexo;
        private String telefone;
        private String cep;
        private String cidade;
        private String logradouro;
        private int numero;

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

        public DateTime Data_Nasc
        {
            get { return data_nasc; }
            set { data_nasc = value; }
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
