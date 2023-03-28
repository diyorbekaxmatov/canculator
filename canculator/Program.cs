namespace ConsoleApp2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Birinchi sonni kiriting: ");
            string birinchison = Console.ReadLine();
            bool isnumber = double.TryParse(birinchison, out double raqam);
            if (isnumber)
            {
                Console.Write(" +, -, *, /, % shu amallardan birini  kiriting ");
                string amal = Console.ReadLine();
                if (amal.Length == 1)
                {
                    Console.Write(" Ikkinchi sonni kiriting: ");
                    string ikkinchison = Console.ReadLine();
                    bool isnumber2 = double.TryParse(ikkinchison, out double raqamm);
                    if (isnumber2)
                    {
                        if (amal == "+")
                        {
                            Console.WriteLine($"{birinchison}+{ikkinchison}={raqam + raqamm}");
                        }
                        else if (amal == "-")
                        {
                            Console.WriteLine($"{birinchison}-{ikkinchison}={raqam - raqamm}");
                        }
                        else if (amal == "*" && raqam > 0 && raqamm > 0)
                        {
                            Console.WriteLine($"{birinchison}*{ikkinchison}={raqam * raqamm}");
                        }
                        else if (amal == "/" && raqam > 0 && raqamm > 0)
                        {
                            Console.WriteLine($"{birinchison}/{ikkinchison}={raqam / raqamm}");
                        }
                        else if (amal == "%" && raqam > 0 && raqamm > 0)
                        {
                            Console.WriteLine($"{birinchison}%{ikkinchison}={raqam % raqamm}");
                        }
                        else
                        {
                            Console.WriteLine("unday amalni bajarib bo'lmaydi ");
                        }
                    }
                    else if (1 == 1)
                    {
                        Console.WriteLine($"'{ikkinchison}'bu raqam emas !");
                    }
                }
                else
                {
                    Console.WriteLine(" Noto'g'ri amal yoki 1 ta dan ortiq amal kiritdingiz  ");
                }
            }
            else Console.WriteLine($"'{birinchison}' bu raqam emas ! ");

            Main(args);
        }
    }
}