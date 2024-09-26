class program
{
    static void Main(string[] args)
    {
        KebunBinatang kebunBinatang = new KebunBinatang();

        Hewan singa = new Singa
        {
            Nama = "Singa",
            Umur = 4,
            JumlahKaki = 4,
        };
        Hewan gajah = new Gajah
        {
            Nama = "Gajah",
            Umur = 3,
            JumlahKaki = 4,
        };
        Hewan ular = new Ular
        {
            Nama = "Ular",
            Umur = 3,
            panjangTubuh = 20,
        };
        Hewan buaya = new Buaya
        {
            Nama = "Buaya",
            Umur = 5,
            panjangTubuh = 100,
        };


        //kebunBinatang.TambahHewan(singa);
        //kebunBinatang.TambahHewan(gajah);
        //kebunBinatang.TambahHewan(ular);
        //kebunBinatang.TambahHewan(buaya);

        //kebunBinatang.DaftarHewan();

        //((Singa)singa).Mengaum();
        //((Ular)ular).Merayap();

        //Console.WriteLine(gajah.Suara());
        //Console.WriteLine(ular.Suara());

        //((Singa)singa).infosinga();

        //Reptil reptil = new Buaya();
        //Console.WriteLine(reptil.Suara());

    }
}
public class Hewan
{
    public string Nama;
    public int Umur;

    public virtual string Suara()
    {
        return "Hewan ini Bersuara";
    }
    public virtual string infoHewan()
    {
        return $"Nama: {Nama}\nUmur: {Umur}\n{Suara()}";
    }
}

public class Mamalia : Hewan
{
    public int JumlahKaki;
    public override string Suara()
    {
        return "Hewan ini Bersuara";
    }
    public override string infoHewan()
    {
        return base.infoHewan() + $"\nJumlah Kaki: {JumlahKaki}\n";
    }
}

public class Reptil : Hewan
{
    public int panjangTubuh;
    public override string Suara()
    {
        return "Hewan ini Bersuara";
    }
    public override string infoHewan()
    {
        return base.infoHewan() + $"\nPanjang Tubuh: {panjangTubuh} cm\n";
    }
}

public class Singa : Mamalia
{
    public void infosinga()
    {
        Console.WriteLine($"Nama: {Nama}\nUmur: {Umur}\nJumlah Kaki: {JumlahKaki}");
    }
    public void Mengaum()
    {
        Console.WriteLine("Rawrrrrr");
    }
    public override string Suara()
    {
        return $"Hewan {Nama}ini Bersuara";
    }

}

public class Gajah : Mamalia
{
    public override string Suara()
    {
        return $"Hewan {Nama} ini Bersuara";
    }
}
public class Ular : Reptil
{
    public void Merayap()
    {
        Console.WriteLine("Ular merayap");
    }
    public override string Suara()
    {
        return $"Hewan {Nama} ini Bersuara";
    }
}
public class Buaya : Reptil
{
    public override string Suara()
    {
        return $"Hewan {Nama} ini Bersuara";
    }
}

public class KebunBinatang
{
    public List<Hewan> KoleksiHewan = new List<Hewan>();
    public void TambahHewan(Hewan hewan)
    {
        KoleksiHewan.Add(hewan);
    }
    public void DaftarHewan()
    {
        foreach (var hewan in KoleksiHewan)
        {
            Console.WriteLine(hewan.infoHewan());
        }
    }
}
