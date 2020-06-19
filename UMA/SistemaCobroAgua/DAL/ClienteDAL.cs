using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//se agrega la carpeta de modelos o clases singulares con propiedades
using SistemaCobroAgua.Modelos;

namespace SistemaCobroAgua.DAL
{
    public class ClienteDAL
    {
        //inicio de base de datos conexion
        private CobroAguaContext db = new CobroAguaContext();
        //lista
        public List<Cliente> ObtenerClientes()
        {
            return db.Clientes.ToList();
        }
        //detalles
        public Cliente ObtenerCliente(int id)
        {
            Cliente cliente = db.Clientes.Find(id);
            return cliente;
        }
        //creacion de datos
        public void CrearCliente(Cliente pCliente)
        {
            db.Clientes.Add(pCliente);
            db.SaveChanges();
        }
        //edicion de datos
        public void EditarCliente(Cliente pCliente)
        {
            db.Entry(pCliente).State = EntityState.Modified;
            db.SaveChanges();
        }
        //eliminacion de datos
        public void EliminarCliente(int id)
        {
            Cliente cliente = db.Clientes.Find(id);
            db.Clientes.Remove(cliente);
            db.SaveChanges();
        }
        //metodo para buscar
        //busca por nombre y DUI
        public List<Cliente> Buscar(Cliente pCliente)
        {
            var Clientes = from s in db.Clientes
                           select s;
            Clientes = db.Clientes.Where(
                s => s.Nombre.ToUpper().Contains(pCliente.Nombre.ToUpper()) ||
                s.Apellido.ToUpper().Contains(pCliente.Apellido.ToUpper()) ||
                s.Nombre.ToLower().Contains(pCliente.Nombre.ToLower()) ||
                s.Apellido.ToLower().Contains(pCliente.Apellido.ToLower()) ||
                s.DUI.ToUpper().Contains(pCliente.DUI.ToUpper()) ||
                 s.DUI.ToLower().Contains(pCliente.DUI.ToLower())
                );
            return Clientes.ToList();
        }
    }
}
