namespace ExercicioAlunos;
class Program
{
    static void Main(string[] args)
    {
        Alunos aluno1 = new Alunos();
        aluno1.nome = "Outro Aluno";
        aluno1.nota1 = 4;
        aluno1.nota2 = 5;

        Console.WriteLine("Digite o nome do aluno: ");
        aluno1.nome = Console.ReadLine();

        Console.WriteLine("Digite a primeira nota: ");
        aluno1.nota1 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite a segunda nota: ");
        aluno1.nota2 = double.Parse(Console.ReadLine());

        aluno1.mensagem();
    }
}
