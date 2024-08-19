class Bebek
{
    string _ad;
    string _soyad;
    DateTime _dogum_tarihi;

    public string Ad 
    {
        get { return _ad; } 
        set { _ad = value; }
    }

    public string Soyad
    {
        get { return _soyad; }
        set { _soyad = value; }
    }

    public DateTime Dogum_Tarihi
    {
        get { return _dogum_tarihi; }
        set { _dogum_tarihi = value; }
    }

    //Constructors
    public Bebek() //Default constructor
    {
        Console.WriteLine("Ingaaaa");
        _dogum_tarihi = DateTime.Now;
    } 
    public Bebek(string ad, string soyad)
    {
        Console.WriteLine("Ingaaaa");
        _ad = ad;
        _soyad = soyad;
        _dogum_tarihi = DateTime.Now;
    }

    static void Main(string[] args)
    {   Bebek bebek2 = new Bebek();
        Console.WriteLine("Bebek Adı :"+ bebek2._ad+" Soyadı :" + bebek2._soyad +" Doğum Tarihi :"+ bebek2._dogum_tarihi);


        Bebek bebek1 = new Bebek("Ali","Kaya");
        Console.WriteLine("Bebek Adı :"+bebek1._ad+" Soyadı :" + bebek1._soyad +" Doğum Tarihi :"+ bebek1._dogum_tarihi);

        
    }

}

