namespace ContoCorrente
{
    internal class Program
    {
        //ESERCIZIO 1
        //    static void Main(string[] args)
        //    {
        //        // apertura conto corrente
        //        Console.WriteLine("Apertura conto:");
        //        Console.Write("Nome completo: ");
        //        string nominativo = Console.ReadLine();
        //        Console.Write("Versamento iniziale: ");
        //        double saldo = double.Parse(Console.ReadLine());

        //        while (true)
        //        {

        //            if (saldo >= 1000)
        //            {
        //                Console.WriteLine("Conto Aperto!");
        //                Console.WriteLine(Environment.NewLine);
        //                Console.WriteLine(Environment.NewLine);

        //                bool end = false;
        //                while (!end)
        //                {

        //                    Console.WriteLine("1 - versare");
        //                    Console.WriteLine("2 - prelevare");
        //                    Console.WriteLine("3 - stato conto");
        //                    Console.WriteLine("4 - Esci");

        //                    Console.Write("Scegli l'opzione: ");
        //                    string option = Console.ReadLine();

        //                    //Console.Clear();
        //                    Console.WriteLine(Environment.NewLine);
        //                    switch (option)
        //                    {
        //                        case "1":
        //                            Console.Write("Montante da versare: ");
        //                            double versamento = double.Parse(Console.ReadLine());
        //                            saldo += versamento;
        //                            break;

        //                        case "2":
        //                            Console.Write("Montante da prelevare: ");
        //                            double prelievo = double.Parse(Console.ReadLine());
        //                            saldo -= prelievo;
        //                            break;

        //                        case "3":
        //                            Console.OutputEncoding = System.Text.Encoding.UTF8;
        //                            Console.WriteLine($"Hai nel conto {saldo}€");
        //                            break;

        //                        case "4":
        //                            end = true;
        //                            break;

        //                    }
        //                }

        //                return;
        //            } else
        //            {
        //                Console.WriteLine("Il primo versamento deve essere di almeno 1000€");
        //                Console.Write("Rinserire versamento iniziale: ");
        //                saldo = double.Parse(Console.ReadLine());
        //            }
        //        }
        //    }
        //}

        //class ContoCorrente
        //{
        //    string _nominativo;
        //    double _saldo;

        //    public string Nominativo
        //    {
        //        get { return _nominativo;}
        //        set { _nominativo = value;}
        //    }

        //    public double Saldo
        //    {
        //        get { return _saldo;}
        //        set 
        //        { 
        //            _saldo = value;
        //        }
        //    }

        //    public ContoCorrente(string nominativo, double saldo)
        //    {
        //        Nominativo = nominativo;
        //        Saldo = saldo;
        //    }



        // ESERCIZIO 2
        //static void Main(string[] args)
        //{
        //    Console.Write("Inserisci il numero di nomi: ");
        //    int numeroNomi = int.Parse(Console.ReadLine());
        //    string[] nomi = new string[numeroNomi];

        //    // Popola l'array con i nomi da inserire
        //    for (int i = 0; i < numeroNomi; i++)
        //    {
        //        Console.Write($"Inserisci il nome {i + 1}: ");
        //        nomi[i] = Console.ReadLine();
        //    }

        //    Console.Write("Inserisci il nome da cercare: ");
        //    string nomeDaCercare = Console.ReadLine();

        //    bool nomePresente = false;
        //    foreach (string nome in nomi)
        //    {
        //        if (nomeDaCercare.ToLower() == nome.ToLower())
        //        {
        //            nomePresente = true;
        //            break;
        //        }
        //    }

        //    if (nomePresente)
        //    {
        //        Console.WriteLine($"Il nome {nomeDaCercare} è presente nell'array.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Il nome {nomeDaCercare} non è presente nell'array.");
        //    }
        //}
    }
}
