using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cadastro_tentativa2.Enum;

namespace cadastro_tentativa2.Classes
{
    public class SFcrud : SerieFilmeRepositorio
    {
        int indiceSerie;
        public void ListarSeries(SFcrud objeto)
        {
            Console.WriteLine("Listar séries");

            var lista = objeto.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach (var serieFilme in lista)
            {
                var excluido = serieFilme.retornaExcluido();

                Console.WriteLine("#ID {0}: - {1} {2}", serieFilme.retornaId(), serieFilme.retornaTitulo(), (excluido ? "*Excluído*" : ""));
            }
        }

        public void VisualizarSerie(SFcrud objeto)
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = objeto.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
        }
        public void ExcluirSerie(SFcrud objeto)
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            objeto.Exclui(indiceSerie);
        }    
    }
}