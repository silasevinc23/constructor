// See https://aka.ms/new-console-template for more information
using System.Reflection;



//Bu örnekte sizlerden bir Bebek sınıfı tanımlamanız isteniyor.

//Bebek sınıfının propertyleri -> Doğum Tarihi , Ad, Soyad 

//Bebek sınıfı için 2 adet constructor tanımlayınız.

//1.si Default Constructor tarzında parametre almayan bir metot.

//2.si Ad ve Soyad parametrelerini alarak newleme işlemi sırasında değerleri propertylere atayan alternatif constructor.

//2 Constructor içinde ortak olarak bebek nesnesi oluşturulduğunda konsol ekranında bir " Ingaaaa " yazısı görülsün ve Doğum Tarihi o an olarak atansın.

//Tanımlama sonrasında her iki constructor ile de birer bebek nesnesi tanımlayarak özelliklerini konsol ekranına yazdırınız

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

