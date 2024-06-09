using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;

namespace ProyectoCalculadora
{
    internal class Calculadora
    {

        public string Operador(string n1, char op, string n2)
        {
            //queria usar operadores lambda, pero no supe
            //Esto funciona, y no funciona nada mal sinceramente
            double num1 = Convert.ToDouble(n1);
            double num2 = Convert.ToDouble(n2);
            switch(op)
            {
                case '+': return (num2 + num1).ToString();
                case '-': return (num2 - num1).ToString();
                case '*': return (num2 * num1).ToString();
                case '√':
                    if (n2 != "0")       return (Math.Sqrt(num2)).ToString();
                    else if(num1 >= 0)   return (Math.Sqrt(num1)).ToString();
                    else
                    {
                        MessageBox.Show("Numero complejo encontrado", "ERROR");
                        return "0";
                    }
                        
                    //Intente usar el try catch para esta parte, pero, no agarraba error, solo retornaba infinito
                case '/':
                    if (num1 == 0)
                    {
                        MessageBox.Show("Division entre 0", "ERROR");
                        return "0";
                    }
                    else return (num2 / num1).ToString();

                case '⅟': return (1 / num1).ToString();
                default : return null;
            }
        }
    }
}
