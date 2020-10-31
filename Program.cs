/* 
 * Gabriel Lima Bertoldo
 * Maquina de vender cafe virtual - DBCorp
 * Tempo: 22:03 - 22:44 / 11-00 - 12:52 / 14:39 - 15:59
 * Tempo Decorrido: 223 min ou 3 horas e 43 minutos
 */

using System;
using System.Collections.Concurrent;
using System.Globalization;

namespace DBCorp___Maquian_de_Cafe_Virtual
{
    class Program
    {
        //iniciar Produtos;
        static MaquinaProdutos[] ListaDeProdutos = new MaquinaProdutos[3];
        static void Main(string[] args)
        {
            bool programaOn = true;
            MaquinaUsuario usuario;
            usuario = new MaquinaUsuario();
            while (programaOn)
            {
                
                int escolha;

                DisplayMainMenu(usuario);
                DisplayOpcoes();                
                Console.Write("Escolha: ");
                escolha = int.Parse(Console.ReadLine());

                if(escolha == 3)
                {
                    programaOn = false;
                }
                else
                {
                    Escolha(escolha, usuario, ListaDeProdutos);
                }
            }
            
        }

        //Display
        public static void DisplayMainMenu(MaquinaUsuario user)
        {
            Console.WriteLine("////////////////Bem-Vindo Maquina de Cafe//////////////////");
            Console.WriteLine();

            ProdutosOferecidos();

            Console.WriteLine();
            Console.WriteLine("Saldo: " + user.VerSaldo().ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void DisplayOpcoes()
        {
            Console.WriteLine("//////////////////////////MENU////////////////////////////");
            Console.WriteLine("(1) - Colocar moedas");
            Console.WriteLine("(2) - Pedir Cafe");
            Console.WriteLine("(3) - Sair");
        }
        //Display - Fim

        //Inicializar Produtos
        public static void ProdutosOferecidos()
        {
            //Produtos
            ListaDeProdutos[0] = new MaquinaProdutos(1, "Cappucino", 3.50);
            ListaDeProdutos[1] = new MaquinaProdutos(2, "Mocha", 4.00);
            ListaDeProdutos[2] = new MaquinaProdutos(3, "Café com Leite", 3.00);

            //Display produtos
            for (int i = 0; i < ListaDeProdutos.Length; i++)
            {
                Console.WriteLine(ListaDeProdutos[i].ToString());
            }
        }

        //Branches
        public static void Escolha(int escolha, MaquinaUsuario user, MaquinaProdutos[] lista)
        {
            switch (escolha)
            {
                case 1:
                    ColocarMoedas.Colocar(user);
                    break;

                case 2:
                    if(user.VerSaldo() > 0.01)
                    {
                        Pedidos.Pedido(user, lista);
                    }
                    else
                    {
                        Console.WriteLine("Sem saldo o sulficiente, presione qualquer tecla para voltar.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    break;

                default:
                    Console.WriteLine("Invalido");
                    Console.Clear();
                    break;
            }
        }
    }
}
