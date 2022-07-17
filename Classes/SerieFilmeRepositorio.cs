using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static cadastro_tentativa2.Interface.IRepositorio;

namespace cadastro_tentativa2.Classes
{
    public class SerieFilmeRepositorio : IRepositorio<SerieFilmes>
    {
        private List<SerieFilmes> lista = new List<SerieFilmes>();
        public void Atualiza(int id, SerieFilmes objeto)
        {
            lista[id] = objeto;
        }

        public void Exclui(int id)
        {
            lista[id].Excluir();
        }
        public void Insere(SerieFilmes objeto)
        {
            lista.Add(objeto);
        }

        public List<SerieFilmes> Lista()
        {
            return lista;
        }

        public int ProximoId()
        {
            return lista.Count;
        }

        public SerieFilmes RetornaPorId(int id)
        {
            return lista[id];
        }
    }
}