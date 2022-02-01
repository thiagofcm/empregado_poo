using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEmpregadoCLT_HORISTA
{
    class EmpregadoHORISTA : Empregado
    {
        //atributos
        private double qtd_horas;
        private double preco_hora;

        //metodos 
        public EmpregadoHORISTA() { //construtor default

        }
        public EmpregadoHORISTA(String _primeiro_nome, String _segundo_nome, String _CPF, double _qtd_horas, double _preco_hora) : base(_primeiro_nome, _segundo_nome, _CPF) {
            qtd_horas = _qtd_horas;
            preco_hora = _preco_hora;
        }
        //gets 
        public double getHoras() {
            return qtd_horas;
        }
        public double getPreco() {
            return preco_hora;
        }
        //sets
        public void setHoras(double _qtd_horas) {
            qtd_horas = _qtd_horas;
        }
        public void setPreco(double _preco_hora) {
            preco_hora = _preco_hora;
        }
        public override void getsalarioliquido() {
            //base.getsalarioliquido();
            double salario = (qtd_horas * preco_hora)* 1.15;
            Console.WriteLine("O salario liquido do funcionario eh: " + salario);
        }
    }
}
