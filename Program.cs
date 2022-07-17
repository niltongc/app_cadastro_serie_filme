using cadastro_tentativa2.Classes;
using cadastro_tentativa2.Enum;

SFcrud repositorio = new SFcrud();

string opcaoUsuario = ObterOpcaoUsuario();

while (opcaoUsuario.ToUpper() != "X")
{
    switch (opcaoUsuario)
    {
        case "1":
            repositorio.ListarSeries(repositorio);
            break;
        case "2":
            InserirSerie(repositorio);
            break;
        case "3":
            AtualizarSerie(repositorio);
            break;
        case "4":
            repositorio.ExcluirSerie(repositorio);
            break;
        case "5":
            repositorio.VisualizarSerie(repositorio);
            break;
        case "C":
            Console.Clear();
            break;

        default:
            throw new ArgumentOutOfRangeException();
    }

    opcaoUsuario = ObterOpcaoUsuario();
}

Console.WriteLine("Obrigado por utilizar nossos serviços.");
Console.ReadLine();

static void InserirSerie(SFcrud objeto)
{
    Console.WriteLine("Inserir nova série");

    foreach (int i in Enum.GetValues(typeof(Genero)))
    {
        Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
    }
    Console.Write("Digite o gênero entre as opções acima: ");
    int entradaGenero = int.Parse(Console.ReadLine());

    Console.Write("Digite o Título da Série: ");
    string entradaTitulo = Console.ReadLine();

    Console.Write("Digite o Ano de Início da Série: ");
    int entradaAno = int.Parse(Console.ReadLine());


    Console.Write("Digite a Descrição da Série: ");
    string entradaDescricao = Console.ReadLine();

    SerieFilmes novaSerie = new SerieFilmes(id: objeto.ProximoId(),
                                genero: (Genero)entradaGenero,
                                titulo: entradaTitulo,
                                ano: entradaAno,
                                descricao: entradaDescricao);

    objeto.Insere(novaSerie);
}

static void AtualizarSerie(SFcrud objeto)
{
    Console.Write("Digite o id da série: ");
    int indiceSerie = int.Parse(Console.ReadLine());

    foreach (int i in Enum.GetValues(typeof(Genero)))
    {
        Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
    }
    Console.Write("Digite o gênero entre as opções acima: ");
    int entradaGenero = int.Parse(Console.ReadLine());

    Console.Write("Digite o Título da Série: ");
    string entradaTitulo = Console.ReadLine();

    Console.Write("Digite o Ano de Início da Série: ");
    int entradaAno = int.Parse(Console.ReadLine());

    Console.Write("Digite a Descrição da Série: ");
    string entradaDescricao = Console.ReadLine();

    SerieFilmes atualizaSerie = new SerieFilmes(id: indiceSerie,
                                genero: (Genero)entradaGenero,
                                titulo: entradaTitulo,
                                ano: entradaAno,
                                descricao: entradaDescricao);

    objeto.Atualiza(indiceSerie, atualizaSerie);
}

static string ObterOpcaoUsuario()
{
    Console.WriteLine();
    Console.WriteLine("DIO Séries a seu dispor!!!");
    Console.WriteLine("Informe a opção desejada:");

    Console.WriteLine("1- Listar séries");
    Console.WriteLine("2- Inserir nova série");
    Console.WriteLine("3- Atualizar série");
    Console.WriteLine("4- Excluir série");
    Console.WriteLine("5- Visualizar série");
    Console.WriteLine("C- Limpar Tela");
    Console.WriteLine("X- Sair");
    Console.WriteLine();

    string opcaoUsuario = Console.ReadLine().ToUpper();
    Console.WriteLine();
    return opcaoUsuario;
}