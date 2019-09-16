using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.Entity;
using SIS_Ga2.DataAccess;

namespace SIS_Ga2.Business
{
    public class ClienteBL
    {
        //Metodo de Logica de datos : Registrar para la tabla cliente
        public bool Registrar(Cliente cliente)
        {
            ClienteDAO objDAO = new ClienteDAO();
            return objDAO.Registrar(cliente);
        }
        public bool Actualizar(Cliente cliente)
        {
            ClienteDAO objDAO = new ClienteDAO();
            return objDAO.Actualizar(cliente);
        }


        /// <summary>
        /// Listar el cliente por el ID Cliente
        /// Si el Id = 0 se podra listar todos los clientes
        /// </summary>
        /// <param name="IdCliente"></param>
        /// <returns></returns>
        public List<Cliente> ListarClienteByID(int IdCliente)
        {
            ClienteDAO objDAO = new ClienteDAO();
            return objDAO.ListarClienteByID(IdCliente);
        }

    }
}
