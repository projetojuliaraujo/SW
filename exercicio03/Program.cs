namespace exercicio03;
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
        cj.Nome = "raça";
        cj.Email = "gruporaça123@gmail.com";
        cj.Telefone = "99865-0124";
        cj.Cnpj = 97072555000180;
        cj.Inscricao = 87390174822;
        cj.Prazo = 10;
        cf.Prazo = 10;

        Console.WriteLine(cf.MostraDados());
         Console.WriteLine(cf.CalcularPrestacao());
        Console.WriteLine(cj.MostraDados());
         Console.WriteLine(cj.CalcularPrestacao());
       
        
    }
} 

