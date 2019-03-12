using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoriska1
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
                                    sum[0] += s1[klientS1].Destinacija.Length * 2000;
                                    klientS1++;
                                }
                                else if (salter == 2)
                                {
                                    s2[klientS2].Ime = ime;
                                    s2[klientS2].Prezime = prezime;
                                    s2[klientS2].Godini = godini;
                                    s2[klientS2].Destinacija = destinacija;
                                    sum[1] += s2[klientS2].Destinacija.Length * 2000;
                                    klientS2++;
                                }
                                else if (salter == 3)
                                {
                                    s3[klientS3].Ime = ime;
                                    s3[klientS3].Prezime = prezime;
                                    s3[klientS3].Godini = godini;
                                    s3[klientS3].Destinacija = destinacija;
                                    sum[2] += s3[klientS3].Destinacija.Length * 2000;
                                    klientS3++;
                                }
                                else if (salter == 4)
                                {
                                    s4[klientS4].Ime = ime;
                                    s4[klientS4].Prezime = prezime;
                                    s4[klientS4].Godini = godini;
                                    s4[klientS4].Destinacija = destinacija;
                                    sum[3] += s4[klientS4].Destinacija.Length * 2000;
                                    klientS4++;
                                }
                                else if (salter == 5)
                                {
                                    s5[klientS5].Ime = ime;
                                    s5[klientS5].Prezime = prezime;
                                    s5[klientS5].Godini = godini;
                                    s5[klientS5].Destinacija = destinacija;
                                    sum[4] += s5[klientS5].Destinacija.Length * 2000;
                                    klientS5++;
                                }
                            }

                            if (salter > 5 || salter < 1)
                            {
                                Console.WriteLine("Nevaliden salter: Odberete salter od 1 do 5");
                            }

                        }

                        break;
                    case "2":
                        //    BROJ NA PRODADENI KARTI OD SALTER;
                        {
                            Console.Write("Vnesete salter: ");
                            int salter = Convert.ToInt32(Console.ReadLine());
                            if (salter == 1)
                                Console.WriteLine("Broj na karti na salterot " + salter + " e: " + klientS1);
                            else if (salter == 2)
                                Console.WriteLine("Broj na karti na salterot " + salter + " e: " + klientS2);
                            else if (salter == 3)
                                Console.WriteLine("Broj na karti na salterot " + salter + " e: " + klientS3);
                            else if (salter == 4)
                                Console.WriteLine("Broj na karti na salterot " + salter + " e: " + klientS4);
                            else if (salter == 5)
                                Console.WriteLine("Broj na karti na salterot " + salter + " e: " + klientS5);

                            else
                            {
                                Console.Write("Nevaliden salter. Odberete salter od 1 do 5!");
                            }

                        }
                        break;
                    case "3":
                        //  VKUPEN PROMET OD VNESEN SALTER;
                        {
                            Console.Write("Vnesete salter: ");
                            int salter = Convert.ToInt32(Console.ReadLine());
                            if (salter == 1)
                            {
                                Console.WriteLine("Promet na salterot 1 e " + sum[0]);
                            }
                            if (salter == 2)
                            {
                                Console.WriteLine("Promet na salterot 2 e " + sum[1]);
                            }
                            if (salter == 3)
                            {
                                Console.WriteLine("Promet na salterot 3 e " + sum[2]);
                            }
                            if (salter == 4)
                            {
                                Console.WriteLine("Promet na salterot 4 e " + sum[3]);
                            }
                            if (salter == 5)
                            {
                                Console.WriteLine("Promet na salterot 5 e " + sum[4]);
                            }
                        }
                        break;
                    case "4":
                        //  SITE KARTI PRODADENI STAVENI VO TABELA SPORED SALTERI;
                        {
                            Console.WriteLine("Salter 1");
                            Console.WriteLine("Ime\tPrezime\t\tGodini\tDestinacija");
                            for (int i = 0; i < klientS1; i++)
                            {
                                Console.WriteLine(s1[i].Ime + "\t" + s1[i].Prezime + "\t" + s1[i].Godini + "\t" + s1[i].Destinacija);
                            }
                            Console.WriteLine();
                            Console.WriteLine("Salter 2");
                            Console.WriteLine("Ime\tPrezime\t\tGodini\tDestinacija");
                            for (int i = 0; i < klientS2; i++)
                            {
                                Console.WriteLine(s2[i].Ime + "\t" + s2[i].Prezime + "\t" + s2[i].Godini + "\t" + s2[i].Destinacija);
                            }
                            Console.WriteLine();
                            Console.WriteLine("Salter 3");
                            Console.WriteLine("Ime\tPrezime\t\tGodini\tDestinacija");
                            for (int i = 0; i < klientS3; i++)
                            {
                                Console.WriteLine(s3[i].Ime + "\t" + s3[i].Prezime + "\t" + s3[i].Godini + "\t" + s3[i].Destinacija);
                            }
                            Console.WriteLine();
                            Console.WriteLine("Salter 4");
                            Console.WriteLine("Ime\tPrezime\t\tGodini\tDestinacija");
                            for (int i = 0; i < klientS4; i++)
                            {
                                Console.WriteLine(s4[i].Ime + "\t" + s4[i].Prezime + "\t" + s4[i].Godini + "\t" + s4[i].Destinacija);
                            }
                            Console.WriteLine();
                            Console.WriteLine("Salter 5");
                            Console.WriteLine("Ime\tPrezime\t\tGodini\tDestinacija");
                            for (int i = 0; i < klientS5; i++)
                            {
                                Console.WriteLine(s5[i].Ime + "\t" + s5[i].Prezime + "\t" + s5[i].Godini + "\t" + s5[i].Destinacija);
                            }
                        }
                        break;
                    case "5":
                        //  VKUPEN PROMET NA CELA AGENCIJA;
                        {
                            int zbir = sum[0] + sum[1] + sum[2] + sum[3] + sum[4];
                            Console.WriteLine("Vkupen promet na agencijata: " + zbir);
                        }
                        break;
                    case "6":
                        //  USPESNOST NA AGENCIJA, ODNOS POMEGJU ZAPISANI I NEZAPISANI KLIENTI;
                        {
                            Console.Write("Uspesnost na agencijata (broj na usluzeni klienti / broj na klienti koi dosle vo agencijata): ");
                            Console.WriteLine(ucesnik + "/" + odberenUcesnik);
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


    }
}
