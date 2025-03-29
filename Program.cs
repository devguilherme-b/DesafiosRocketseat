using DesafiosPraticos.Basico;
using DesafiosPraticos.Matematica;
public class Program
{
    public static void Main()
    {
        Basico basico = new Basico();

        // 1° e 2° Desafio aqui:
        //basico.ImprimirNome();

        // 3° Desafio aqui:
        // ExecutaOperacoes();

        // 4° Desafio
        // basico.ContarCacteres();
        
        // 5° Desafio
        // basico.AnalisarPlaca();

        // 6° Desafio
        basico.ExibirDataHora();
    }
    public static void ExecutaOperacoes(){
        Matematica matematica = new Matematica();
        matematica.InicarPrograma();
        matematica.Soma();
        matematica.Subtracao();
        matematica.Divisao();
        matematica.Multiplicacao();
        matematica.Media();
    }

}