// See https://aka.ms/new-console-template for more information

namespace modul3_1302204051
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.NamaBuah.Apel) + "\n");

            PosisiKarakterGame posisiKarakter = new PosisiKarakterGame();
            Console.WriteLine("Posisi saat ini : " + posisiKarakter.CurrentState);

            posisiKarakter.activateTrigger(PosisiKarakterGame.Trigger.TombolS);
            Console.WriteLine("Posisi saat ini : " + posisiKarakter.CurrentState);

            posisiKarakter.activateTrigger(PosisiKarakterGame.Trigger.TombolW);
            Console.WriteLine("Posisi saat ini : " + posisiKarakter.CurrentState);

            posisiKarakter.activateTrigger(PosisiKarakterGame.Trigger.TombolW);
            Console.WriteLine("Posisi saat ini : " + posisiKarakter.CurrentState);

            posisiKarakter.activateTrigger(PosisiKarakterGame.Trigger.TombolX);
            Console.WriteLine("Posisi saat ini : " + posisiKarakter.CurrentState);

            posisiKarakter.activateTrigger(PosisiKarakterGame.Trigger.TombolS);
            Console.WriteLine("Posisi saat ini : " + posisiKarakter.CurrentState);
        }
    }
}