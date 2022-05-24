using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_CRUD.Classes
{
    public class Login
    {
        #region "Variáveis"

        private int _id_usuario;
        private string _nome;
        private string _email;
        private string _login;
        private string _senha;
        private string _frase_seguranca;
        private int _nivel;
        private int _ativo;

        #endregion

        #region "Propriedades"

       public int Id_usuario
        {
            get { return _id_usuario; }
            set { _id_usuario = value; }
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

        public string Login2
        {
            get { return _login; }
            set { _login = value; }
        }

        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        public string Frase_seguranca
        {
            get { return _frase_seguranca; }
            set { _frase_seguranca = value; }
        }

        public int Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }

        public int Ativo
        {
            get { return _ativo; }
            set { _ativo = value; }
        }

        #endregion

        #region "Construtores"

        public Login()
        {
            Id_usuario = 0;
            Nome = String.Empty;
            Email = String.Empty;
            Login2 = String.Empty;
            Senha = String.Empty;
            Frase_seguranca = String.Empty;
            Nivel = 0;
            Ativo = 0;
        }

        #endregion

        //Construtor para efeturar o login

        public Login(int id_usuario, string nome, string email, string login, string senha, string frase_seguranca, int nivel, int ativo)
        {
            Id_usuario = id_usuario;
            Nome = nome;
            Email = email;
            Login2 = login;
            Senha = senha;
            Frase_seguranca = frase_seguranca;
            Nivel = nivel;
            Ativo = ativo;
        }

        //Construtor para inserir um usuário

        public Login(string nome, string email, string login, string senha, string frase_seguranca, int nivel, int ativo)
        {
            Nome = nome;
            Email = email;
            Login2 = login;
            Senha = senha;
            Frase_seguranca = frase_seguranca;
            Nivel = nivel;
            Ativo = ativo;
        }

        //Construtor para alterar um usuário

        public Login(int id_usuario, string nome, string email, string login, int nivel, int ativo)
        {
            Id_usuario = id_usuario;
            Nome = nome;
            Email = email;
            Login2 = login;
            Nivel = nivel;
        }

        //Construtor para ativar/desativar um usuário

        public Login(int id_usuario, int ativo)
        {
            Id_usuario = id_usuario;
            Ativo = ativo;
        }

        //Construtor para alterar a senha de um usuário

        public Login(int id_usuario, string senha, int ativo)
        {
            Id_usuario = id_usuario;
            Senha = senha;
            Ativo = ativo;
        }

        //Método para efetuar o login

        public static void RealizarLogin(string login, string senha)
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = "SELECT * FROM tab_usuarios WHERE login = '" + login + "'";
                cn.comando = new SqlCommand(cn.query, cn.conexao);
                cn.AbreConexao();
                cn.dr = cn.comando.ExecuteReader();
                if (cn.dr.HasRows)
                {
                    Login usuarioLogado = new Login();
                    while (cn.dr.Read())
                    {
                        usuarioLogado = new Login(Convert.ToInt32(cn.dr["id_usuario"]), 
                            cn.dr["nome"].ToString(),
                            cn.dr["email"].ToString(),
                            cn.dr["login"].ToString(),
                            cn.dr["senha"].ToString(),
                            cn.dr["frase_seguranca"].ToString(),
                            Convert.ToInt32(cn.dr["nivel"]),
                            Convert.ToInt32(cn.dr["ativo"]));
                    }
                    if (usuarioLogado.Ativo == 1)
                    {
                        if (usuarioLogado.Senha == senha)
                        {
                            frmPrincipal TP = new frmPrincipal(usuarioLogado);
                            TP.ShowDialog();
                        }
                        else
                        {
                            throw new Exception("Senha inválida");
                        }
                    }
                    else
                    {
                        throw new Exception("Usuário bloqueado!");
                    }
                }
                else
                {
                    throw new Exception("Usuário não encontrado!");
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.FechaConexao();
            }
        }



    }
}
