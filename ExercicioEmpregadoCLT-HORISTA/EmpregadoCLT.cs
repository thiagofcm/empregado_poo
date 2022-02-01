using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEmpregadoCLT_HORISTA
{
    class EmpregadoCLT : Empregado
    {
        //atributos
        private double salario_mensal;

        //metodos
        public EmpregadoCLT() { //construtor default

        } 
        public EmpregadoCLT(String _primeiro_nome, String _segundo_nome, String _CPF, double _salario_mensal) : base(_primeiro_nome, _segundo_nome, _CPF) {
            salario_mensal = _salario_mensal;
        }
        //gets
        public double getSalario() {
            return salario_mensal;
        }
        //sets
        public void setSalario(double _salario) {
            salario_mensal = _salario;
        }
        public override void getsalarioliquido() {
            if(salario_mensal >= 4000.0) {
                salario_mensal = salario_mensal - salario_mensal*0.275;
            }
            if(salario_mensal < 4000.0) {
                salario_mensal = salario_mensal - salario_mensal * 0.15;
            }
            Console.WriteLine("O Salario liquido do funcionario eh: " + salario_mensal);
            //base.getsalarioliquido();
        }

    }
}
