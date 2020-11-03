using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class PrintService
    {
        private int[] _valores = new int[10];
        private int _contador = 0;

        public void AddValor(int valor)
        {
            if (_contador == 10) 
            {
                throw new InvalidOperationException("PrintService está cheio");
            }
            _valores[_contador] = valor;
            _contador++;
        }

        public int Primeiro()
        {
            if (_contador == 0)
            {
                throw new InvalidOperationException("PrintService está vazio");
            }
            return _valores[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _contador -1; i++) //até o penúltimo valor...
            {
                Console.Write(_valores[i] + ", "); //...será colocado entre os valores uma vírgula e um espaço
            }
            if (_contador > 0)
            {
                Console.Write(_valores[_contador - 1]);
            }
            Console.Write("]");
        }
    }
}
