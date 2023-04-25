namespace JUROS_BANCO;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Banco ETEC MCM");
        Banco banco = new Banco();
        
        banco.Depositar(1000);
        banco.Sacar(1600);
        banco.AjustarLimite(500);

        double valortotal = banco.MostrarSaldo();

        Console.WriteLine("Seu saldo total é de " + valortotal);
        banco.imprimi(banco.emprestimo(12,1000));
    }
}