// See https://aka.ms/new-console-template for more information

Ogrenci ogrenci1 = new Ogrenci();
ogrenci1.Name = "Alp";
ogrenci1.Surname = "Dereli";
ogrenci1.Ogrencino = 442;
ogrenci1.Sinif = 11;
ogrenci1.ogrencibilgi();
ogrenci1.sinifatlat();
ogrenci1.ogrencibilgi();

Ogrenci ogrenci2 = new Ogrenci();
ogrenci2.Name = "Ysusd";
ogrenci2.Surname = "Coban";
ogrenci2.Ogrencino = 12;
ogrenci2.Sinif = 1;
ogrenci2.sinifdus();
ogrenci2.ogrencibilgi();

class Ogrenci
{
    private string _name;
    private string _surname;
    private int ogrencino;
    private int sinif;

    public string Name { get => _name; set => _name = value; }
    public string Surname { get => _surname; set => _surname = value; }
    public int Ogrencino { get => ogrencino; set => ogrencino = value; }
    public int Sinif { get => sinif;
        set 
        { 
            if (value<1)
            {
                Console.WriteLine("Sinif en az 1 olabilir");
                value = 1;
            }
            else
            {
                sinif = value;
            } 
        }
    }

    public Ogrenci() { }

    public Ogrenci(string name, string surname, int ogrencino, int sinif)
    {
        Name = name;
        Surname = surname;
        Ogrencino = ogrencino;
        Sinif = sinif;
    }

    public void ogrencibilgi()
    {
        Console.WriteLine("Adi: " + Name);
        Console.WriteLine("Soyadi: " + Surname);
        Console.WriteLine("Ogr no: " +  Ogrencino);
        Console.WriteLine("Sinif: " +  sinif);
    }

    public void sinifatlat()
    {
        Sinif++;
    }

    public void sinifdus()
    {
        Sinif-=1;
    }
}