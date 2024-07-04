public class FuncionarioMeioPeriodo : Funcionario, IBonus
{
    private double salarioPorHora;

    private int horasTrabalhadas;

    public FuncionarioMeioPeriodo(string nome,int matricula,double salarioPorHora,int horasTrabalhadas) : base(nome,matricula)
    {
        this.salarioPorHora = salarioPorHora;
        this.horasTrabalhadas = horasTrabalhadas;
    }

    public override double CalcularSalario()
    {
        return salarioPorHora * horasTrabalhadas;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {nome} , Matricula: {matricula}, salario mensal: {CalcularSalario()}");
    }
    
    public double CalcularBonus()
    {
        return CalcularSalario() * 0.05;
    }
}