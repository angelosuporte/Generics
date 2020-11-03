using System;

namespace Generics
{
    class PrintService<T>
    {
        private T[] _valores = new T[10];
        private int _contador = 0;

        public void AddValor(T valor)
        {
            if (_contador == 10) 
            {
                throw new InvalidOperationException("PrintService está cheio");
            }
            _valores[_contador] = valor;
            _contador++;
        }

        public T Primeiro()
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
