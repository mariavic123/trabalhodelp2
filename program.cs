using System;
using System.Collections.Generic;

namespace Aula14
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool MostrarMenu = true;
            while (MostrarMenu)
            {
                MostrarMenu = MenuPrincipal();
            }
        }
        private static bool MenuPrincipal()
        {
            Console.WriteLine("Digite '1' para o acesso aos tópicos de implementação 1 e 2");
            Console.WriteLine("Digite '3' para o acesso ao tópico de implementação 3");
            Console.WriteLine("Digite '4' para o acesso ao tópico de implementação 4");
            Console.WriteLine("Digite '5' para o acesso ao tópico de implementação 5");
            Console.WriteLine("Digite '6' para o acesso ao código padrão");
            Console.WriteLine("Digite '0' para encerrar o programa.");
            string entrada = Console.ReadLine();
            do
            {
                if (entrada == "1")
                {
                    Console.Clear();
                    Fornecedor Fornecedor_ = new Fornecedor("João Dória", "45.696.940/0001-03");
                    Produto ProdutoFisico = new ProdutoFisico("Mausi Michaelsóft", 89.90, 12.99, Fornecedor_);
                    ProdutoFisico.Imprimir();

                    Console.WriteLine("______________________________________________________");
                    Console.WriteLine("Aperte qualquer tecla :)");
                    Console.ReadKey();


                }
                else if (entrada == "3")
                {
                    Console.Clear();

                    Licensa Peixe_Frito = new Licensa("Peixe Frito", 2999.90, "XZLT-CXL9-SLHV-99UM");
                    Estoque Estoque_ = new Estoque();

                    for (int i = 0; i < 5; i++)
                    {
                        Estoque_.Adicionar(Peixe_Frito);
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        Estoque_.Remover(Peixe_Frito);
                    }
                    Estoque_.ImprimirEstoque();

                    Console.WriteLine("______________________________________________________");
                    Console.WriteLine("Aperte qualquer tecla :)");
                    Console.ReadKey();

                }
                else if (entrada == "4")
                {
                    Console.Clear();
                    Licensa Peixe_Frito_2 = new Licensa("Peixe Frito", 2999.90, "XZLT-CXL9-SLHV-99UM");
                    Licensa MudaPauBrasil = new Licensa("Muda De Pau Brasil", 2999.90, "XZLT-CXL9-SLHV-99UM");

                    Carrinho Carrinho = new Carrinho();
                    Estoque Estoque_3 = new Estoque();


                    for (int i = 0; i < 5; i++)
                    {
                        Carrinho.Adicionar(Peixe_Frito_2);
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        Carrinho.Adicionar(MudaPauBrasil);
                    }


                    for (int i = 0; i < 5; i++)
                    {
                        Estoque_3.Adicionar(Peixe_Frito_2);
                        Estoque_3.Adicionar(MudaPauBrasil);
                    }

                    Cliente Cliente_ = new Cliente(nome: "Ygor Canalli", cpf: "610.485.227-09");
                    Compras Compras = new Compras(carrinho_: Carrinho, estoque_: Estoque_3, cliente_: Cliente_);

                    Compras.Comprar_Produtos();

                    Compras.ImprimirRecibo();
                    Console.WriteLine("______________________________________________________");
                    Console.WriteLine("Aperte qualquer tecla :)");
                    Console.ReadKey();
                }
                else if (entrada == "5")
                {
                    Console.Clear();
                    Fornecedor Fornecedor_02 = new Fornecedor("Fornecedor 02", "45.696.940/0001-03");
                    Fornecedor Fornecedor_03 = new Fornecedor("Fornecedor 03", "45.696.940/0001-03");

                    Relatorio relatorioFornecedores_ = new Relatorio(

                        titulo: "Compras de Fornecedores",
                        descricao: "Mostrando alguns fornecedores"

                    );

                    relatorioFornecedores_.AdicionarItem(Fornecedor_02);
                    relatorioFornecedores_.AdicionarItem(Fornecedor_03);
                    relatorioFornecedores_.ImprimirRelatorio();


                    Licensa Software_02 = new Licensa("Software 02", 300.90, "XZLT-CXL9-SLHV-99UM");
                    Licensa Software_03 = new Licensa("Software 03", 300.90, "XZLT-CXL9-SLHV-99UM");
                    Relatorio relatorioLicencas = new Relatorio(

                        titulo: "Relatorio de Compras",
                        descricao: "Mostrando algumas compras"

                    );

                    relatorioLicencas.AdicionarItem(Software_02);
                    relatorioLicencas.AdicionarItem(Software_03);
                    relatorioLicencas.ImprimirRelatorio();
                    Console.WriteLine("______________________________________________________");
                    Console.WriteLine("Aperte qualquer tecla :)");
                    Console.ReadKey();
                }
                else if (entrada == "6")
                {
                    Console.Clear();
                    Licensa rwindols = new Licensa("Michaelsóft Rwildols", 699.90, "SUAA-HE52-W6WG-B8Y9");

                    Assinatura alface123 = new Assinatura("Michaelsóft Alface", 39.90, 12, "5GNX-VM6Y-L6W8-SCPC");

                    Assinatura corehul =
                            new Assinatura("Aldobo Corehul", mensalidade: 89.90, 12, "H84A-8QDF-4XPT-A2WZ");
                    Assinatura cottonshopi =
                        new Assinatura("Aldobo Cottonshopi", mensalidade: 89.90, 12, "H84A-8QDF-4XPT-A2WZ");
                    Assinatura premillere =
                        new Assinatura("Aldobo Premillere", mensalidade: 89.90, 12, "RLBD-YTRZ-UPH7-VQGM");

                    Fornecedor Fornecedor_4 = new Fornecedor(nome: "Joãozinho Testes", cnpj: "45.696.940/0001-03");



                    ProdutoFisico mausi = new ProdutoFisico("Mausi Michaelsóft", 89.90, 12.99, Fornecedor_4);
                    ProdutoFisico lepetope = new ProdutoFisico("Lepetope Dehul", 3499.90, 123.45, Fornecedor_4);

                    Carrinho carrinho = new Carrinho();

                    carrinho.Adicionar(rwindols);
                    carrinho.Adicionar(alface123, 3);
                    carrinho.Adicionar(cottonshopi);
                    carrinho.Adicionar(premillere);
                    carrinho.Adicionar(corehul);
                    carrinho.Adicionar(mausi, 3);
                    carrinho.Adicionar(lepetope);

                    carrinho.ImprimirCarrinho();

                    Relatorio relatorioArtistico = new Relatorio("Relatorio Artístico",
                        "Este relatório apresenta todos os softwares artisticos vendidos na loja.");

                    relatorioArtistico.AdicionarItem(cottonshopi);
                    relatorioArtistico.AdicionarItem(premillere);
                    relatorioArtistico.AdicionarItem(corehul);
                    relatorioArtistico.ImprimirRelatorio();

                    Cliente hermenegildo = new Cliente("Hermenegildo Benevides", "123.456.789-10");
                    Cliente zoroastra = new Cliente("Zoroastra Muad'dib", "109.876.543-21");


                    Relatorio relatorioClientes = new Relatorio("Relatório de Clientes",
                        "Este relatório apresenta uma lista de todos os clientes que compraram no mês de abril");

                    relatorioClientes.AdicionarItem(hermenegildo);
                    relatorioClientes.AdicionarItem(zoroastra);
                    relatorioClientes.ImprimirRelatorio();
                    Console.WriteLine("______________________________________________________");
                    Console.WriteLine("Aperte qualquer tecla :)");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Pressione qualtquer tecla para sair");
                    Console.ReadKey();
                    
                }
                Console.Clear();
                Console.WriteLine("Digite '1' para o acesso aos tópicos de implementação 1 e 2");
                Console.WriteLine("Digite '3' para o acesso ao tópico de implementação 3");
                Console.WriteLine("Digite '4' para o acesso ao tópico de implementação 4");
                Console.WriteLine("Digite '5' para o acesso ao tópico de implementação 5");
                Console.WriteLine("Digite '6' para o acesso ao código padrão");
                Console.WriteLine("Digite '0' para encerrar o programa.");
                string entrada = Console.ReadLine();

            } while (entrada == "0");
        }
    }
}
