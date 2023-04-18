namespace JUROS_BANCO;
class Banco
{ 
 public int numero1 {get;set;}  
 public int numero2 {get;set;}  

  public string dividir (int num1, int num2){
    this.numero1 = num1;
    this.numero2 = num2;
    int dividir = this.numero1/this.numero2;
    string resul1 = "A quantia emprestada é de R$" +this.numero1+ " com o prazo de " + this.numero2+ " meses é de: R$" + dividir + " sem juros"; 

    return resul1;
}

    public double MostrarSaldo(){
        return this.numero1 + this.numero2;
    }

    public void AjustaLimite(double valor){
        this.numero1 = valor;
    }
}

