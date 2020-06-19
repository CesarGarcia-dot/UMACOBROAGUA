using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaCobroAgua.Modelos;

namespace SistemaCobroAgua.DAL
{
    public class AuthDAL
    {
        //inicio de base de datos conexion
        private CobroAguaContext db = new CobroAguaContext();
        public Usuario Login(Usuario pUsuario)
        {
            Usuario user = new Usuario();
            user = db.Usuarios.Where(x => x.Email == pUsuario.Email && x.Password == pUsuario.Password).FirstOrDefault();
            return user;
        }
        //creacion de datos
        public void CrearUsuario(Usuario pUsuario)
        {
            db.Usuarios.Add(pUsuario);
            db.SaveChanges();
        }
    }
}
