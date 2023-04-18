namespace JUROS_BANCO;
class Program
{
    static void Main(string[] args)
    {
        Banco b = new Banco();

        b.Imprime (b.dividir(1000,12));
    }
}
