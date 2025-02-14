using AlmoxarifadoBackAPI.Models;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public interface IFornecedorRepositorio
    {
        void Add(Categoria categoria);

        List<Fornecedor> GetAll();


    }
}

