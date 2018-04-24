using System;

namespace CalculoCPF
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpfCliente;
            string cpf9;
            string cpf10;
            int contagem1=10;
            int contagem2=11;
            int resto=0;
            int rs1 = 0;
            int rs2 = 0;

            cpfCliente = "34055049889"
            cpf9 = cpfCliente.Substring(0,9);
            for(int i=contagem1; i >=2;i--)
            {
                rs1 = cpf9[i];
            }
        }
    }
}
