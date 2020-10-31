using System;

namespace DBCorp___Maquian_de_Cafe_Virtual
{
    class MaquinaUsuario
    {
        public double Saldo { get; private set; }

        public MaquinaUsuario() {}

        public void Adicionar(int moeda1, int moeda5, int moeda10, int moeda25, int moeda50)
        {
            this.Saldo += ((moeda10 * 0.10) + (moeda25 * 0.25) + (moeda50 * 0.50));

            if (moeda1 > 0 || moeda5 > 0)
            {
                moeda1 = 0;
                moeda5 = 0;
                Console.WriteLine("Houve um erro na contagem das moedas, use qualquer tecla para continuar");
                Console.ReadLine();
            }
        }

        public void Pagamento(double preco)
        {
            this.Saldo -= preco;
        }

        public void Troco()
        {
            double moeda1 = 0, moeda5 = 0, moeda10 = 0, moeda25 = 0, moeda50 = 0;
            while(this.Saldo != 0)
            {
                while(this.Saldo >= 0.50)
                {
                    this.Saldo -= 0.50;
                    moeda50++;
                }
                while (this.Saldo >= 0.25)
                {
                    this.Saldo -= 0.25;
                    moeda25++;
                }
                while (this.Saldo >= 0.10)
                {
                    this.Saldo -= 0.10;
                    moeda10++;
                }
                while (this.Saldo >= 0.05)
                {
                    this.Saldo -= 0.05;
                    moeda5++;
                }
                while (this.Saldo >= 0.01)
                {
                    this.Saldo -= 0.01;
                    moeda1++;
                }
            }
            Console.WriteLine("50 Centavos: " + moeda50 + "\n" +
                              "25 Centavos: " + moeda25 + "\n" +
                              "10 Centavos: " + moeda10 + "\n" +
                              "5 Centavos: " + moeda5 + "\n" +
                              "1 Centavos: " + moeda1 );
        }

        public double VerSaldo()
        {
            return this.Saldo;
        }
    }
}
