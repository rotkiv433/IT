using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//@author Viktor Ilievski
namespace testingFromBook
{

    class Program
    {

        static void Main(string[] args)
        {

            Salter[] s1 = new Salter[100];
            int klientS1 = 0;
            Salter[] s2 = new Salter[100];
            int klientS2 = 0;
            Salter[] s3 = new Salter[100];
            int klientS3 = 0;
            Salter[] s4 = new Salter[100];
            int klientS4 = 0;
            Salter[] s5 = new Salter[100];
            int klientS5 = 0;
            int ucesnik = 0;
            int odberenUcesnik = 0;
            int[] sum = new int[5];
            sum[0] = 0;
            sum[1] = 0;
            sum[2] = 0;
            sum[3] = 0;
            sum[4] = 0;
            for (int i = 0; i < 100; i++)
            {
                s1[i] = new Salter();
                s2[i] = new Salter();
                s3[i] = new Salter();
                s4[i] = new Salter();
                s5[i] = new Salter();

            }
            //VKUPNO 5 SALTERI;
            //VKUPNO 100 KLIENTI PO SALTER
            Console.WriteLine("1. Usluzi go klientot (vnesi ime, prezime, godini, i pozelna destinacija za klientot; i broj na salter)");
            Console.WriteLine("2. Prodadeni karti na salterot (vnesi broj na salter) (vo daden opseg na vreme)");
            Console.WriteLine("3. Vkupen promet na salterot (vnesi broj na salter) (vo daden opseg na vreme)");
            Console.WriteLine("4. Site prodadeni karti na agencijata, organizirani po salter (vo daden opseg na vreme)");
            Console.WriteLine("5. Vkupen promet na agencijata");
            Console.WriteLine("6. Uspesnost na angencijata (odnos na: brojot na usluzeni klienti od site salteri i brojot na site klienti koi dosle vo agencijata");
            Console.WriteLine("7. Izlez");
            Console.WriteLine();
            

            string vlez = "";

            while (vlez != "7")
            {
                Console.WriteLine("DESTINACII: Rim, London, Tokio, Sofija, Istanbul, Toronto, Majami, Zagreb, Belgrad, Moskva");
                Console.Write("ODBERI USLUGA: ");
                vlez = Console.ReadLine();
                switch (vlez)
                {
                    //VNESUVANJE NA KORISNIK VO SISTEMOT
                    case "1":
                        {
                            bool flag = false;
                            //KORISNIK DOJDEN NA SALTER (ucesnik)
                            ucesnik++;

                            Console.Write("Vnesi ime: ");
                            string ime = Console.ReadLine();
                            Console.Write("Vnesi prezime: ");
                            string prezime = Console.ReadLine();
                            Console.Write("Vnesi godini: ");
                            int godini = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Vnesi destinacija: ");
                            string destinacija = Console.ReadLine();

                            //PROVERUVANJE NA DOBRO VNESENA DESTINACIJA
                            if (destinacija.Equals("Rim") || destinacija.Equals("London") ||
                                        destinacija.Equals("Tokio") || destinacija.Equals("Sofija") ||
                                        destinacija.Equals("Majami") || destinacija.Equals("Istanbul") ||
                                        destinacija.Equals("Zagreb") || destinacija.Equals("Toronto") ||
                                        destinacija.Equals("Belgrad") || destinacija.Equals("Moskva"))
                            {
                                flag = true;
                                //USPESNO POMINAT KORISNIK (odberenKorisnik)
                                odberenUcesnik++;
                            }


                            Console.Write("Vnesi salter: ");
                            int salter = Convert.ToInt32(Console.ReadLine());
                            string vreme = DateTime.Now.ToString("HH:mm");
                            //DOKOLKU E DOBRO VNESENA, SE ZAPISUVA KORISNIKOT VO SISTEMOT
                            if (flag)
                            {
                                //ODREDUVA NA KOJ SALTER E ZAPISAN KORISNIKOT
                                //VO USLOVITE SE VLEGUVA SAMO DOKOLKU KORISNIKOT E USPESNO ZAPISAN
                                //klientS* SE ZGOLEMUVA SAMO DOKOLKU KORISNIKOT E USPESNO ZAPISAN
                                if (salter == 1)
                                {
                                    s1[klientS1].Ime = ime;
                                    s1[klientS1].Prezime = prezime;
                                    s1[klientS1].Godini = godini;
                                    s1[klientS1].Destinacija = destinacija;
                                    s1[klientS1].Vreme = vreme;
                                    sum[0] += s1[klientS1].Destinacija.Length * 2000;
                                    Console.WriteLine();
                                    Console.WriteLine("Korisnikot " + s1[klientS1].Ime + " e dodaden vo: " + s1[klientS1].Vreme);
                                    Console.WriteLine();
                                    klientS1++;
                                }
                                else if (salter == 2)
                                {
                                    s2[klientS2].Ime = ime;
                                    s2[klientS2].Prezime = prezime;
                                    s2[klientS2].Godini = godini;
                                    s2[klientS2].Destinacija = destinacija;
                                    s2[klientS2].Vreme = vreme;
                                    sum[1] += s2[klientS2].Destinacija.Length * 2000;
                                    Console.WriteLine();
                                    Console.WriteLine("Korisnikot " + s2[klientS2].Ime + " e dodaden vo: " + s2[klientS2].Vreme);
                                    Console.WriteLine();
                                    klientS2++;
                                }
                                else if (salter == 3)
                                {
                                    s3[klientS3].Ime = ime;
                                    s3[klientS3].Prezime = prezime;
                                    s3[klientS3].Godini = godini;
                                    s3[klientS3].Destinacija = destinacija;
                                    s3[klientS3].Vreme = vreme;
                                    sum[2] += s3[klientS3].Destinacija.Length * 2000;
                                    Console.WriteLine();
                                    Console.WriteLine("Korisnikot " + s3[klientS3].Ime + " e dodaden vo: " + s3[klientS3].Vreme);
                                    Console.WriteLine();
                                    klientS3++;
                                }
                                else if (salter == 4)
                                {
                                    s4[klientS4].Ime = ime;
                                    s4[klientS4].Prezime = prezime;
                                    s4[klientS4].Godini = godini;
                                    s4[klientS4].Destinacija = destinacija;
                                    s4[klientS4].Vreme = vreme;
                                    sum[3] += s4[klientS4].Destinacija.Length * 2000;
                                    Console.WriteLine();
                                    Console.WriteLine("Korisnikot " + s4[klientS4].Ime + " e dodaden vo: " + s4[klientS4].Vreme);
                                    Console.WriteLine();
                                    klientS4++;
                                }
                                else if (salter == 5)
                                {
                                    s5[klientS5].Ime = ime;
                                    s5[klientS5].Prezime = prezime;
                                    s5[klientS5].Godini = godini;
                                    s5[klientS5].Destinacija = destinacija;
                                    s5[klientS5].Vreme = vreme;
                                    sum[4] += s5[klientS5].Destinacija.Length * 2000;
                                    Console.WriteLine();
                                    Console.WriteLine("Korisnikot " + s5[klientS5].Ime +" e dodaden vo: "+s5[klientS5].Vreme);
                                    Console.WriteLine();
                                    klientS5++;
                                    

                                }
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Korisnikot ne e dodaden poradi nepostoecka destinacija");
                                Console.WriteLine();
                            }

                            if (salter > 5 || salter < 1)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Nevaliden salter: Odberete salter od 1 do 5");
                                Console.WriteLine();
                                ucesnik--;
                                odberenUcesnik--;
                            }

                        }

                        break;
                    case "2":
                        //    BROJ NA PRODADENI KARTI OD SALTER VO VNESENO VREME;
                        {
                            Console.Write("Vnesete salter: ");
                            int salter = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Vnesete pocetok na vreme (FORMAT HH:mm) = ");
                            string timeStart;
                            string timeEnd;
                            while (true)
                            {
                                timeStart = Console.ReadLine();
                                if (checkTimeStart(timeStart))
                                    break;
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Pogresen format! / Nevalidno vreme");
                                    Console.Write("Vnesete pocetok na vreme (FORMAT HH:mm) = ");
                                }
                                    
                            }
                            
                            
                            Console.Write("Vnesete kraj na vreme (FORMAT HH:mm) = ");
                            while(true)
                            {
                                timeEnd = Console.ReadLine();
                                if (checkTimeEnd(timeEnd))
                                    break;
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Pogresen format! / Nevalidno vreme");
                                    Console.Write("Vnesete kraj na vreme (FORMAT HH:mm) = ");
                                }
                            }
                            

                            if (salter == 1)
                            {
                                int brojacKlientS1 = 0;
                                for (int i = 0; i < klientS1; i++)
                                {
                                    if (string.Compare(s1[i].Vreme, timeStart) != -1 && string.Compare(s1[i].Vreme, timeEnd) == -1)
                                        brojacKlientS1++;
                                }
                                Console.WriteLine();
                                Console.WriteLine("Broj na karti na salterot " + salter + " vo vreme od: " + timeStart + " do " + timeEnd + " e: " + brojacKlientS1);
                                Console.WriteLine();
                            }

                            else if (salter == 2)
                            {
                                int brojacKlientS2 = 0;
                                for(int i=0;i<klientS2;i++)
                                {
                                    if (string.Compare(s2[i].Vreme, timeStart) != -1 && string.Compare(s2[i].Vreme, timeEnd) == -1)
                                        brojacKlientS2++;
                                }
                                Console.WriteLine();
                                Console.WriteLine("Broj na karti na salterot " + salter + " vo vreme od: " + timeStart + " do " + timeEnd + " e: " + brojacKlientS2);
                                Console.WriteLine();
                            }
                                
                            else if (salter == 3)
                            {
                                int brojacKlientS3 = 0;
                                for (int i = 0; i < klientS3; i++)
                                {
                                    if (string.Compare(s3[i].Vreme, timeStart) != -1 && string.Compare(s3[i].Vreme, timeEnd) == -1)
                                        brojacKlientS3++;
                                }
                                Console.WriteLine();
                                Console.WriteLine("Broj na karti na salterot " + salter + " vo vreme od: " + timeStart + " do " + timeEnd + " e: " + brojacKlientS3);
                                Console.WriteLine();
                            }
                                
                            else if (salter == 4)
                            {
                                int brojacKlientS4 = 0;
                                for (int i = 0; i < klientS4; i++)
                                {
                                    if (string.Compare(s4[i].Vreme, timeStart) != -1 && string.Compare(s4[i].Vreme, timeEnd) == -1)
                                        brojacKlientS4++;
                                }
                                Console.WriteLine();
                                Console.WriteLine("Broj na karti na salterot " + salter + " vo vreme od: " + timeStart + " do " + timeEnd + " e: " + brojacKlientS4);
                                Console.WriteLine();
                            }
                                
                            else if (salter == 5)
                            {
                                int brojacKlientS5 = 0;
                                for (int i = 0; i < klientS5; i++)
                                {
                                    if (string.Compare(s5[i].Vreme, timeStart) != -1 && string.Compare(s5[i].Vreme, timeEnd) == -1)
                                        brojacKlientS5++;
                                }
                                Console.WriteLine();
                                Console.WriteLine("Broj na karti na salterot " + salter + " vo vreme od: " + timeStart + " do " + timeEnd + " e: " + brojacKlientS5);
                                Console.WriteLine();
                            }
                                

                            else
                            {
                                Console.WriteLine();
                                Console.Write("Nevaliden salter. Odberete salter od 1 do 5!");
                                Console.WriteLine();
                            }

                        }
                        break;
                    case "3":
                        //  VKUPEN PROMET OD VNESEN SALTER VO VNESENO VREME;
                        {
                            Console.Write("Vnesete salter: ");
                            int salter = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Vnesete pocetok na vreme (FORMAT HH:mm) = ");
                            string timeStart;
                            string timeEnd;
                            while (true)
                            {
                                timeStart = Console.ReadLine();
                                if (checkTimeStart(timeStart))
                                    break;
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Pogresen format! / Nevalidno vreme");
                                    Console.Write("Vnesete pocetok na vreme (FORMAT HH:mm) = ");
                                }

                            }


                            Console.Write("Vnesete kraj na vreme (FORMAT HH:mm) = ");
                            while (true)
                            {
                                timeEnd = Console.ReadLine();
                                if (checkTimeEnd(timeEnd))
                                    break;
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Pogresen format! / Nevalidno vreme");
                                    Console.Write("Vnesete kraj na vreme (FORMAT HH:mm) = ");
                                }
                            }

                            if (salter == 1)
                            {
                                int suma1 = 0;
                                for (int i = 0; i < klientS1; i++)
                                {
                                    if (string.Compare(s1[i].Vreme, timeStart) != -1 && string.Compare(s1[i].Vreme, timeEnd) == -1)
                                        suma1 += s1[i].Destinacija.Length * 2000;
                                }
                                Console.WriteLine();
                                Console.WriteLine("Vkupen promet na salterot 1 od: " + timeStart + " do: " + timeEnd + " iznesuva: "+suma1);
                                Console.WriteLine();
                            }
                            if (salter == 2)
                            {
                                int suma2 = 0;
                                for (int i = 0; i < klientS2; i++)
                                {
                                    if (string.Compare(s2[i].Vreme, timeStart) != -1 && string.Compare(s2[i].Vreme, timeEnd) == -1)
                                        suma2 += s2[i].Destinacija.Length * 2000;
                                }
                                Console.WriteLine();
                                Console.WriteLine("Vkupen promet na salterot 2 od: " + timeStart + " do: " + timeEnd + " iznesuva: " + suma2);
                                Console.WriteLine();
                            }
                            if (salter == 3)
                            {
                                int suma3 = 0;
                                for (int i = 0; i < klientS3; i++)
                                {
                                    if (string.Compare(s3[i].Vreme, timeStart) != -1 && string.Compare(s3[i].Vreme, timeEnd) == -1)
                                        suma3 += s3[i].Destinacija.Length * 2000;
                                }
                                Console.WriteLine();
                                Console.WriteLine("Vkupen promet na salterot 3 od: " + timeStart + " do: " + timeEnd + " iznesuva: " + suma3);
                                Console.WriteLine();
                            }
                            if (salter == 4)
                            {
                                int suma4 = 0;
                                for (int i = 0; i < klientS4; i++)
                                {
                                    if (string.Compare(s4[i].Vreme, timeStart) != -1 && string.Compare(s4[i].Vreme, timeEnd) == -1)
                                        suma4 += s4[i].Destinacija.Length * 2000;
                                }
                                Console.WriteLine();
                                Console.WriteLine("Vkupen promet na salterot 4 od: " + timeStart + " do: " + timeEnd + " iznesuva: " + suma4);
                                Console.WriteLine();
                            }
                            if (salter == 5)
                            {
                                int suma5 = 0;
                                for (int i = 0; i < klientS5; i++)
                                {
                                    if (string.Compare(s5[i].Vreme, timeStart) != -1 && string.Compare(s5[i].Vreme, timeEnd) == -1)
                                        suma5 += s5[i].Destinacija.Length * 2000;
                                }
                                Console.WriteLine();
                                Console.WriteLine("Vkupen promet na salterot 5 od: " + timeStart + " do: " + timeEnd + " iznesuva: " + suma5);
                                Console.WriteLine();
                            }
                        }
                        break;
                    case "4":
                        //  SITE KARTI PRODADENI STAVENI VO TABELA SPORED SALTERI VO VNESENO VREME;
                        {
                            Console.Write("Vnesete pocetok na vreme (FORMAT HH:mm) = ");
                            string timeStart;
                            string timeEnd;
                            while (true)
                            {
                                timeStart = Console.ReadLine();
                                if (checkTimeStart(timeStart))
                                    break;
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Pogresen format!");
                                    Console.Write("Vnesete pocetok na vreme (FORMAT HH:mm) = ");
                                }

                            }


                            Console.Write("Vnesete kraj na vreme (FORMAT HH:mm) = ");
                            while (true)
                            {
                                timeEnd = Console.ReadLine();
                                if (checkTimeEnd(timeEnd))
                                    break;
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Pogresen format!");
                                    Console.Write("Vnesete kraj na vreme (FORMAT HH:mm) = ");
                                }
                            }

                            Console.WriteLine("Salter 1");
                            Console.WriteLine("Ime\tPrezime\t\tGodini\tDestinacija\tVreme");
                            for (int i = 0; i < klientS1; i++)
                            {
                                if (string.Compare(s1[i].Vreme, timeStart) != -1 && string.Compare(s1[i].Vreme, timeEnd) == -1)
                                    Console.WriteLine(s1[i].Ime + "\t" + s1[i].Prezime + "\t" + s1[i].Godini + "\t" + s1[i].Destinacija + "\t\t" + s1[i].Vreme);
                            }
                            Console.WriteLine();
                            Console.WriteLine("Salter 2");
                            Console.WriteLine("Ime\tPrezime\t\tGodini\tDestinacija\tVreme");
                            for (int i = 0; i < klientS2; i++)
                            {
                                if (string.Compare(s2[i].Vreme, timeStart) != -1 && string.Compare(s2[i].Vreme, timeEnd) == -1)
                                    Console.WriteLine(s2[i].Ime + "\t" + s2[i].Prezime + "\t" + s2[i].Godini + "\t" + s2[i].Destinacija + "\t\t" + s2[i].Vreme);
                            }
                            Console.WriteLine();
                            Console.WriteLine("Salter 3");
                            Console.WriteLine("Ime\tPrezime\t\tGodini\tDestinacija\tVreme");
                            for (int i = 0; i < klientS3; i++)
                            {
                                if (string.Compare(s3[i].Vreme, timeStart) != -1 && string.Compare(s3[i].Vreme, timeEnd) == -1)
                                    Console.WriteLine(s3[i].Ime + "\t" + s3[i].Prezime + "\t" + s3[i].Godini + "\t" + s3[i].Destinacija + "\t\t" + s3[i].Vreme);
                            }
                            Console.WriteLine();
                            Console.WriteLine("Salter 4");
                            Console.WriteLine("Ime\tPrezime\t\tGodini\tDestinacija\tVreme");
                            for (int i = 0; i < klientS4; i++)
                            {
                                if (string.Compare(s4[i].Vreme, timeStart) != -1 && string.Compare(s4[i].Vreme, timeEnd) == -1)
                                    Console.WriteLine(s4[i].Ime + "\t" + s4[i].Prezime + "\t" + s4[i].Godini + "\t" + s4[i].Destinacija + "\t\t" + s4[i].Vreme);
                            }
                            Console.WriteLine();
                            Console.WriteLine("Salter 5");
                            Console.WriteLine("Ime\tPrezime\t\tGodini\tDestinacija\tVreme");
                            for (int i = 0; i < klientS5; i++)
                            {
                                if (string.Compare(s5[i].Vreme, timeStart) != -1 && string.Compare(s5[i].Vreme, timeEnd) == -1)
                                    Console.WriteLine(s5[i].Ime + "\t" + s5[i].Prezime + "\t" + s5[i].Godini + "\t" + s5[i].Destinacija + "\t\t" + s5[i].Vreme);
                            }
                        }
                        break;
                    case "5":
                        //  VKUPEN PROMET NA CELA AGENCIJA;
                        {
                            int zbir = sum[0] + sum[1] + sum[2] + sum[3] + sum[4];
                            Console.WriteLine();
                            Console.WriteLine("Vkupen promet na agencijata: " + zbir);
                            Console.WriteLine();
                        }
                        break;
                    case "6":
                        //  USPESNOST NA AGENCIJA, ODNOS POMEGJU ZAPISANI I NEZAPISANI KLIENTI;
                        {
                            Console.WriteLine();
                            Console.Write("Uspesnost na agencijata (broj na usluzeni klienti / broj na klienti koi dosle vo agencijata): ");
                            Console.WriteLine(ucesnik + "/" + odberenUcesnik);
                            Console.WriteLine();
                        }
                        break;
                    case "7":
                        //  IZLEZ OD PROGRAMATA;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("NEVALIDEN VNES, OBIDETE SE PAK!");
                        Console.WriteLine();
                        break;
                }

            }

        }

        private static bool checkTimeStart(string timeStart)
        {
            char[] znak = timeStart.ToCharArray();
            if (znak[0] > '2'
                || znak[3] > '5')
                return false;
            if (znak[0] == '2' && znak[1] > '3')
                return false;
            if (timeStart.Length == 5
                && Char.IsDigit(znak[0])
                && Char.IsDigit(znak[1])
                && znak[2] == ':'
                && Char.IsDigit(znak[3])
                && Char.IsDigit(znak[4]))
            {
                return true;
            }
            else
                return false;
        }

        private static bool checkTimeEnd(string timeEnd)
        {
            char[] znak = timeEnd.ToCharArray();
            if (znak[0] > '2'
                || znak[3] > '5')
                return false;
            if (znak[0] == '2' && znak[1] > '3')
                return false;
            if (timeEnd.Length==5
                && Char.IsDigit(znak[0])
                && Char.IsDigit(znak[1])
                && znak[2] == ':'
                && Char.IsDigit(znak[3])
                && Char.IsDigit(znak[4]))
            {
                return true;
            }
            else
                return false;
        }
    }
}
//@author Viktor Ilievski
