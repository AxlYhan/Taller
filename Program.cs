using System.Diagnostics.CodeAnalysis;

namespace Nuevo
{
    internal class Program
    {
        void Main(string[] args)
        {
            Console.WriteLine("Vamos Cienciano");
            int result = Sum(2, 3);
            string name = nombre("axel", "andia");
        }
        public int Sum(int n1, int n2)
        {
            return n1 + n2;
        }
        public string nombre(string name, string lastname)
        {
            return name + lastname;
        }
    }
}