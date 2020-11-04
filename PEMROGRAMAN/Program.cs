using System;

namespace tugas
{
    class Program
    {
        static void Main(string[] args)
        {
           Monokotil kelapa = new Monokotil("Jagung",1);
           kelapa.Ciri();
        }
    }
    class Tumbuhan
    {
        public int keping;
        
        public Tumbuhan(){
           
        }
        public void berbuahk(){
            Console.WriteLine("Matang");
        }

    }
    class Monokotil:Tumbuhan{
        public string nama;
        public Monokotil(string nama_tumbhn, int jmlh_keping ){
            nama = nama_tumbhn;
            keping = jmlh_keping;
            
        }
        public void Ciri(){
            Console.WriteLine("Jumlah keping: " + keping +" nama: " + nama );
        }
    }
}
