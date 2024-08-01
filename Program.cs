//ogrenci adlari
string[] ogrAdlari =  ["yavuz","ahmet","fatma","sibel"];
//sinav sayisi
int sinavSayisi = 5;
//ilk 5 not sinav notu, sonrakiler odevlerin notlari katsayilari %10.
int[] yavuzNotlari =  {100,81,90,70,80,100,50};
int[] hamzaNotlari =  {100,100,60,70,80,80};
int[] omerNotlari =  {99,100,80,100,95,96};
int[] yagizNotlari =  {100,100,60,70,70,95,92};
//dongu icinde farkli ogrencilerin notlarını tutacak
int [] ogrNotlari = new int[];
//harf notu
string harfNotu = "";
//tablonun basliklari
Console.WriteLine("Ogrenci\t\tNot\t");

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
        ogrNotlari = hamzaNotlari;
    }
    else if (seciliOgr=="omer")
    {
        ogrNotlari = omerNotlari;
    }
    else if (seciliOgr=="yagiz")
    {
        ogrNotlari = yagizNotlari;
    }

    int notlarinToplami = 0;
    decimal seciliOgrninNotOrtalamasi = 0;

    int verilenOdevSayisi = 0;

    foreach(int not in ogrNotlari)
    {
        verilenOdevSayisi++;

        if(verilenOdevSayisi <= sinavSayisi)
        notlarinToplami+=not;
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

    Console.WriteLine($"{seciliOgr}\t\t{seciliOgrninNotOrtalamasi}\t{harfNotu}");
}
Console.WriteLine("Devam etmek icin bir tusa basiniz. ");
Console.ReadLine();


/*
foreach (string isim in ogrAdlari)
{
    string seciliOgr = isim;
    int yavuzToplam=0;
    decimal yavuzNot=0;
    if(seciliOgr == "yavuz")
    {
        foreach (int not in yavuzNotlari)
        {
            yavuzToplam+=not;
        }
        yavuzNot = yavuzToplam/(decimal)sinavSayisi;
        Console.WriteLine($"{ogrAdlari[0]}'un not ortalamasi {yavuzNot}");
    }
}
*/

/*
Console.WriteLine($"Ogrencimiz {ogrAdlari[0]}'nin no ortalamasi {ogr1Ort}");
Console.WriteLine($"Ogrencimiz {ogrAdlari[1]}'nin no ortalamasi {ogr2Ort}");
Console.WriteLine($"Ogrencimiz {ogrAdlari[2]}'nin no ortalamasi {ogr3Ort}");
Console.WriteLine($"Ogrencimiz {ogrAdlari[3]}'nin no ortalamasi {ogr4Ort}");

*/