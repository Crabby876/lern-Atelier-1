namespace WokabelTrainer
{
    internal class Program
    {
        private static Dictionary<string, string> voki = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            Wörtereintragen();

            Console.WriteLine("Möchten Sie diese Wörter lernen oder möchten Sie, Ihre Fähigkeiten testen?");
            Console.WriteLine("(Für Fähigkeiten testesn geben Sie 'testen' ein und zum üben 'üben'.)");
            string antwort = Console.ReadLine();
            if (antwort.ToLower()== "üben")
            {
                Console.Clear();
                üben();
            }
            else
            {
                if (antwort.ToLower() == "testen");
                Console.Clear();
                testen();

            }


        }
        static void Wörtereintragen()
        {
            while (true)
            {
                Console.Write("Geben Sie das DE Wort ein (Falls Sie alle Wörter eingetragen haben klicken Sie zwei mal Enter): ");
                string eingabe1 = Console.ReadLine();
                Console.Write("Geben Sie nun Das FR Wort ein: ");
                string eingabe2 = Console.ReadLine();
                Console.Clear();


                if (eingabe1 == "")
                {
                    break;
                }
                else
                {
                    voki.Add(eingabe1, eingabe2);

                }
            }
        }
        static void üben()
        {
            Console.WriteLine("Funktionen:");
            Console.WriteLine("Um ein Wort zu wechseln onder die Übersetzung zu sehen,");
            Console.WriteLine("klicken Sie Enter.");
            Console.WriteLine("Falls Sie finden das Sie genug gelernt haben, ");
            Console.WriteLine("klicken Sie . um den Programm zu schliessen");
            Thread.Sleep(12000);
            Console.Clear();

            foreach (var eintrag in voki)
            {
                Console.WriteLine($"Deutsch: {eintrag.Key}");
                Console.WriteLine("-----------------------");
                Console.WriteLine();


                while (true)
                {
                    string enter = Console.ReadLine();
                    if (enter == "")
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        if (enter == ".")
                        {
                            Environment.Exit(0);
                        }
                    }
                }


                Console.WriteLine($"Fanzösisch: {eintrag.Value}");
                Console.WriteLine("-----------------------");
                Console.WriteLine();

                while (true)
                {
                    string enter = Console.ReadLine();
                    if (enter == "")
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        if (enter == ".")
                        {
                            Environment.Exit(0);
                        }
                    }
                }
                Console.Clear();
            }
        }
        static void testen()
        {
            int richtig = 0;
            int falsch = 0;
            Dictionary<string, string> fähler = new Dictionary<string, string>();
            Console.WriteLine("Funktion:");
            Console.WriteLine();
            Console.WriteLine("Es wird Ihnen ein Wort auf Deutsch gegeb,");
            Console.WriteLine("welches Sie dann auf Französisch übersetzen müssen.");
            Console.WriteLine("Am ende wird ihnen Angezeigt wieviel sie richtig oder falsch gelöst haben");
            Console.WriteLine("Um zu der nächsetn Aufgabe zugelangen klicken Sie einfach Enter.");
            Console.WriteLine("Falls Sie das Programm schliessen möchten klicken sie ' . ' .");
            Console.WriteLine("Viel Erfolg!!!");
            Thread.Sleep(17000);
            Console.Clear();

            foreach (var eintrag in voki) 
            {
                Console.WriteLine($"Deutsch: {eintrag.Key}");
                Console.WriteLine("-----------------------");
                Console.WriteLine();
                string übersetzung = Console.ReadLine();
                if (übersetzung == eintrag.Value)
                {
                    Console.WriteLine("Gut gemacht ihre antwort ist richtig.");
                    richtig++;

                    while (true)
                    {
                        string enter = Console.ReadLine();
                        if (enter == "")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            if (enter == ".")
                            {
                                Environment.Exit(0);
                            }
                        }
                    }

                }
                else
                {
                    if(übersetzung != eintrag.Value) 
                    {
                        Console.WriteLine("Schade. Diese Antwort war leider falsch.");
                        falsch++;
                        fähler.Add(eintrag.Key, eintrag.Value);

                        while (true)
                        {
                            string enter = Console.ReadLine();
                            if (enter == "")
                            {
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                if (enter == ".")
                                {
                                    Environment.Exit(0);
                                }
                            }
                        }
                    }
                }

            }

            if (richtig > falsch)
            {
                Console.WriteLine($"Gut gemacht Sie haben {richtig} Aufgaben richtig");
                Console.WriteLine($" und {falsch} Aufgaben falsch gelöst.");
            }else if (richtig < falsch) 
            {
                Console.WriteLine($"Dies mal waren Sie nicht sehr gut. Sie haben {falsch} Aufgaben falsch ");
                Console.WriteLine($"und {richtig} Afgaben richtig gelöst.");
            }
            Console.Write("Möchten Sie Ihre Fähler erneut lösen? [y|n] ");
            string yn = Console.ReadLine();
            if ( yn.ToLower() == "y")
            {
                Console.Clear();
                while (true) 
                {
                    foreach (var eingabe in fähler)
                    {
                        Console.WriteLine($"Deutsch: {eingabe.Key}");
                        Console.WriteLine("------------------");
                        Console.WriteLine();
                        string übersetzungNeu = Console.ReadLine();
                        if (übersetzungNeu == eingabe.Value)
                        {
                            Console.WriteLine("Gute gemacht. Sie haben Ihren Fähler verbessert.");
                            //Frae? Funktioniert nicht.
                            fähler.Remove(übersetzungNeu);
                            falsch--;
                            Console.Clear();


                        }
                        else if (übersetzungNeu != eingabe.Value)
                        {
                            Console.WriteLine("Schade. Diese Antwort war leider Falsch,");
                            Console.Clear();
               

                        }
                        if (falsch != 0) 
                        {
                        
                        }
                        else
                        {
                            if(falsch == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Gut gemacht Sie haben alle Ihre Fähler korrigiert");
                                Environment.Exit(0);

                            }
                        }
                        


                    }
                }
                
            }
        }
    }
}