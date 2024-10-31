namespace NewTalents
{
    public class Calculadora
    {
        private List<string> listHistorico;
        private string _data;

        public Calculadora(string data) 
        {
            listHistorico = new List<string>();
            _data = data;
        }

        public int Somar(int val1, int val2)
        {
            int x = val1 + val2;

            listHistorico.Insert(0, "Resultado:" + x + " - data:" + _data);
            return x;
        }

        public int Subtrair(int val1, int val2)
        {
            int x = val1 - val2;

            listHistorico.Insert(0, "Resultado:" + x + " - data:" + _data);
            return x;
        }

        public int Multiplicar(int val1, int val2)
        {
            int x = val1 * val2;

            listHistorico.Insert(0, "Resultado:" + x + " - data:" + _data);
            return x;
        }

        public int Dividir(int val1, int val2)
        {
            int x = val1 / val2;

            listHistorico.Insert(0, "Resultado:" + x + " - data:" + _data);
            return x;
        }

        public List<string> Historico()
        {
            listHistorico.RemoveRange(3, listHistorico.Count - 3);
            return listHistorico;
        }
    }
}
