public class FuncionarioTempoIntegral : Funcionario, IBonus
{
    public double salarioMensal;

    public FuncionarioTempoIntegral(string nome,int matricula,double salarioMensal) : base(nome,matricula)
    {
        this.salarioMensal = salarioMensal;
    }

    public override double CalcularSalario()
    {
        return salarioMensal;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"nome do funcionario: {nome}");
        Console.WriteLine($"a matricula é: {matricula}");
        Console.WriteLine($"o salario mensal é {salarioMensal}");
    }

     public double CalcularBonus()
    {
        return salarioMensal * 0.10;
    }
}