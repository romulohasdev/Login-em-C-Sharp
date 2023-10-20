using System;

class Program
{
    static void Main()
    {
        // Nome e Senha do Usuário 
        string usuarioPadrao = "admin";
        string senhaPadrao = "admin";

        Console.WriteLine(" Digite o nome de usuário:");
        string nomeUsuario = Console.ReadLine();

        Console.WriteLine("\n Digite a senha:");
        string senha = Console.ReadLine();

        if (nomeUsuario == usuarioPadrao && senha == senhaPadrao)
        {
            // Sistema que Verifica a Hora
            DateTime agora = DateTime.Now;
            string saudacao = ObterSaudacao(agora);
            Console.WriteLine($"{saudacao}, {nomeUsuario}!");
        }
        else
        {
            Console.WriteLine("\n Credenciais inválidas. Tente novamente. \n");
        }
    }

    static string ObterSaudacao(DateTime agora)
    {
        // Sistema de Saudação de acordo com horário obtido no DataTime.Now
        int hora = agora.Hour;
        string saudacao;

        if (hora >= 6 && hora <= 12)
        {
            saudacao = "\n Bom Dia";
        }
        else if (hora > 12 && hora <= 18)
        {
            saudacao = "\n Boa Tarde";
        }
        else if (hora > 18 && hora <= 24)
        {
            saudacao = "\n Boa Noite";
        }
        else
        {
            saudacao = "\n Boa Madrugada";
        }

        return saudacao;
    }
}