namespace Exercicio3FibonacciPilha
{
    internal class Fibonacci
    {
        int valor;
        Fibonacci anterior;

        public Fibonacci(int valor)
        {
            this.valor = valor;
            this.anterior = null;
        }
        public void setAnterior(Fibonacci anterior)
        {
            this.anterior = anterior;
        }

        public Fibonacci getAnterior()
        {
            return this.anterior;
        }

        public override string? ToString()
        {
            return $"{this.valor}";
        }
    }
}
