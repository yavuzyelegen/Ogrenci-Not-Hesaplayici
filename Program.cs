//ogrenci adlari
string[] ogrAdlari =  ["yavuz","ahmet","fatma","sibel"];
//sinav sayisi
int sinavSayisi = 5;
//ilk 5 not sinav notu, sonrakiler odevlerin notlari katsayilari %10.
int[] yavuzNotlari =  {100,81,90,90,80,100,50};
int[] ahmetNotlari =  {100,30,60,70,80,80};
int[] fatmaNotlari =  {99,100,20,100,95,96};
int[] sibelNotlari =  {20,10,60,70,70,100,100};
//dongu icinde farkli ogrencilerin notlarını tutacak
int [] ogrNotlari = new int [10];
//harf notu
string harfNotu = " ";
//tablonun basliklari
Console.WriteLine("Ogrenci\tSinav\tEk puan\tSonuc\tHarf notu");

foreach(string isim in ogrAdlari)
{
    //ekrana basmak icin ogr adi degiskene alindi.
    string seciliOgr = isim;
    //dongu hangi ogrencideyse onun not dizisi "ogrNotlari"na alindi.
    if(seciliOgr=="yavuz")
    {
        ogrNotlari = yavuzNotlari;
    }
    else if(seciliOgr=="hamza")
    {
        ogrNotlari = ahmetNotlari;
    }
    else if (seciliOgr=="ahmet")
    {
        ogrNotlari = fatmaNotlari;
    }
    else if (seciliOgr=="sibel")
    {
        ogrNotlari = sibelNotlari;
    }

    decimal sinavlarinSonucu = 0;
    int notlarinToplami = 0;
    decimal seciliOgrninNotOrtalamasi = 0;
    int verilenOdevSayisi = 0;

    foreach(int not in ogrNotlari)
    {
        verilenOdevSayisi++;

        if(verilenOdevSayisi <= sinavSayisi)
        {
            notlarinToplami+=not;
            sinavlarinSonucu = (decimal)notlarinToplami/sinavSayisi;
        }
        else
        notlarinToplami+=not/10;
    }

    seciliOgrninNotOrtalamasi=notlarinToplami/(decimal)sinavSayisi;
    
    if(seciliOgrninNotOrtalamasi>=97 && seciliOgrninNotOrtalamasi<100) harfNotu="A+";
    else if(seciliOgrninNotOrtalamasi>=93) harfNotu="A";
    else if(seciliOgrninNotOrtalamasi>=90) harfNotu="A-";
    else if(seciliOgrninNotOrtalamasi>=87) harfNotu="B+";
    else if(seciliOgrninNotOrtalamasi>=83) harfNotu="B";
    else if(seciliOgrninNotOrtalamasi>=80) harfNotu="B-";
    else if(seciliOgrninNotOrtalamasi>=77) harfNotu="C+";
    else if(seciliOgrninNotOrtalamasi>=73) harfNotu="C";
    else if(seciliOgrninNotOrtalamasi>=70) harfNotu="C-";
    else if(seciliOgrninNotOrtalamasi>=67) harfNotu="D+";
    else if(seciliOgrninNotOrtalamasi>=63) harfNotu="D";
    else if(seciliOgrninNotOrtalamasi>=60) harfNotu="D-";
    else harfNotu="F";
    
    Console.WriteLine($"{seciliOgr}\t{sinavlarinSonucu}\t({seciliOgrninNotOrtalamasi-sinavlarinSonucu})\t{seciliOgrninNotOrtalamasi}\t{harfNotu}\t\t\t");
}
Console.WriteLine("Devam etmek icin bir tusa basiniz. ");
Console.ReadLine();
