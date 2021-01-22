using System;
using System.Threading;
using System.Threading.Tasks;

namespace UlerTangga_Main1
{
    class Program
    {
        static void Main(string[] args)
        {
            // page menu
            bool loop = true;
            string[] karakterpemain = new string[5];
            for (int g = 0; g < 5; g++)
            {
                karakterpemain[g] = " ";
            }
            int pilihkarakter = 0;
            int jumlahpemain = 0;


            string[] namapemain1 = new string[4]; // declare pemain untuk di papan

            while (loop == true)
            {
                Console.Clear();

                JUDUL();

                Console.WriteLine("Pemain min 2 max 4");
                Console.Write("Berapa pemain: ");
                jumlahpemain = Convert.ToInt32(Console.ReadLine());

                string[] namapemain = new string[jumlahpemain]; // array tidak bisa keluar di papan

                if (jumlahpemain < 2)
                {
                    Console.Clear();
                    JUDUL();

                    Console.WriteLine("Masukkan jumlah pemain yang benar!!");
                    Console.WriteLine("Tekan enter untuk melanjutkan");
                    Console.ReadKey();
                }
                if (jumlahpemain > 4)
                {
                    Console.Clear();
                    JUDUL();

                    Console.WriteLine("Kebanyakan yang maen!!");
                    Console.WriteLine("Tekan enter untuk melanjutkan");
                    Console.ReadKey();
                }

                if (jumlahpemain > 1 && jumlahpemain < 5)
                {
                    Console.Clear();
                    JUDUL();


                    for (int i = 0; i < jumlahpemain; i++)
                    {
                        Console.Write("Masukkan nama player ke " + (i + 1) + ": ");
                        namapemain[i] = Console.ReadLine();
                    }

                    Console.WriteLine();

                    Console.Clear();

                    Console.OutputEncoding = System.Text.Encoding.Unicode;
                    string[] KARAKTER = new string[11];
                    KARAKTER[1] = "\u25A0";
                    KARAKTER[2] = "\u2660";
                    KARAKTER[3] = "\u2665";
                    KARAKTER[4] = "\u25B2";
                    KARAKTER[5] = "\u2666";
                    KARAKTER[6] = "\u2663";
                    KARAKTER[7] = "●";
                    KARAKTER[8] = "☻";
                    KARAKTER[9] = "♫";
                    KARAKTER[10] = "☼";

                    for (int i = 0; i < jumlahpemain; i++)
                    {
                        JUDUL();


                        Console.WriteLine("Pilih karakter " + namapemain[i]);

                        for (int k = 1; k <= 10; k++)
                        {
                            Console.Write((k) + "." + KARAKTER[k] + "  ");
                        }

                        Console.WriteLine();

                        Console.Write("Karakter pilihan " + namapemain[i] + ": ");
                        pilihkarakter = Convert.ToInt32(Console.ReadLine());

                        karakterpemain[i] = KARAKTER[pilihkarakter];

                        Console.Clear();
                    }

                    JUDUL();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    string maribermain = "MARI KITA BERMAINN!!";
                    Console.SetCursorPosition((Console.WindowWidth - maribermain.Length) / 2, Console.CursorTop);
                    Console.Write(maribermain);
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    loop = false;


                }

                // untuk ngisi menang wkwkwk
                for (int roti = 0; roti < jumlahpemain; roti++)
                {
                    namapemain1[roti] = namapemain[roti];
                }
            }

            // papan bermain
            // nge random uler dan tangga di sini (belum di masukkan)


            string[] player1 = new string[100];
            string[] player2 = new string[100];
            string[] player3 = new string[100];
            string[] player4 = new string[100];
            for (int a = 0; a < 100; a++)
            {
                player1[a] = " ";
                player2[a] = " ";
                player3[a] = " ";
                player4[a] = " ";
            }

            int posisiP1 = 0;
            int posisiP2 = 0;
            int posisiP3 = 0;
            int posisiP4 = 0;


            player1[posisiP1] = karakterpemain[0];
            player2[posisiP2] = karakterpemain[1];
            player3[posisiP3] = karakterpemain[2];
            player4[posisiP4] = karakterpemain[3];

            // RANDOM KEPALA EKOR ATAS BAWAH
            Random RANDOM = new Random();
            int[] KEPALA = new int[6];
            int[] EKOR = new int[6];
            int[] ATAS = new int[6];
            int[] BAWAH = new int[6];
            int[] arrAngka = new int[24];

            int counter = 1;
            arrAngka[0] = 1;

            for (int i = 1; i <= 5; i++)
            {
                bool kembar = true;
                while (kembar == true)
                {
                    EKOR[i] = RANDOM.Next(1, 89);
                    kembar = false;
                    for (int j = 0; j < counter; j++)
                    {
                        if (arrAngka[j] == EKOR[i])
                        {
                            kembar = true;
                        }
                    }
                    if (kembar == false)
                    {
                        arrAngka[counter] = EKOR[i];
                        counter = counter + 1;
                    }
                }

                kembar = true;
                while (kembar == true)
                {
                    int temp = 10 - (EKOR[i] % 10);
                    KEPALA[i] = RANDOM.Next(EKOR[i] + temp, 99);
                    kembar = false;
                    for (int j = 0; j < counter; j++)
                    {
                        if (arrAngka[j] == KEPALA[i])
                        {
                            kembar = true;
                        }
                    }
                    if (kembar == false)
                    {
                        arrAngka[counter] = KEPALA[i];
                        counter = counter + 1;
                    }
                }

                kembar = true;
                while (kembar == true)
                {
                    BAWAH[i] = RANDOM.Next(2, 89);
                    kembar = false;
                    for (int j = 0; j < counter; j++)
                    {
                        if (arrAngka[j] == BAWAH[i])
                        {
                            kembar = true;
                        }
                    }
                    if (kembar == false)
                    {
                        arrAngka[counter] = BAWAH[i];
                        counter = counter + 1;
                    }
                }

                kembar = true;
                while (kembar == true)
                {
                    int temp2 = 10 - (BAWAH[i] % 10);
                    ATAS[i] = RANDOM.Next(BAWAH[i] + temp2, 100);
                    kembar = false;
                    for (int j = 0; j < counter; j++)
                    {
                        if (arrAngka[j] == ATAS[i])
                        {
                            kembar = true;
                        }
                    }
                    if (kembar == false)
                    {
                        arrAngka[counter] = ATAS[i];
                        counter = counter + 1;
                    }
                }
            }
            TabelUlerTangga(KEPALA, EKOR, ATAS, BAWAH);

            int dice = 0;
            int P = 0;

            Papan(posisiP1, posisiP2, posisiP3, posisiP4, KEPALA, EKOR, ATAS, BAWAH, player1, player2, player3, player4);

            bool menang = false;
            while (menang == false)
            {
                if (P == jumlahpemain + 1)
                {
                    P = 1;
                }

                for (int ulangdadu = 0; ulangdadu < dice; ulangdadu++)
                {
                    Console.Clear();
                    // saat posisi di 100 hanya berkurang 1
                    if (P == 1 && posisiP1 != 99)
                    {
                        posisiP1++;
                        player1[posisiP1] = karakterpemain[0];
                        player1[posisiP1 - 1] = " ";

                    }
                    else if (P == 2 && posisiP2 != 99)
                    {
                        posisiP2++;
                        player2[posisiP2] = karakterpemain[1];
                        player2[posisiP2 - 1] = " ";

                    }
                    else if (P == 3)
                    {
                        posisiP3++;
                        player3[posisiP3] = karakterpemain[2];
                        player3[posisiP3 - 1] = " ";

                    }
                    else if (P == 4)
                    {
                        posisiP4++;
                        player4[posisiP4] = karakterpemain[3];
                        player4[posisiP4 - 1] = " ";

                    }


                    if (posisiP1 == 99 && ulangdadu != dice || posisiP2 == 99 && ulangdadu != dice || posisiP3 == 99 && ulangdadu != dice || posisiP4 == 99 && ulangdadu != dice)
                    {
                        for (int pos = 1; pos < dice - ulangdadu; pos++)
                        {
                            Console.Clear();
                            if (P == 1)
                            {
                                posisiP1--;
                                player1[posisiP1] = karakterpemain[0];
                                player1[posisiP1 + 1] = " ";
                            }
                            else if (P == 2)
                            {
                                posisiP2--;
                                player2[posisiP2] = karakterpemain[1];
                                player2[posisiP2 + 1] = " ";
                            }
                            else if (P == 3)
                            {
                                posisiP3--;
                                player3[posisiP3] = karakterpemain[2];
                                player3[posisiP3 + 1] = " ";
                            }
                            else if (P == 4)
                            {
                                posisiP4--;
                                player4[posisiP4] = karakterpemain[3];
                                player4[posisiP4 + 1] = " ";
                            }
                            TabelUlerTangga(KEPALA, EKOR, ATAS, BAWAH);
                            Papan(posisiP1, posisiP2, posisiP3, posisiP4, KEPALA, EKOR, ATAS, BAWAH, player1, player2, player3, player4);
                            Dadu(dice);


                            var l = Task.Run(async delegate
                            {
                                await Task.Delay(500);
                                return 42;
                            });
                            l.Wait();
                        }
                        ulangdadu += dice - ulangdadu;
                        Console.Clear();

                    }
                    TabelUlerTangga(KEPALA, EKOR, ATAS, BAWAH);
                    Papan(posisiP1, posisiP2, posisiP3, posisiP4, KEPALA, EKOR, ATAS, BAWAH, player1, player2, player3, player4);
                    Dadu(dice);
                    var t = Task.Run(async delegate
                    {
                        await Task.Delay(500);
                        return 42;
                    });
                    t.Wait();
                }

                // untuk cek player nginjek kepala / bawah tangga
                if (posisiP1 + 1 == KEPALA[1] || posisiP1 + 1 == KEPALA[2] || posisiP1 + 1 == KEPALA[3] || posisiP1 + 1 == KEPALA[4] || posisiP1 + 1 == KEPALA[5] || posisiP1 + 1 == BAWAH[1] || posisiP1 + 1 == BAWAH[2] || posisiP1 + 1 == BAWAH[3] || posisiP1 + 1 == BAWAH[4] || posisiP1 + 1 == BAWAH[5] ||
                    posisiP2 + 1 == KEPALA[1] || posisiP2 + 1 == KEPALA[2] || posisiP2 + 1 == KEPALA[3] || posisiP2 + 1 == KEPALA[4] || posisiP2 + 1 == KEPALA[5] || posisiP2 + 1 == BAWAH[1] || posisiP2 + 1 == BAWAH[2] || posisiP2 + 1 == BAWAH[3] || posisiP2 + 1 == BAWAH[4] || posisiP2 + 1 == BAWAH[5] ||
                    posisiP3 + 1 == KEPALA[1] || posisiP3 + 1 == KEPALA[2] || posisiP3 + 1 == KEPALA[3] || posisiP3 + 1 == KEPALA[4] || posisiP3 + 1 == KEPALA[5] || posisiP3 + 1 == BAWAH[1] || posisiP3 + 1 == BAWAH[2] || posisiP3 + 1 == BAWAH[3] || posisiP3 + 1 == BAWAH[4] || posisiP3 + 1 == BAWAH[5] ||
                    posisiP4 + 1 == KEPALA[1] || posisiP4 + 1 == KEPALA[2] || posisiP4 + 1 == KEPALA[3] || posisiP4 + 1 == KEPALA[4] || posisiP4 + 1 == KEPALA[5] || posisiP4 + 1 == BAWAH[1] || posisiP4 + 1 == BAWAH[2] || posisiP4 + 1 == BAWAH[3] || posisiP4 + 1 == BAWAH[4] || posisiP4 + 1 == BAWAH[5])
                {
                    Console.Clear();

                    for (int head = 1; head <= 5; head++)
                    {
                        // uler
                        if (posisiP1 + 1 == KEPALA[head])
                        {
                            player1[posisiP1] = " ";
                            posisiP1 = EKOR[head] - 1;
                            player1[posisiP1] = karakterpemain[0];
                        }
                        else if (posisiP2 + 1 == KEPALA[head])
                        {
                            player2[posisiP2] = " ";
                            posisiP2 = EKOR[head] - 1;
                            player2[posisiP2] = karakterpemain[1];
                        }
                        else if (posisiP3 + 1 == KEPALA[head])
                        {
                            player3[posisiP3] = " ";
                            posisiP3 = EKOR[head] - 1;
                            player3[posisiP3] = karakterpemain[2];
                        }
                        else if (posisiP4 + 1 == KEPALA[head])
                        {
                            player4[posisiP4] = " ";
                            posisiP4 = EKOR[head] - 1;
                            player4[posisiP4] = karakterpemain[3];
                        }

                        // tangga
                        else if (posisiP1 + 1 == BAWAH[head])
                        {
                            player1[posisiP1] = " ";
                            posisiP1 = ATAS[head] - 1;
                            player1[posisiP1] = karakterpemain[0];
                        }
                        else if (posisiP2 + 1 == BAWAH[head])
                        {
                            player2[posisiP2] = " ";
                            posisiP2 = ATAS[head] - 1;
                            player2[posisiP2] = karakterpemain[1];
                        }
                        else if (posisiP3 + 1 == BAWAH[head])
                        {
                            player3[posisiP3] = " ";
                            posisiP3 = ATAS[head] - 1;
                            player3[posisiP3] = karakterpemain[2];
                        }
                        else if (posisiP4 + 1 == BAWAH[head])
                        {
                            player4[posisiP4] = " ";
                            posisiP4 = ATAS[head] - 1;
                            player4[posisiP4] = karakterpemain[3];
                        }
                    }

                    TabelUlerTangga(KEPALA, EKOR, ATAS, BAWAH);
                    Papan(posisiP1, posisiP2, posisiP3, posisiP4, KEPALA, EKOR, ATAS, BAWAH, player1, player2, player3, player4);
                    Dadu(dice);
                    var t = Task.Run(async delegate
                    {
                        await Task.Delay(500);
                        return 42;
                    });
                    t.Wait();

                }

                // salah satu pemain di kotak seratus (array kotak ke 99) menang berubah jadi true
                if (posisiP1 == 99 || posisiP2 == 99 || posisiP3 == 99 || posisiP4 == 99)
                {
                    menang = true;
                }
                else
                {

                    if (P == 0)
                    {
                        Console.WriteLine("Sekarang Giliran " + namapemain1[0]);
                    }
                    else if (P == 1)
                    {
                        Console.WriteLine("Sekarang Giliran " + namapemain1[1]);
                    }
                    else if (P == 2)
                    {
                        Console.WriteLine("Sekarang Giliran " + namapemain1[2]);
                    }
                    else if (P == 3)
                    {
                        Console.WriteLine("Sekarang Giliran " + namapemain1[3]);
                    }

                    // tampilan dadu
                    Console.WriteLine("Tekan Enter u/ KOCOK DADU");
                    Console.ReadKey();
                    Random rnd = new Random();
                    dice = rnd.Next(1, 7);
                    Dadu(dice);
                    P++;
                    Console.Clear();
                }
            }
            Console.Clear();





            // tampilan menang
            if (posisiP1 == 99)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                string garis = "============================================================================================";
                Console.SetCursorPosition((Console.WindowWidth - garis.Length) / 2, Console.CursorTop);
                Console.Write(garis);
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                string tampilanmenang = "Selamat ";
                Console.SetCursorPosition((Console.WindowWidth - tampilanmenang.Length) / 2, Console.CursorTop);
                Console.WriteLine(tampilanmenang + namapemain1[0]);
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                string garisbawah = "============================================================================================";
                Console.SetCursorPosition((Console.WindowWidth - garisbawah.Length) / 2, Console.CursorTop);
                Console.Write(garisbawah);
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (posisiP2 == 99)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                string garis = "============================================================================================";
                Console.SetCursorPosition((Console.WindowWidth - garis.Length) / 2, Console.CursorTop);
                Console.Write(garis);
                Console.ResetColor();
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Magenta;
                string tampilanmenang = "Selamat ";
                Console.SetCursorPosition((Console.WindowWidth - tampilanmenang.Length) / 2, Console.CursorTop);
                Console.WriteLine(tampilanmenang + namapemain1[1]);
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                string garisbawah = "============================================================================================";
                Console.SetCursorPosition((Console.WindowWidth - garisbawah.Length) / 2, Console.CursorTop);
                Console.Write(garisbawah);
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (posisiP3 == 99)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                string garis = "============================================================================================";
                Console.SetCursorPosition((Console.WindowWidth - garis.Length) / 2, Console.CursorTop);
                Console.Write(garis);
                Console.ResetColor();
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Magenta;
                string tampilanmenang = "Selamat ";
                Console.SetCursorPosition((Console.WindowWidth - tampilanmenang.Length) / 2, Console.CursorTop);
                Console.WriteLine(tampilanmenang + namapemain1[2]);
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                string garisbawah = "============================================================================================";
                Console.SetCursorPosition((Console.WindowWidth - garisbawah.Length) / 2, Console.CursorTop);
                Console.Write(garisbawah);
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (posisiP4 == 99)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                string garis = "============================================================================================";
                Console.SetCursorPosition((Console.WindowWidth - garis.Length) / 2, Console.CursorTop);
                Console.Write(garis);
                Console.ResetColor();
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Magenta;
                string tampilanmenang = "Selamat ";
                Console.SetCursorPosition((Console.WindowWidth - tampilanmenang.Length) / 2, Console.CursorTop);
                Console.WriteLine(tampilanmenang + namapemain1[3]);
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                string garisbawah = "============================================================================================";
                Console.SetCursorPosition((Console.WindowWidth - garisbawah.Length) / 2, Console.CursorTop);
                Console.Write(garisbawah);
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();

            }
        }
        public static void TabelUlerTangga(int[] KEPALA, int[] EKOR, int[] ATAS, int[] BAWAH)
        {
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            Console.Write("╔");
                        }
                        else if (j == 19)
                        {
                            Console.Write("╦");
                        }
                        else if (j == 39)
                        {
                            Console.WriteLine("╗");
                        }
                        else
                        {
                            Console.Write("═");
                        }
                    }
                    else if (i == 1)
                    {
                        if (j == 0 || j == 16 || j == 31)
                        {
                            Console.Write("║");
                            if (j == 31)
                            {
                                Console.WriteLine();
                            }
                        }
                        else if (j == 8)
                        {
                            Console.Write("ULAR");
                        }
                        else if (j == 24)
                        {
                            Console.Write("TANGGA");
                        }
                        else if (j < 31 && j != 0 && j != 16 && j != 8 && j != 24)
                        {
                            Console.Write(" ");
                        }
                    }
                    else if (i == 2)
                    {
                        if (j == 0)
                        {
                            Console.Write("╠");
                        }
                        else if (j == 19)
                        {
                            Console.Write("╬");
                        }
                        else if (j == 39)
                        {
                            Console.WriteLine("╣");
                        }
                        else if (j == 10 || j == 30)
                        {
                            Console.Write("╦");
                        }
                        else
                        {
                            Console.Write("═");
                        }
                    }
                    else if (i == 3)
                    {
                        if (j == 0 || j == 5 || j == 11 || j == 19 || j == 24)
                        {
                            Console.Write("║");
                            if (j == 24)
                            {
                                Console.WriteLine();
                            }
                        }
                        else if (j == 3)
                        {
                            Console.Write("Kepala");
                        }
                        else if (j == 8)
                        {
                            Console.Write("Ekor");
                        }
                        else if (j == 15)
                        {
                            Console.Write("Atas");
                        }
                        else if (j == 21)
                        {
                            Console.Write("Bawah");
                        }
                        else if (j < 24 && j != 0 && j != 5 && j != 11 && j != 19 && j != 3 && j != 8 && j != 15 && j != 21)
                        {
                            Console.Write(" ");
                        }
                    }
                    else if (i == 4)
                    {
                        if (j == 0)
                        {
                            Console.Write("╠");
                        }
                        else if (j == 19 || j == 10 || j == 30)
                        {
                            Console.Write("╬");
                        }
                        else if (j == 39)
                        {
                            Console.WriteLine("╣");
                        }
                        else
                        {
                            Console.Write("═");
                        }
                    }
                    else if (i < 10 && i > 4)
                    {
                        if (j == 0 || j == 9 || j == 17 || j == 27 || j == 35)
                        {
                            Console.Write("║");
                            if (j == 35)
                            {
                                Console.WriteLine();
                            }
                        }
                        else if (j == 4 || j == 13 || j == 22 || j == 31)
                        {
                            if (j == 4)
                            {
                                i = i - 4;
                                if (KEPALA[i] > 9)
                                {
                                    Console.Write(KEPALA[i]);
                                }
                                else if (KEPALA[i] < 10)
                                {
                                    Console.Write(" " + KEPALA[i]);
                                }
                                i = i + 4;
                            }
                            else if (j == 13)
                            {
                                i = i - 4;
                                if (EKOR[i] > 9)
                                {
                                    Console.Write(EKOR[i]);
                                }
                                else if (EKOR[i] < 10)
                                {
                                    Console.Write(EKOR[i] + " ");
                                }
                                i = i + 4;
                            }
                            else if (j == 22)
                            {
                                i = i - 4;
                                if (ATAS[i] > 9)
                                {
                                    Console.Write(ATAS[i]);
                                }
                                else if (ATAS[i] < 10)
                                {
                                    Console.Write(ATAS[i] + " ");
                                }
                                i = i + 4;
                            }
                            else if (j == 31)
                            {
                                i = i - 4;
                                if (BAWAH[i] > 9)
                                {
                                    Console.Write(BAWAH[i]);
                                }
                                else if (BAWAH[i] < 10)
                                {
                                    Console.Write(BAWAH[i] + " ");
                                }
                                i = i + 4;
                            }
                        }
                        else if (j < 35 && j != 0 && j != 9 && j != 17 && j != 27)
                        {
                            Console.Write(" ");
                        }
                    }
                    else if (i == 10)
                    {
                        if (j == 0)
                        {
                            Console.Write("╚");
                        }
                        else if (j == 19 || j == 10 || j == 30)
                        {
                            Console.Write("╩");
                        }
                        else if (j == 39)
                        {
                            Console.WriteLine("╝");
                        }
                        else
                        {
                            Console.Write("═");
                        }
                    }
                }
            } // tampilan tabel
        }
        public static void Papan(int posisiP1, int posisiP2, int posisiP3, int posisiP4, int[] KEPALA, int[] EKOR, int[] ATAS, int[] BAWAH, string[] player1, string[] player2, string[] player3, string[] player4)
        {

            int nomorkotak = 100;
            for (int m = 0; m < 10; m++) // 10x kebawah
            {
                if (m % 2 == 0 && m != 0)
                {
                    nomorkotak -= 1;
                }
                else if (m % 2 != 0 && m != 0)
                {
                    nomorkotak -= 19; // untuk kotak di baris berikutnya agar mempunyai angka yang berbeda
                }
                for (int k = 0; k < 4; k++) // 4x kebawah
                {
                    for (int j = 0; j < 10; j++) // 10x ke kanan
                    {
                        if (k == 0)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                if (nomorkotak == KEPALA[1] || nomorkotak == KEPALA[2] || nomorkotak == KEPALA[3] || nomorkotak == KEPALA[4] || nomorkotak == KEPALA[5])
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    if (i == 0)
                                    {
                                        Console.Write("╔═");
                                    }
                                    else
                                    {
                                        Console.Write("══");
                                    }
                                    Console.ResetColor();
                                }
                                else if (nomorkotak == ATAS[1] || nomorkotak == ATAS[2] || nomorkotak == ATAS[3] || nomorkotak == ATAS[4] || nomorkotak == ATAS[5])
                                {
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    if (i == 0)
                                    {
                                        Console.Write("╔═");
                                    }
                                    else
                                    {
                                        Console.Write("══");
                                    }
                                    Console.ResetColor();
                                }
                                else if (nomorkotak == EKOR[1] || nomorkotak == EKOR[2] || nomorkotak == EKOR[3] || nomorkotak == EKOR[4] || nomorkotak == EKOR[5])
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                    if (i == 0)
                                    {
                                        Console.Write("╔═");
                                    }
                                    else
                                    {
                                        Console.Write("══");
                                    }
                                    Console.ResetColor();
                                }
                                else if (nomorkotak == BAWAH[1] || nomorkotak == BAWAH[2] || nomorkotak == BAWAH[3] || nomorkotak == BAWAH[4] || nomorkotak == BAWAH[5])
                                {
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    if (i == 0)
                                    {
                                        Console.Write("╔═");
                                    }
                                    else
                                    {
                                        Console.Write("══");
                                    }
                                    Console.ResetColor();
                                }
                                else
                                {
                                    if (i == 0)
                                    {
                                        Console.Write("╔═");
                                    }
                                    else
                                    {
                                        Console.Write("══");
                                    }
                                }
                            }
                            if (nomorkotak == 100)
                            {
                                Console.Write(nomorkotak + " ");
                            }
                            else if (nomorkotak < 10)
                            {
                                Console.Write(nomorkotak + "   ");
                            }
                            else
                            {
                                Console.Write(nomorkotak + "  ");
                            }

                        }
                        else if (k == 1)
                        {
                            if (nomorkotak == KEPALA[1] || nomorkotak == KEPALA[2] || nomorkotak == KEPALA[3] || nomorkotak == KEPALA[4] || nomorkotak == KEPALA[5])
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Write("║ ");
                                Console.ResetColor();
                            }
                            else if (nomorkotak == ATAS[1] || nomorkotak == ATAS[2] || nomorkotak == ATAS[3] || nomorkotak == ATAS[4] || nomorkotak == ATAS[5])
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.Write("║ ");
                                Console.ResetColor();
                            }
                            else if (nomorkotak == EKOR[1] || nomorkotak == EKOR[2] || nomorkotak == EKOR[3] || nomorkotak == EKOR[4] || nomorkotak == EKOR[5])
                            {
                                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                Console.Write("║ ");
                                Console.ResetColor();
                            }
                            else if (nomorkotak == BAWAH[1] || nomorkotak == BAWAH[2] || nomorkotak == BAWAH[3] || nomorkotak == BAWAH[4] || nomorkotak == BAWAH[5])
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Write("║ ");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write("║ ");
                            }
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(player1[nomorkotak - 1] + " ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(player2[nomorkotak - 1] + " ");
                            Console.ResetColor();
                            if (nomorkotak == KEPALA[1] || nomorkotak == KEPALA[2] || nomorkotak == KEPALA[3] || nomorkotak == KEPALA[4] || nomorkotak == KEPALA[5])
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Write("║ ");
                                Console.ResetColor();
                            }
                            else if (nomorkotak == ATAS[1] || nomorkotak == ATAS[2] || nomorkotak == ATAS[3] || nomorkotak == ATAS[4] || nomorkotak == ATAS[5])
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.Write("║ ");
                                Console.ResetColor();
                            }
                            else if (nomorkotak == EKOR[1] || nomorkotak == EKOR[2] || nomorkotak == EKOR[3] || nomorkotak == EKOR[4] || nomorkotak == EKOR[5])
                            {
                                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                Console.Write("║ ");
                                Console.ResetColor();
                            }
                            else if (nomorkotak == BAWAH[1] || nomorkotak == BAWAH[2] || nomorkotak == BAWAH[3] || nomorkotak == BAWAH[4] || nomorkotak == BAWAH[5])
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Write("║ ");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write("║ ");
                            }
                            Console.Write("  ");

                        }
                        else if (k == 2)
                        {
                            if (nomorkotak == KEPALA[1] || nomorkotak == KEPALA[2] || nomorkotak == KEPALA[3] || nomorkotak == KEPALA[4] || nomorkotak == KEPALA[5])
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Write("║ ");
                                Console.ResetColor();
                            }
                            else if (nomorkotak == ATAS[1] || nomorkotak == ATAS[2] || nomorkotak == ATAS[3] || nomorkotak == ATAS[4] || nomorkotak == ATAS[5])
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.Write("║ ");
                                Console.ResetColor();
                            }
                            else if (nomorkotak == EKOR[1] || nomorkotak == EKOR[2] || nomorkotak == EKOR[3] || nomorkotak == EKOR[4] || nomorkotak == EKOR[5])
                            {
                                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                Console.Write("║ ");
                                Console.ResetColor();
                            }
                            else if (nomorkotak == BAWAH[1] || nomorkotak == BAWAH[2] || nomorkotak == BAWAH[3] || nomorkotak == BAWAH[4] || nomorkotak == BAWAH[5])
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Write("║ ");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write("║ ");
                            }
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(player3[nomorkotak - 1] + " ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(player4[nomorkotak - 1] + " ");
                            Console.ResetColor();
                            if (nomorkotak == KEPALA[1] || nomorkotak == KEPALA[2] || nomorkotak == KEPALA[3] || nomorkotak == KEPALA[4] || nomorkotak == KEPALA[5])
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Write("║ ");
                                Console.ResetColor();
                            }
                            else if (nomorkotak == ATAS[1] || nomorkotak == ATAS[2] || nomorkotak == ATAS[3] || nomorkotak == ATAS[4] || nomorkotak == ATAS[5])
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.Write("║ ");
                                Console.ResetColor();
                            }
                            else if (nomorkotak == EKOR[1] || nomorkotak == EKOR[2] || nomorkotak == EKOR[3] || nomorkotak == EKOR[4] || nomorkotak == EKOR[5])
                            {
                                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                Console.Write("║ ");
                                Console.ResetColor();
                            }
                            else if (nomorkotak == BAWAH[1] || nomorkotak == BAWAH[2] || nomorkotak == BAWAH[3] || nomorkotak == BAWAH[4] || nomorkotak == BAWAH[5])
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Write("║ ");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write("║ ");
                            }
                            Console.Write("  ");

                        }
                        else
                        {
                            for (int l = 0; l < 4; l++)
                            {
                                if (nomorkotak == KEPALA[1] || nomorkotak == KEPALA[2] || nomorkotak == KEPALA[3] || nomorkotak == KEPALA[4] || nomorkotak == KEPALA[5])
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    if (l == 0)
                                    {
                                        Console.Write("╚═");
                                    }
                                    if (l == 3)
                                    {
                                        Console.Write("═╝ ");
                                    }
                                    else
                                    {
                                        Console.Write("═");
                                    }
                                    Console.ResetColor();
                                }
                                else if (nomorkotak == ATAS[1] || nomorkotak == ATAS[2] || nomorkotak == ATAS[3] || nomorkotak == ATAS[4] || nomorkotak == ATAS[5])
                                {
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    if (l == 0)
                                    {
                                        Console.Write("╚═");
                                    }
                                    if (l == 3)
                                    {
                                        Console.Write("═╝ ");
                                    }
                                    else
                                    {
                                        Console.Write("═");
                                    }
                                    Console.ResetColor();
                                }
                                else if (nomorkotak == EKOR[1] || nomorkotak == EKOR[2] || nomorkotak == EKOR[3] || nomorkotak == EKOR[4] || nomorkotak == EKOR[5])
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                    if (l == 0)
                                    {
                                        Console.Write("╚═");
                                    }
                                    if (l == 3)
                                    {
                                        Console.Write("═╝ ");
                                    }
                                    else
                                    {
                                        Console.Write("═");
                                    }
                                    Console.ResetColor();
                                }
                                else if (nomorkotak == BAWAH[1] || nomorkotak == BAWAH[2] || nomorkotak == BAWAH[3] || nomorkotak == BAWAH[4] || nomorkotak == BAWAH[5])
                                {
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    if (l == 0)
                                    {
                                        Console.Write("╚═");
                                    }
                                    if (l == 3)
                                    {
                                        Console.Write("═╝ ");
                                    }
                                    else
                                    {
                                        Console.Write("═");
                                    }
                                    Console.ResetColor();
                                }
                                else
                                {
                                    if (l == 0)
                                    {
                                        Console.Write("╚═");
                                    }
                                    if (l == 3)
                                    {
                                        Console.Write("═╝ ");
                                    }
                                    else
                                    {
                                        Console.Write("═");
                                    }
                                }
                            }

                            Console.Write("  ");

                        }

                        if (m % 2 == 0)
                        {
                            nomorkotak--;
                        }
                        else
                        {
                            nomorkotak++;
                        }

                    }
                    if (m % 2 == 0)
                    {
                        nomorkotak += 10;
                    }
                    else
                    {
                        nomorkotak -= 10; // untuk bintang di dalam kotak berada di array yang sama
                    }

                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        public static void Dadu(int dice)
        {
            for (int i = 0; i < 8; i++) // kebawah
            {
                for (int j = 0; j < 11; j++) // ke kanan
                {
                    if (dice == 1)
                    {
                        if (i == 2 || i == 5) // kebawah
                        {
                            if (j == 3 || j == 7)
                            {
                                Console.Write("┼");
                            }
                            else
                            {
                                Console.Write("─");
                            }

                        }
                        else if (j == 3 || j == 7)
                        {
                            Console.Write("│"); // ke kanan
                        }
                        else if (j == 1 || j == 5 || j == 9)
                        {
                            Console.Write(" ");
                        }
                        else if (i > 2 && i < 5 && j > 3 && j < 7)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("■");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else if (dice == 2)
                    {
                        if (i == 2 || i == 5) // kebawah
                        {
                            if (j == 3 || j == 7)
                            {
                                Console.Write("┼");
                            }
                            else
                            {
                                Console.Write("─");
                            }

                        }
                        else if (j == 3 || j == 7)
                        {
                            Console.Write("│"); // ke kanan
                        }
                        else if (j == 1 || j == 5 || j == 9)
                        {
                            Console.Write(" ");
                        }
                        else if (i > 2 && i < 5 && j < 3 || i > 2 && i < 5 && j > 7)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("■");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else if (dice == 3)
                    {
                        if (i == 2 || i == 5) // kebawah
                        {
                            if (j == 3 || j == 7)
                            {
                                Console.Write("┼");
                            }
                            else
                            {
                                Console.Write("─");
                            }

                        }
                        else if (j == 3 || j == 7)
                        {
                            Console.Write("│"); // ke kanan
                        }
                        else if (j == 1 || j == 5 || j == 9)
                        {
                            Console.Write(" ");
                        }
                        else if (i > 2 && i < 5 && j > 3 && j < 7 || i < 2 && j > 7 || i > 5 && j < 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("■");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else if (dice == 4)
                    {
                        if (i == 2 || i == 5) // kebawah
                        {
                            if (j == 3 || j == 7)
                            {
                                Console.Write("┼");
                            }
                            else
                            {
                                Console.Write("─");
                            }

                        }
                        else if (j == 3 || j == 7)
                        {
                            Console.Write("│"); // ke kanan
                        }
                        else if (j == 1 || j == 5 || j == 9)
                        {
                            Console.Write(" ");
                        }
                        else if (i < 2 && j < 3 || i < 2 && j > 7 || i > 5 && j < 3 || i > 5 && j > 7)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("■");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else if (dice == 5)
                    {
                        if (i == 2 || i == 5) // kebawah
                        {
                            if (j == 3 || j == 7)
                            {
                                Console.Write("┼");
                            }
                            else
                            {
                                Console.Write("─");
                            }

                        }
                        else if (j == 3 || j == 7)
                        {
                            Console.Write("│"); // ke kanan
                        }
                        else if (j == 1 || j == 5 || j == 9)
                        {
                            Console.Write(" ");
                        }
                        else if (i < 2 && j < 3 || i < 2 && j > 7 || i > 5 && j < 3 || i > 5 && j > 7 || i > 2 && i < 5 && j > 3 && j < 7)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("■");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else if (dice == 6)
                    {

                        if (i == 2 || i == 5) // kebawah
                        {
                            if (j == 3 || j == 7)
                            {
                                Console.Write("┼");
                            }
                            else
                            {
                                Console.Write("─");
                            }

                        }
                        else if (j == 3 || j == 7)
                        {
                            Console.Write("│"); // ke kanan
                        }
                        else if (j == 1 || j == 5 || j == 9)
                        {
                            Console.Write(" ");
                        }
                        else if (i > 2 && i < 5 && j < 3 || i > 2 && i < 5 && j > 7 || i < 2 && j < 3 || i < 2 && j > 7 || i > 5 && j < 3 || i > 5 && j > 7)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("■");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(" ");
                        }

                    }

                }
                Console.WriteLine();
            }
        }
        public static void JUDUL()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            string judul = "Uler Tangga";
            Console.SetCursorPosition((Console.WindowWidth - judul.Length) / 2, Console.CursorTop);
            Console.WriteLine(judul);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            string garis = "============================================================================================";
            Console.SetCursorPosition((Console.WindowWidth - garis.Length) / 2, Console.CursorTop);
            Console.Write(garis);
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
