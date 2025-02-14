using AlmoxarifadoBackAPI.Models;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public interface IProdutoRepositorio
    {
        void Add(Categoria categoria);

        List<Produto> GetAll();


    }
}

