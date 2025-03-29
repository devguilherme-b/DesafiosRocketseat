using System;
using System.Globalization;
namespace DesafiosPraticos.Basico;
// A classe se chama Basico por conta do nivel do desafio

public class Basico
{
    // Coloquei os dois primeiros desafios em uma única função porque achei mais fácil
    public void ImprimirNome()
    {
        Console.WriteLine("Antes de iniciarmos, vamos se conhecer...\nQual seu nome?");
        // Define o valor da variável 'nome'
        string nome = Console.ReadLine();
        // Converte a 1° letra em Maiúscula e as demais em minúsculas:
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string nomeFormatado = textInfo.ToTitleCase(nome);
        Console.WriteLine("Olá, " + nomeFormatado + "! Seja muito bem-vindo(a)!\n");
        // Concatena nome e sobrenome
        Console.WriteLine("Qual o seu sobrenome?");
        string sobrenome = Console.ReadLine();
        string sobrenomeFormatado = textInfo.ToTitleCase(sobrenome);
        Console.WriteLine(nomeFormatado + " " + sobrenomeFormatado + "\n");
    }

    public void ContarCacteres()
    {
        // Inserir e contar caracteres
        Console.WriteLine("\nAgora vamos contar a quantidade de caracteres em uma palavra/frase\nDigite algo:");
        string texto = Console.ReadLine();
        int totalCaracteres = texto.Length;
        int espacosEmBranco = 0;
        // Contar espacos em branco
        for (int i = 0; i < totalCaracteres; i++)
        { 
            char caractere = texto[i];
            if (caractere is ' ')
                espacosEmBranco++;
        }
        int resultado = totalCaracteres - espacosEmBranco;
        Console.WriteLine($"\nQuantidade de caracteres: {resultado}\n");
    }
    public void AnalisarPlaca()
    {
        Console.WriteLine("\nAgora vamos analisar se uma placa é válida\nDigite uma placa:");

        string placa = Console.ReadLine()?.Trim(); // Removendo espaços extras
        bool placaValida = false;

        // Verificar se tem 7 caracteres
        if (placa.Length == 7)
        {
            string letrasIniciais = placa.Substring(0, 3); // Captura
            string ultimosCaracteres = placa.Substring(3, 4);

            // Verifica se os três primeiros caracteres são letras
            bool primeirasSaoLetras = letrasIniciais.All(char.IsLetter);

            // Verifica se os últimos quatro caracteres são números
            bool ultimosSaoNumeros = ultimosCaracteres.All(char.IsDigit);

            if (primeirasSaoLetras && ultimosSaoNumeros)
            {
                placaValida = true;
                Console.WriteLine($"\nPlaca válida: {placaValida}");
            }
            else
            {
                Console.WriteLine($"\nErro :(\n\nPlaca válida: {placaValida} \n\n-- Soluções:");
                if (!primeirasSaoLetras)
                    Console.WriteLine("1 - Os três primeiros caracteres devem ser letras.");
                if (!ultimosSaoNumeros)
                    Console.WriteLine("2 - Os quatro últimos caracteres devem ser números.");
            }
        }
        else
        {
            Console.WriteLine($"Erro: A placa deve ter exatamente 7 caracteres, mas tem {placa.Length}.");
        }

        Console.WriteLine("\nDeseja testar outra placa? (S/N)");
        string resposta = Console.ReadLine()?.ToUpper();
        if (resposta == "S")
            AnalisarPlaca();
    }
    public void ExibirDataHora(){
        DateTime dataHoraAtual = DateTime.Now;
        Console.WriteLine("Vamos ativar a função de exibir a atual data e hora...\nEscolha o formato:\n\n1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).\n2 - Apenas a data no formato \"01/03/2024\".\n3 - Apenas a hora no formato de 24 horas.\n4 - A data com o mês por extenso.\n");
        int formatoDataHora = Convert.ToInt16(Console.ReadLine()?.Trim());
        switch (formatoDataHora)
        {
            case 1:
                Console.WriteLine(dataHoraAtual.DayOfWeek + ", " + dataHoraAtual.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("pr-br")));
                break;
            case 2:
                Console.WriteLine(dataHoraAtual.ToString("d"));
                break;
            case 3:
                Console.WriteLine(dataHoraAtual.ToString("T"));
                break;
            case 4:
                Console.WriteLine(dataHoraAtual.Date.ToString("dddd, d 'de' MMMM 'de' yyyy"));
                break;
            default:
                Console.WriteLine("Erro :(\nVerifique se você digitou apenas um número(Opção de formato).");
                break;
        }
        Console.WriteLine("Deseja ver em outro formato? S/N");
        string resposta = Console.ReadLine()?.ToUpper()?.Trim();
        if (resposta is "S"){
            reiniciaExibirDataHora();
        } else{
            Console.WriteLine("Até a próxima :)");
        }
    }
    public void reiniciaExibirDataHora(){
        ExibirDataHora();
    }
}