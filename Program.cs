using System;

namespace ConsoleAppBankapp
{
    class Program
    {
        static void Main(string[] args)
        {

            SavingsAccount Konto = new SavingsAccount();

            bool checkbool1 = false;
            bool checkbool2 = false;
            bool checkbool3 = false;

            string checknumber2;

            int checknumber1;

            string skapanyttkonto;

            Console.WriteLine("Räntesatsen är: " + Konto.räntesats);


            Console.WriteLine(Konto.saldo);
            while (checkbool3 == false)
            {
                while (checkbool1 == false)
                {
                    Console.WriteLine("Hej vad heter du?: ");
                    checknumber2 = Console.ReadLine();
                    if (checknumber2 != "")
                    {
                        checkbool1 = true;
                        Konto.namn = checknumber2;
                    }
                    else
                    {
                        Console.WriteLine("negativ saldo, går inte!");
                    }
                }
                while (checkbool2 == false)
                {
                    Console.WriteLine("Hej hur mycket pengar vill du lägga in?: ");
                    checknumber1 = Convert.ToInt32(Console.ReadLine());
                    if (checknumber1 >= 0)
                    {
                        checkbool2 = true;
                        Konto.saldo = checknumber1;
                    }
                    else
                    {
                        Console.WriteLine("negativ saldo, går inte!");
                    }
                }


                //Console.WriteLine(Konto.Insättning(100)); 
                Console.WriteLine(Konto.ToString());
                Console.WriteLine("");
                Console.WriteLine("Namn: " + Konto.namn);
                Console.WriteLine("Hur mycket pengar som du har lagt in: " + Konto.saldo);

                Console.WriteLine("kontonummer: " + Konto.kontonummer);
                Console.WriteLine("Hej vill du fortsätta skapa ett till konto? (j = ja, fortsätta / n = nej, avsluta): ");
                skapanyttkonto = Console.ReadLine();
                if (skapanyttkonto == "j")
                {
                    checkbool1 = false;
                    checkbool2 = false;
                    checkbool3 = false;
                }
                else if (skapanyttkonto == "n")
                {
                    checkbool3 = true;
                }

            }
            
            SavingsAccount pers2 = new SavingsAccount();
            Console.WriteLine(pers2.kontonummer);
            Console.WriteLine(pers2.ToString());
        }


        static void Main2(string[] args)
        {
            SavingsAccount Konto = new SavingsAccount();

            bool checkbool1 = false;
            bool checkbool2 = false;
            bool checkbool3 = false;

            string checknumber2;

            int checknumber1;

            string skapanyttkonto;

            Console.WriteLine("Räntesatsen är: " + Konto.räntesats);


            Console.WriteLine(Konto.saldo);
            while (checkbool3 == false)
            {
                while (checkbool1 == false)
                {
                    Console.WriteLine("Hej vad heter du?: ");
                    checknumber2 = Console.ReadLine();
                    if (checknumber2 != "")
                    {
                        checkbool1 = true;
                        Konto.namn = checknumber2;
                    }
                    else
                    {
                        Console.WriteLine("negativ saldo, går inte!");
                    }
                }
                while (checkbool2 == false)
                {
                    Console.WriteLine("Hej hur mycket pengar vill du lägga in?: ");
                    checknumber1 = Convert.ToInt32(Console.ReadLine());
                    if (checknumber1 >= 0)
                    {
                        checkbool2 = true;
                        Konto.saldo = checknumber1;
                    }
                    else
                    {
                        Console.WriteLine("negativ saldo, går inte!");
                    }
                }


                //Console.WriteLine(Konto.Insättning(100)); 

                Console.WriteLine("Namn: " + Konto.namn);
                Console.WriteLine("Hur mycket pengar som du har lagt in: " + Konto.saldo);

                Console.WriteLine("kontonummer: " + Konto.kontonummer);
                Console.WriteLine("Hej vill du fortsätta skapa ett till konto? (j = ja, fortsätta / n = nej, avsluta): ");
                skapanyttkonto = Console.ReadLine();
                if (skapanyttkonto == "j")
                {
                    checkbool1 = false;
                    checkbool2 = false;
                    checkbool3 = false;
                }
                else if (skapanyttkonto == "n")
                {
                    checkbool3 = true;
                }

            }


        }
    }


    class SavingsAccount
    {
        public SavingsAccount()
        {
            global_kontonummer++;
            konto_kontonummer = global_kontonummer;
        }
        private protected double kontosaldo;
        public double saldo
        {
            get { return kontosaldo; }
            set { if (value >= 0) kontosaldo = value; }
        }

        private protected string kontonamn;
        public string namn
        {
            get { return kontonamn; }
            set { if (value != "") kontonamn = value; }
        }

        private static int global_kontonummer = 1000;   // samma variabel för alla SavingsAccount objekt
        private protected int konto_kontonummer;        // det här objektets kontonummer
        public int kontonummer
        {

            get { return konto_kontonummer; }
            set { konto_kontonummer = value; }
        }

        private protected double kontoräntesats = 1.0;
        public double räntesats
        {
            get { return kontoräntesats; }
            set { kontoräntesats = value; }
        }
        public double ränta
        {
            get { return kontosaldo * (kontoräntesats / 100); }
        }

        public string kontotyp = "sparkonto";

        public double Insättning(double kronor)
        {
            kontosaldo += kronor;
            return kontosaldo;
        }

        public double Uttag(double kronor)
        {
            kontosaldo -= kronor;
            return kontosaldo;
        }

        public override string ToString()
        {
            return "Namn: " + kontonamn + "\nkontonummer: " + konto_kontonummer + "\nsaldo: " + kontosaldo + "\nkontotyp: " + "sparkonto" + "\nkontotyp: " + kontoräntesats;
        }

    }
}
