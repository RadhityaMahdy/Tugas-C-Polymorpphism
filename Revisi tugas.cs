using System;

public class HelloWorld
{
    static public void Main()
    {
        familyhobi ak = new familyhobi();
        familyhobi ayah = new Ayah();
        familyhobi ibu = new Ibu();
        familyhobi anak = new Anak();
        familyhobi adik = new adik();

        familydata ayahku = new familydata("i.sanjaya akadian", 43, +6280937687285);
        familydata ibuku = new familydata("khoiriyah nur az.", 40, +6207946793874);
        familydata aku = new familydata("Radhitya Mahdy Ubaidillah", 15, +6285816362432);
        familydata adiku = new familydata("Alena humaira", 7, +62576989868679576);
        Console.WriteLine("data ayah:\n" + ayahku.nama + "\n" + ayahku.umur + "\n" + ayahku.nohp);
        ayah.Hobi();
        Console.WriteLine("data ibu:\n" + ibuku.nama + "\n" + ibuku.umur + "\n" + ibuku.nohp);
        ibu.Hobi();
        Console.WriteLine("data anak:\n" + aku.nama + "\n" + aku.umur + "\n" + aku.nohp);
        anak.Hobi();
        Console.WriteLine("data adik:\n" + adiku.nama + "\n" + adiku.umur + "\n" + adiku.nohp);
        adik.Hobi();



    }
    class familydata
    {
        public string nama;
        public int umur;
        public long nohp;

        public familydata(string Nama, int Umur, long Nohp)
        {
            nama = Nama;
            umur = Umur;
            nohp = Nohp;
        }



    }
    class familyhobi
    {
        public virtual void Hobi()
        {
            Console.WriteLine("Hobi");
        }
    }
    class Ayah : familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("bercocok tanam");
        }
    }
    class Ibu : familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("menjahit");
        }
    }
    class Anak : familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("menikmati keindahan alam dan membaca buku");
        }
    }

    class adik : familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("bermain");
        }
    }


}