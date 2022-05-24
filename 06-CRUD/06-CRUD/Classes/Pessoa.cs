using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_CRUD.Classes
{
    public class Pessoa
    {
        #region "Variáveis"
        private int _id_pessoa;
        private string _nome;
        private string _email;
        private string _fone;
        private string _dtnasc;
        private string _sexo;
        private string _foto;
        private int _ativo;
        #endregion


        #region "Propriedades"
        public int Id_pessoa
        {
            get { return _id_pessoa; }
            set { _id_pessoa = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Fone
        {
            get { return _fone; }
            set { _fone = value; }
        }

        public string Dtnasc
        {
            get { return _dtnasc; }
            set { _dtnasc = value; }
        }

        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        public string Foto
        {
            get { return _foto; }
            set { _foto = value; }
        }

        public int Ativo
        {
            get { return _ativo; }
            set { _ativo = value; }
        }
        #endregion


        #region "Construtores"
        public Pessoa()
        //Construtor padrão
        {
            Id_pessoa = 0;
            Nome = string.Empty;
            Email = string.Empty;
            Fone = string.Empty;
            Dtnasc = string.Empty;
            Sexo = string.Empty;
            Foto = string.Empty;
            Ativo = 0;
        }
        #endregion

        public Pessoa(string nome, string email, string fone, string dtnasc, string sexo, string foto, int ativo)
        {
            //Construtor para adicionar uma pessoa
            Nome = nome;
            Email = email;
            Fone = fone;
            Dtnasc = dtnasc;
            Sexo = sexo;
            Foto = foto;
            Ativo = ativo;
        }

        public Pessoa(int id_pessoa, string nome, string email, string fone, string dtnasc, string sexo)
        {
            //Construtor para alterar uma pessoa
            Id_pessoa = Id_pessoa;
            Nome = nome;
            Email = email;
            Fone = fone;
            Dtnasc = dtnasc;
            Sexo = sexo;
        }

        public Pessoa(int id_pessoa, int ativo)
        {
            //Construtor para ativar/desativar uma pessoa
            Id_pessoa = Id_pessoa;
            Ativo = ativo;
        }

        public Pessoa(int id_pessoa, string foto)
        {
            //Construtor para alterar a foto de uma pessoa
            Id_pessoa = Id_pessoa;
            Foto = foto;
        }


        public Pessoa(int id_pessoa)
        {
            //Construtor para buscar uma pessoa
            Id_pessoa = Id_pessoa;
        }

        public void Cadastrapessoa()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = String.Format("INSERT INTO tab_pessoas (nome, email, fone, dtnasc, sexo, foto, ativo)";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
