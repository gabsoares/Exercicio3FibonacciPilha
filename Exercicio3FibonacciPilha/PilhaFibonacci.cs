namespace Exercicio3FibonacciPilha
{
    internal class PilhaFibonacci
    {
        Fibonacci topo;

        public PilhaFibonacci()
        {
            this.topo = null;
        }

        public void Push(Fibonacci aux)
        {
            if (Vazia())
            {
                this.topo = aux;
            }
            else
            {
                aux.setAnterior(topo);
                topo = aux;
            }
        }

        bool Vazia()
        {
            return topo == null;
        }

        public void RunOver()
        {
            Fibonacci aux = topo;
            if (!Vazia())
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.getAnterior();
                } while (aux != null);
            }
        }
    }
}
