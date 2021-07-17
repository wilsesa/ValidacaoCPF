using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacaoCPF
{
    class ValidacaoCPF
    {
        public static bool Verificar(string cpf)
        {
            int[] VerificarDigito1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] VerificarDigito2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string CPF1, CPF2;
            int Soma, Resultado;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
            {
                return false;
            }

            //CPF informado por o usuário
            CPF1 = cpf.Substring(0, 10);
            Soma = 0;

            for (int i = 0; i < 9; i++)

                Soma += Convert.ToInt32(CPF1[i].ToString()) * VerificarDigito1[i];

            Resultado = Soma % 11;

            if (Resultado < 2)
            {
                Resultado = 0;
            }
            else
            {
                Resultado = 11 - Resultado;
            }

            CPF2 = Resultado.ToString();
            CPF1 = CPF1 + CPF2;

            Soma = 0;
            for (int x = 0; x < 10; x++)

                Soma += Convert.ToInt32(CPF1[x].ToString()) * VerificarDigito2[x];

            Resultado = Soma % 11;

            if (Resultado < 2)
            {
                Resultado = 0;
            }
            else
            {
                Resultado = 11 - Resultado;
            }

            CPF2 = CPF2 + Resultado.ToString();

            return cpf.EndsWith(CPF2);


        }
    }
}
