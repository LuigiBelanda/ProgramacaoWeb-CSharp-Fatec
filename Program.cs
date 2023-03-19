using System;
using ProgramacaoWeb_CSharp_Fatec.Classes;
using ProgramacaoWeb_CSharp_Fatec.Heranca;

namespace ProgramacaoPw_CSharp_Fatec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ======================
            // Produto
            // ======================
            Console.WriteLine("\n\n======================\nProduto\n======================");

            // Criando um produto com construtor (conferir no arquivo da classe)
            // e depois mostrando seus dados com os métodos get da classe
            Console.WriteLine("\n\nCriando um produto por meio da class Produto - Usando construtor\n");

            Produto p1 = new Produto(1, 10.90M, "Cervejinha");
            Console.WriteLine("Descrição: " + p1.getDescricao() + " \t\t Valor: " + p1.getValor() + " \t\t ID: " + p1.getId());

            // Aqui mudamos algumas infos do objeto com os métodos set da class e 
            // exibimos as novas infos no console
            Console.WriteLine("\n\nMudando algumas infos do produto criado acima com os métodos set da class");
            p1.setValor(11.85M);
            p1.setDescricao("Cerveja Skol 1 litrão");
            Console.WriteLine("Descrição: " + p1.getDescricao() + " \t\t Valor: " + p1.getValor() + " \t\t ID: " + p1.getId());




            // ======================
            // Endereço
            // ======================

            Console.WriteLine("\n\n======================\nEndereço\n======================");

            Console.WriteLine("\n\nUtilizando outra class (Endereco.cs) para criar dois objetos do tipo Endereco");

            // Aqui usamos a class Endereco e criamos objetos do tipo Endereco, passando
            // como é necessário no construtor os dados necessários
            Endereco endereco = new Endereco(
                "Rua Mario Miziara",
                "91",
                "Sobral",
                "15906304",
                "Taquaritinga",
                "SP"
                );

            Endereco endereco2 = new Endereco(
                "Rua dos bobo",
                "952",
                "Sobral",
                "15906304",
                "Taquaritinga",
                "SP"
                );

            // Aqui usamos alguns métodos da class e mostramos os dados dos objetos criados acima
            Console.WriteLine("\nEndereço Completo (método EnderecoCompleto)");
            Console.WriteLine(endereco.EnderecoCompleto());
            Console.WriteLine(endereco2.EnderecoCompleto());

            Console.WriteLine("\nEndereco curto (método EnderecoCurto)");
            Console.WriteLine(endereco.EnderecoCurto());
            Console.WriteLine(endereco2.EnderecoCurto());




            // ======================
            // Cliente
            // ======================

            Console.WriteLine("\n\n======================\nCliente + Endereco\n======================");

            Console.WriteLine("\n\nUtilizando outra class (Cliente.cs) para criar alguns objetos do tipo Cliente e ainda dentro da class Cliente usando a class Endereco.cs \n");

            Cliente c1 = new Cliente(1, "Gabriele", "991340444", endereco);
            Cliente c2 = new Cliente(2, "Luis", "991340445", endereco);
            Cliente c3 = new Cliente(3, "Leandro", "991340446", endereco);
            Cliente c4 = new Cliente(4, "Ana", "991340447", endereco);
            Cliente c5 = new Cliente(5, "Rayssa", "991340448", endereco);

            Console.WriteLine(c2.getEndereco().getRua() + " " + c2.getEndereco().getNumero());

            c2.getEndereco().setNumero("136");

            Console.WriteLine(c2.getEndereco().getNumero());
            Console.WriteLine(c2.getEndereco().EnderecoCompleto());

            c2.getEndereco().EnderecoCurto();




            // ======================
            // Herança
            // ======================

            Console.WriteLine("\n\n======================\nHerança\n======================");

            Carro Gol = new Carro();
            Gol.temMotor = true;
            Gol.numeroPortas = 4;
            Gol.numeroAssentos = 5;
            Gol.fabricante = "Vw";

            Bike caloi = new Bike();
            caloi.temMotor = false;
            caloi.numeroPortas = 0;
            caloi.numeroAssentos = 1;

            Carro Saveiro = new Carro();
            Carro Palio = new Carro();
            Carro Uno = new Carro();

            Saveiro.fabricante = "Vw";
            Palio.fabricante = "Fiat";
            Uno.fabricante = "Fiat";

            Bike speed = new Bike();
            speed.temMotor = false;
            speed.numeroPortas = 0;
            speed.numeroAssentos = 1;

            // Faça uma ação chamada ExibirDados e
            // mostre as infos na tela pelo Console.WriteLine
            // Veiculo.cs e Carro.cs
            Console.WriteLine(speed.ExibirDados());
            Console.WriteLine(Gol.ExibirDados());




            // ======================
            // List
            // ======================
            // List<tipo> nome = new List<tipo>
            // Só entra na list quem for do tipo Carro
            Console.WriteLine("\n\nList");
            List<Carro> listaCarros = new List<Carro>();

            listaCarros.Add(Gol);
            listaCarros.Add(Palio);
            listaCarros.Add(Saveiro);
            listaCarros.Add(Uno);

            Console.WriteLine(listaCarros[0].fabricante);
            listaCarros.Remove(Palio);

            Console.WriteLine("\n\nFor list");
            for (int i = 0; i < listaCarros.Count; i++)
            {
                Console.WriteLine(listaCarros[i].ExibirDados());
            }

            // Foreach melhor para list
            Console.WriteLine("\n\nForeach list");
            foreach (var item in listaCarros)
            {
                Console.WriteLine(item.ExibirMarca());
            }




            // Imprima na tela todos os clientes desse contexto,
            // Dica crie uma lista para eles.




            // Crie uma lista com 560 produtos
            // Imprima na tela
            List<Produto> listaProdutos = new List<Produto>();

            for (int i = 1; i <= 560; i++)
            {
                Produto p = new Produto(i, i * 2, "Produto nº " + i);
                listaProdutos.Add(p);
            }

            foreach (var item in listaProdutos)
            {
                Console.WriteLine(item.ExibeDados());
            }




            // Crie uma lista que aceite qualquer tipo de veiculo 
            // Imprima na tela
        }
    }
}