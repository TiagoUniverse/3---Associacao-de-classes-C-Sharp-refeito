using System;

namespace _3___Associacao_de_classes_C_Sharp_refeito
{

    class Professor
    {
        private string nome;
        private string sexo;
        private string chapa;
        private string cpf;
        private string identidade;


        public string getNome()
        {
            return nome;
        }

        public string getSexo()
        {
            return sexo;
        }

        public string getChapa()
        {
            return chapa;
        }

        public string getCpf()
        {
            return cpf;
        }

        public string getIdentidade()
        {
            return identidade;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setSexo(string sexo)
        {
            this.sexo = sexo;
        }

        public void setChapa(string chapa)
        {
            this.chapa = chapa;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public void setIdentidade(string identidade)
        {
            this.identidade = identidade;
        }

    }

}
