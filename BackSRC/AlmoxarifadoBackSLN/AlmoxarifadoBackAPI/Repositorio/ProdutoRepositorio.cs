using AlmoxarifadoBackAPI.Models;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public class CategoriaRepositorio : IProdutoRepositorio
    {
        private readonly Context _db;

        public ProdutoRepositorio(Context db)
        {
            _db = db;
        }

        public void Add(Categoria categoria)
        {

            _db.Categoria.Add(categoria);
            _db.SaveChanges();
        }

        public List<Produto> GetAll()
        {
            return _db.Categoria.ToList();
        }

    }
}

