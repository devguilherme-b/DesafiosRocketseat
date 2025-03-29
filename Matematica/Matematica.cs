namespace DesafiosPraticos.Matematica;
public class Matematica
{
    double numeroA = 2.5;
    double numeroB = 2.5;
    public void InicarPrograma()
    {
        Console.WriteLine("Agora vamos fazer algumas continhas...\nVocê deseja digitar os números?\n\nDigite '1' para dizer Sim\nDigite '2' para dizer Não");
        int escolha = Convert.ToInt16(Console.ReadLine());
        switch (escolha)
        {
            case 1:
                Console.WriteLine("\nDigite o primeiro número:");
                numeroA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o Segundo número:");
                numeroB = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(" ");
                break;
            case 2:
                Console.WriteLine("Ok, Vamos continuar...\n");
                break;
            default:
                Console.WriteLine("Certifique-se se o número é '1' para dizer SIM ou '2' para dizer NÃO");
                break;
        }
    }
    public void Soma()
    {
        double resultadoSoma = numeroA + numeroB;
        Console.WriteLine("Soma = " + resultadoSoma);
    }
    // Subtração
    public void Subtracao()
    {
        double resultadoDivisao = numeroA - numeroB;
        Console.WriteLine("Subtração = " + resultadoDivisao);
    }
    // Multiplicação
    public void Multiplicacao()
    {
        double resultadoMultiplicacao = numeroA * numeroB;
        Console.WriteLine("Multiplicação = " + resultadoMultiplicacao);
    }
    // Divisão com verificação se o segundo número é 0!
    public void Divisao()
    {
        double resultado = numeroA / numeroB;
        if (resultado is 0)
            Console.WriteLine("Opa, deu erro, o resultado é 0 'Zero'");
        else
            Console.WriteLine("Divisão = " + resultado);
    }
    // Média entre os dois números
    public void Media()
    {
        double resultadoMedia = (numeroA + numeroB) / 2;
        Console.WriteLine("Média = " + resultadoMedia + "\n");
    }
}