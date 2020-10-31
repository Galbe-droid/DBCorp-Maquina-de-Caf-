using System;

namespace DBCorp___Maquian_de_Cafe_Virtual
{
    class ColocarMoedas
    {
        public static void Colocar(MaquinaUsuario user)
        {
            int m1, m5, m10, m25, m50;

            Console.Clear();
            Console.WriteLine("/////////////////////////MOEDAS////////////////////////////");
            Console.Write("1 Centavo: ");
            m1 = int.Parse(Console.ReadLine());

            Console.Write("5 Centavo: ");
            m5 = int.Parse(Console.ReadLine());

            Console.Write("10 Centavo: ");
            m10 = int.Parse(Console.ReadLine());

            Console.Write("25 Centavo: ");
            m25 = int.Parse(Console.ReadLine());

            Console.Write("50 Centavo: ");
            m50 = int.Parse(Console.ReadLine());

            user.Adicionar(m1, m5, m10, m25, m50);

            Console.Clear();
        }
    }
}
