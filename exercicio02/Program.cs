namespace exercicio02;
class Program
{
    static void Main(string[] args)
    {

        Contrato c = new Contrato();
        ContratoPessoaFisica cf = new ContratoPessoaFisica();
        ContratoPessoaJuridica cj = new ContratoPessoaJuridica();


        cf.Nome = "Julinha";
        cf.Email = "julinha.araujo@gmail.com";
        cf.Telefone = "4002-8922";
        cf.Idade = 18;
        cf.Cpf = 55489201833;
        cj.Nome = "ETECMCM";
        cj.Email = "etec.mcm@gmail.com";
        cj.Telefone = "99865-0124";
        cj.Cnpj = 97072555000180;
        cj.Inscricao = 87390174822;

        Console.WriteLine(cf.MostraDados());
        Console.WriteLine(cj.MostraDados());
        
    }
} 

