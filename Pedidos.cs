using System;

namespace DBCorp___Maquian_de_Cafe_Virtual
{
    class Pedidos
    {
        public static void Pedido(MaquinaUsuario user, MaquinaProdutos[] lista)
        {
            bool comprando = true;
            while(comprando)
            {
                int escolha ;
                string escolhaStr = "";

                Console.Clear();

                Program.DisplayMainMenu(user);
                Console.WriteLine("/////////////////////////CAFÉS////////////////////////////");
                Console.WriteLine("Selecione o numero do café, ou 0 para voltar.");
                Console.Write("Escolha: ");
                escolha = int.Parse(Console.ReadLine());

                while(escolha >= lista.Length -1 && escolha <= 0)
                {
                    Console.Write("Invalido escolha novamente: ");
                    escolha = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < lista.Length; i++)
                {
                    if (escolha == lista[i].ProdutoID && user.VerSaldo() >= lista[i].Preco)
                    {
                        Console.WriteLine("Café: " + lista[i].ProdutoNome + " comprado.");
                        user.Pagamento(lista[i].Preco);

                        if (user.VerSaldo() >= 0.01)
                        {
                            Console.WriteLine("Troco: ");
                            user.Troco();
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else if(escolha == lista[i].ProdutoID && user.VerSaldo() < lista[i].Preco)
                    {
                        
                        Console.WriteLine("Saldo insulficiente.");
                        Console.Write("Gostaria de voltar e colcoar moedas ? [S/N]: ");
                        escolhaStr = Console.ReadLine().ToUpper();

                        while(escolhaStr != "S" && escolhaStr != "N")
                        {
                            Console.WriteLine("Invalido tente denovo: ");
                            escolhaStr = Console.ReadLine().ToUpper();
                        }

                        if(escolhaStr == "S")
                        {
                            Console.Clear();
                            ColocarMoedas.Colocar(user);
                        }

                        Console.Clear();
                    }
                }
            }
            
        }
    }
}
