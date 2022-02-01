using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEmpregadoCLT_HORISTA
{
    class Empregado
    {
        //atributos
        protected String primeiro_nome;
        protected String segundo_nome;
        protected String CPF;

        //metodos
        public Empregado() { //construtor default

        }
        public Empregado(String _primeiro_nome, String _segundo_nome, String _CPF) {
            primeiro_nome = _primeiro_nome;
            segundo_nome = _segundo_nome;
            CPF = _CPF;
        }
        // gets
        public String getprimeironome() {
            return primeiro_nome;
        }
        public String getsegundonome() {
            return segundo_nome;
        }
        public String getcpf() {
            return CPF;
        }
        // sets
        public void setprimeironome(String _primeiro_nome) {
            primeiro_nome = _primeiro_nome;
        }
        public void setsegundonome(String _segundo_nome) {
            segundo_nome = _segundo_nome;
        }
        public void setcpf(String _cpf) {
            CPF = _cpf;
        }
        // salario liquido
        public virtual void getsalarioliquido() {
        }

    }
}
