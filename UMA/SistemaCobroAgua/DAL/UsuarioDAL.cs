using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaCobroAgua.Modelos;

namespace SistemaCobroAgua.DAL
{
    public class UsuarioDAL
    {
        //inicio de base de datos conexion
        private CobroAguaContext db = new CobroAguaContext();
        //lista
        public List<Usuario> ObtenerUsuarios()
        {
            return db.Usuarios.ToList();
        }
        //detalles
        public Usuario ObtenerUsuario(int id)
        {
            Usuario usuario = db.Usuarios.Find(id);
            return usuario;
        }
        //creacion de datos
        public void CrearUsuario(Usuario pUsuario)
        {
            db.Usuarios.Add(pUsuario);
            db.SaveChanges();
        }
        //edicion de datos
        public void EditarUsuario(Usuario pUsuario)
        {
            db.Entry(pUsuario).State = EntityState.Modified;
            db.SaveChanges();
        }
        //eliminacion de datos
        public void EliminarUsuario(int id)
        {
            Usuario usuario = db.Usuarios.Find(id);
            db.Usuarios.Remove(usuario);
            db.SaveChanges();
        }
        //metodo para buscar
        //busca por nombre y DUI
        public List<Usuario> Buscar(string pUsuario)
        {            
            var Usuarios = from s in db.Usuarios
                           select s;
            Usuarios = db.Usuarios.Where(
                s => s.Nombre.ToUpper().Contains(pUsuario.ToUpper()) ||
                s.Apellido.ToUpper().Contains(pUsuario.ToUpper()) ||
                s.Nombre.ToLower().Contains(pUsuario.ToLower()) ||
                s.Apellido.ToLower().Contains(pUsuario.ToLower()) ||
                s.DUI.ToUpper().Contains(pUsuario.ToUpper()) ||
                 s.DUI.ToLower().Contains(pUsuario.ToLower()) ||
                 s.Email.ToUpper().Contains(pUsuario.ToUpper()) ||
                 s.Email.ToLower().Contains(pUsuario.ToLower())
                );
            return Usuarios.ToList();
        }
    }
}
