using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public string Logins
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

        //Construtor padrão
        public Login()
        {
            Id_usuario = 0;
            Nome = string.Empty;
            Email = string.Empty;
            Logins = string.Empty;
            Senha = string.Empty;
            Frase_seguranca = string.Empty;
            Nivel = 0;
            Ativo = 0;
        }

        //Construtor para Efetuar o Login
        public Login(int id_usuario, string nome, string email, string login, string senha, string frase_seguranca, int nivel, int ativo)
        {
            Id_usuario = id_usuario;
            Nome = nome;
            Email = email;
            Logins = login;
            Senha = senha;
            Frase_seguranca = frase_seguranca;
            Nivel = nivel;
            Ativo = ativo;
        }

        //Construtor para inserir usuário
        public Login(string nome, string email, string login, string senha, string frase_seguranca, int nivel, int ativo)
        {
            Nome = nome;
            Email = email;
            Logins = login;
            Senha = senha;
            Frase_seguranca = frase_seguranca;
            Nivel = nivel;
            Ativo = ativo;
        }

        //Construtor para alterar usuário
        public Login(int id_usuario, string nome, string email, string login, int nivel)
        {
            Id_usuario = id_usuario;
            Nome = nome;
            Email = email;
            Logins = login;
            Nivel = nivel;
        }

        //Construtor para ativar/desativar usuário
        public Login(int id_usuario, int ativo)
        {
            Id_usuario = id_usuario;
            Ativo = ativo;
        }

        //Construtor para alterar a senha do usuário
        public Login(int id_usuario, string senha, string frase_seguranca)
        {
            Id_usuario = id_usuario;
            Senha = senha;
            Frase_seguranca = frase_seguranca;
        }

        #endregion


        #region "Métodos"

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
                            Telas.frmPrincipal TP = new Telas.frmPrincipal(usuarioLogado);
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

        // Método para alterar a senha so usuário
        public void AlterarSenha()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = String.Format("UPDATE tab_usuarios SET senha = '{0}', frase_seguranca = '{1}' WHERE id_usuario = {2}", Senha, Frase_seguranca, Id_usuario);
                cn.comando = new SqlCommand(cn.query, cn.conexao);
                cn.AbreConexao();
                cn.comando.ExecuteNonQuery();
                MessageBox.Show("Senha alterada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        //Método para mostrar todos os usuários ativados
        public static dynamic BuscarTodosUsuariosAtivados()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = "SELECT * FROM tab_usuarios WHERE ativo = 1";
                cn.da = new SqlDataAdapter(cn.query, cn.conexao);
                cn.ds = new DataSet();
                cn.da.Fill(cn.ds, "Usuarios");
                return cn.ds.Tables["Usuarios"];
            }
            catch (Exception)
            {

                throw;
            }
        }


        //Método para mostrar todos os usuários desativados
        public static dynamic BuscarTodosUsuariosDesativados()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = "SELECT * FROM tab_usuarios WHERE ativo = 0";
                cn.da = new SqlDataAdapter(cn.query, cn.conexao);
                cn.ds = new DataSet();
                cn.da.Fill(cn.ds, "Usuarios");
                return cn.ds.Tables["Usuarios"];
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Método para inserir um usuário
        public void InsereUsuario()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = String.Format("INSERT INTO tab_usuarios (nome, email, login, senha, frase_seguranca, nivel, ativo) " +
                    "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', {5}, {6})", Nome, Email, Logins, Senha, Frase_seguranca, Nivel, Ativo);
                cn.comando = new SqlCommand(cn.query, cn.conexao);
                cn.AbreConexao();
                cn.comando.ExecuteNonQuery();
                MessageBox.Show("Usuário inserido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        //Método para alterar um usuário
        public void AlteraUsuario()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = String.Format("UPDATE tab_usuarios SET nome = '{0}', email = '{1}', " +
                    "login = '{2}', nivel = {3}" +
                    "WHERE id_usuario = {4}", Nome, Email, Logins, Nivel, Id_usuario);
                cn.comando = new SqlCommand(cn.query, cn.conexao);
                cn.AbreConexao();
                cn.comando.ExecuteNonQuery();
                MessageBox.Show("Usuário alterado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        //Método para Ativar um usuário
        public void AtivaUsuario()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = String.Format("UPDATE tab_usuarios SET ativo = 1 WHERE id_usuario = {0}", Id_usuario);
                cn.comando = new SqlCommand(cn.query, cn.conexao);
                cn.AbreConexao();
                cn.comando.ExecuteNonQuery();
                MessageBox.Show("Usuário ativado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {

                throw;
            }
        }


        //Método para desativar um usuário
        public void DesativaUsuario()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = String.Format("UPDATE tab_usuarios SET ativo = 0 WHERE id_usuario = {0}", Id_usuario);
                cn.comando = new SqlCommand(cn.query, cn.conexao);
                cn.AbreConexao();
                cn.comando.ExecuteNonQuery();
                MessageBox.Show("Usuário desativado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion
    }
}
