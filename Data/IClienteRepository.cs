using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using customer.Models;

namespace customer.Data
{

    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> GetClientes(Cliente cliente  );   
    }   
    public class ClienteRepository:IClienteRepository
    {
        readonly IDatabaseFactory _databaseFactory; 
        public ClienteRepository(IDatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory; 
        }
        public Task<IEnumerable<Cliente>> GetClientes(Cliente cliente)
        {
            throw new System.NotImplementedException();
        }
    }
}