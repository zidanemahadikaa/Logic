using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_329
{
    internal class Day_05
    {
        public void AbstrakVirtual()
        {
            int nilai1 = 10, nilai2 = 11;
            turunanKalkulatorAbstrak kalkulatorAbstrak = new turunanKalkulatorAbstrak();

            Console.WriteLine("Abstract Class");
            Console.WriteLine("================");
            Console.WriteLine($"{nilai1} + {nilai2} = {kalkulatorAbstrak.jumlah(nilai1, nilai2)}");
            Console.WriteLine($"{nilai1} + {nilai2} = {kalkulatorAbstrak.kurang(nilai1, nilai2)}");

            Console.WriteLine();

            KalkulatorVirtual kalkulatorVirtual = new KalkulatorVirtual();
            TurunanKalkulatorVirtual turunanKalkulatorVirtual = new TurunanKalkulatorVirtual();
            nilai1 = 100; nilai2 = 200;
            Console.WriteLine("Kalkulator Virtual ");
            Console.WriteLine("================");
            Console.WriteLine("[Parent]");
            Console.WriteLine($"{nilai1} + {nilai2} = {kalkulatorAbstrak.jumlah(nilai1, nilai2)}");
            Console.WriteLine($"{nilai1} + {nilai2} = {kalkulatorAbstrak.kurang(nilai1, nilai2)}");
            Console.WriteLine("[Child]");
            Console.WriteLine($"2x{nilai1} + 2yx{nilai2} = {turunanKalkulatorVirtual.jumlah(nilai1, nilai2)}");
            Console.WriteLine($"8x{nilai1} - 6x{nilai2} = {turunanKalkulatorVirtual.kurang(nilai1, nilai2)}");

            Console.WriteLine();
            Console.WriteLine("Objek Mobil");
            Console.WriteLine("============");
            Mobil mobilbaru = new Mobil("B1234NO");
            Console.WriteLine("NO Plat: {0}", mobilbaru.GetPlatNo());

            //set kecepatan mobil
            mobilbaru.SetKecepatan(30);
            Console.WriteLine("Kecepatan (Km/J): {0}", mobilbaru.GetKecepatan());
            Console.WriteLine("Kecepatan (Mil/J): {0:N4}", mobilbaru.GetKecepatanMillPerJam().ToString("N2"));

            Console.WriteLine();
            Console.WriteLine("Objek Mobil Bak");
            Console.WriteLine("============");
            MobilBak mobilBakBaru = new MobilBak("B5678MO", 1000);
            //ssss
            mobilBakBaru.SetKecepatan(30.12345);
            Console.WriteLine("NO Plat: {0}", mobilBakBaru.GetPlatNo());
            Console.WriteLine("Kecepatan (Km/J): {0}", mobilBakBaru.GetKecepatan());
            Console.WriteLine("Kecepatan (Mil/J): {0:N4}", mobilBakBaru.GetKecepatanMillPerJam().ToString("N2"));
            //Console.WriteLine("Ukuran Bak Mobil baru: {0} cm3}", mobilBakBaru.GetUkuranBak());

            //Polymorphism
            PolyMorphism polymorphism = new PolyMorphism();
            Console.WriteLine("Keliling Persegi (2cm): {0} cm", polymorphism.Keliling(2));
            Console.WriteLine("Keliling Persegi Panjang (2cm x 4 cm): {0} cm", polymorphism.Keliling(2,2));
            Console.WriteLine("Keliling Lingkaran (2cm x pi x 3cm): {0} cm", polymorphism.Keliling(22/7.0, 3));

            //Inheritance
            Console.WriteLine();
            Console.WriteLine("Inheritance & Overriding");
            Console.WriteLine("=========================");
            Mamalia mamalia = new Mamalia();
            Console.Write("Mamalia ");
            mamalia.Berpindah();

            Kucing kucing = new Kucing();
            Console.Write("Kucing ");
            kucing.Berpindah();

            Paus paus = new Paus();
            Console.Write("Paus ");
            paus.Berpindah();

            Kelelawar kelelawar = new Kelelawar();
            Console.Write("Kelelawar ");
            kelelawar.Berpindah();
        }
    }
    internal abstract class KalkulatorAbstrak
    {
        public abstract int jumlah(int x, int y);
        public abstract int kurang(int x, int y);
    }
    internal class turunanKalkulatorAbstrak : KalkulatorAbstrak
    {
        public override int jumlah(int x, int y) { 
            return x + y; }
        public override int kurang(int x, int y) => x - y;
    }
    internal class KalkulatorVirtual
    {
        public virtual int jumlah(int x, int y) 
        { 
            return x + y;
        }
        public virtual int kurang(int x, int y) => x - y;
    }
    internal class TurunanKalkulatorVirtual : KalkulatorVirtual
    {
        public override int jumlah(int x, int y) => 2 * x + 2 * y;
        public override int kurang(int x, int y) => 8 * x - 6 * y;
    }
    public class Mobil
    {
        private double kecepatan;
        private double bensin;
        private double posisi;
        public string nama;
        private string platno;

        //Class constractor
        public Mobil(string _platno)
        {
            platno = _platno;
        }
        public string GetPlatNo()
        {
            return platno.Substring(0,1) + " " + platno.Substring(1);
        }
        public string GetNama()
        {
            return nama;
        }
        public double GetKecepatan() => kecepatan;
        public double GetKecepatanMillPerJam()
        {
            return kecepatan / 1.609344;
        }
        public double GetBensin() => bensin;
        public double GetPosisi() => posisi;
        public void SetKecepatan(double _kecepatan)
        {
            kecepatan = _kecepatan;
        }
        public void SetPlatNo(string _platno)
        {
            platno = _platno;
        }
    }
    public class MobilBak : Mobil
    {
        private int ukuranBak;
        public MobilBak (string _platno, int _ukuranBak) : base  (_platno)
        {
            ukuranBak = _ukuranBak;
        }
        public void SetUkuranBak(int _ukuranBak)
        {
            ukuranBak = _ukuranBak;
        }
        public int GetUkuranBak()
        {
            return ukuranBak;
        }
    }
    public class PolyMorphism
    {
        public double Keliling(double s)
        {
            return 4 * s;
        }
        public double Keliling(double p, double l)
        {
            return 2 * (p * l);
        }
        public double Keliling(double pi, double r, int konstan = 2)
        {
            return konstan * pi * r;
        }
    }
    public class Mamalia
    {
        public virtual void Berpindah()
        {
            Console.WriteLine("Berlari....");
        }
    }
    public class Kucing : Mamalia
    {
    }
    public class Paus : Mamalia
    {
        public override void Berpindah()
        {
            Console.WriteLine("Berenang ...");
        }
    }
    public class Kelelawar : Mamalia
    {
        public override void Berpindah()
        {
            Console.WriteLine("Terbang...");
        }
    }
}
