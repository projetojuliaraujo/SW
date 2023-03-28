namespace PROJ_PESSOA;
class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa("GODOFREDO", 18);
        //p1.AlterarNome("Júlia");
        //p1.AlterarSobreNome("Araújo");
        //p1.AlterarIdade(16);
        p1.MostraDados();
    }
}
