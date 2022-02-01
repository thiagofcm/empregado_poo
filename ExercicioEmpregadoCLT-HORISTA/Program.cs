using System;

namespace ExercicioEmpregadoCLT_HORISTA
{
    class Program
    {
        static void Main(string[] args) {
            EmpregadoCLT F1 = new EmpregadoCLT("Thiago", "Cuevas", "12593512628", 5000.0);
            EmpregadoHORISTA F2 = new EmpregadoHORISTA("Ana Clara", "Souza", "16828333802", 60, 10);
            Console.WriteLine("O salario do funcionario " + F1.getprimeironome() + "eh: " + F1.getSalario());
            F1.getsalarioliquido();
            F2.getsalarioliquido();
            
            Console.WriteLine("A quantidade de horas que a funcionaria " + F2.getprimeironome() + " eh: " + F2.getHoras());
        }
    }
}
