
using Mercado.Entities;
using Mercado.Repositories;

Console.WriteLine("\n***CDASTRO DOS PRODUTOS DO MERCADO***\n");

var produto = new Produto();
produto.Categoria = new Categoria();
produto.Fornecedor = new Fornecedor();

try
{

    #region
    produto.Id = Guid.NewGuid();
    Console.Write("Informe o Nome do produto...: ");
    produto.Nome = Console.ReadLine();

    Console.Write("Informe o preço do produto...: ");
    produto.Preco = decimal.Parse(Console.ReadLine());

    Console.Write("Informe a quantidade do produto...: ");
    produto.Quantidade = int.Parse(Console.ReadLine());

    Console.Write("Informe a data da compra do produto...: ");
    produto.DataCompra = DateTime.Parse(Console.ReadLine());
    #endregion


    produto.Categoria.Id = Guid.NewGuid();

    Console.Write("Informe a descrição da Categoria...: ");
    produto.Categoria.Descricao = Console.ReadLine();


    produto.Fornecedor.IdFornecedor = Guid.NewGuid();

    Console.Write("Informe o nome do Fornecedor...: ");
    produto.Fornecedor.Nome = Console.ReadLine();

    Console.Write("Informe o CNPJ do Fornecedor...: ");
    produto.Fornecedor.Cnpj = Console.ReadLine();

    #region
    Console.WriteLine("\nDADOS DO MERCADO\n");

    Console.WriteLine($"\tId......:{produto.Id}");
    Console.WriteLine($"\tNome....:{produto.Nome}");
    Console.WriteLine($"\tPreço....:{produto.Preco}");
    Console.WriteLine($"\tQuantidade....:{produto.Quantidade}");
    Console.WriteLine($"\tData da Compra....:{produto.DataCompra}");
    Console.WriteLine($"\tId da Categoria...:{produto.Categoria.Id}");
    Console.WriteLine($"\tDescrição da Categoria....:{produto.Categoria.Descricao}");
    Console.WriteLine($"\tId do Fornecedor...:{produto.Fornecedor.IdFornecedor}");
    Console.WriteLine($"\tNome do Fornecedor...{produto.Fornecedor.Nome}");
    Console.WriteLine($"\tCNPJ....:{produto.Fornecedor.Cnpj}");
    #endregion

    Console.Write("\nEscolha (1)JSON ou (2)XML...:");
    var opcao = int.Parse(Console.ReadLine());

    var produtoRepository = new ProdutoRepository();

    switch (opcao)
    {
        case 1:
            produtoRepository.ExportarJson(produto);
            Console.WriteLine("\nArquivo JSON gravado com sucesso!");
            break;

        case 2:
            produtoRepository.ExportarXml(produto);
            Console.WriteLine("\nArquivo XML gravado com sucesso!");
            break;

        default:
            Console.WriteLine("\nOpção Inválida!");
            break;
    }

}
catch (ArgumentException e)
{
    Console.WriteLine("\nErro de validação:");
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine("\nFALHA AO EXECUTAR O PROGRAMA:");
    Console.WriteLine(e.Message);

}

Console.ReadKey();