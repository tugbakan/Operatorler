// Atama ve işlemli atama operatörleri:
Console.WriteLine("***Atama Operatörleri***");

int x=3;
int y=3;

y = y+2;
Console.WriteLine(y);
y+=2;
Console.WriteLine(y);
y/=1;
Console.WriteLine(y);
x*=2;
Console.WriteLine(x);

/* Mantıksal Operatörler:
  ||    veye
  &&    ve 
  !     değil      */

Console.WriteLine("***Mantıksal Operatörler***");
  bool isSuccess=true;
  bool isCompleted=false;

  if (isSuccess && isCompleted)  //Her iki koşul da true ise 
    Console.WriteLine("Perfect!");

  if (isSuccess || isCompleted)  //İkisinden biri true ise
    Console.WriteLine("Great!");

  if (isSuccess && !isCompleted)  //isCompleted'ın tersini alır. 
    Console.WriteLine("Fine!");

//Çıktıda "Perfect!" yazmaz çünkü biri true biri false olduğu için.


//İlişkisel operatörler (<,>,<=,>=,==,!=)

Console.WriteLine("***İlişkisel Operatörler***");

int a = 3;
int b = 4;
bool sonuc= a<b;
Console.WriteLine(sonuc);

sonuc= a>b;
Console.WriteLine(sonuc);

sonuc= a>=b;
Console.WriteLine(sonuc);

sonuc= a<=b;
Console.WriteLine(sonuc);

sonuc= a==b;
Console.WriteLine(sonuc);

sonuc= a!=b;
Console.WriteLine(sonuc);

//Aritmetik Operatörler ( /, *, +, -, ++, %)
Console.WriteLine("***Aritmetik Operatörler***");

int sayi1=10;
int sayi2=5;

int sonuc1= sayi1/sayi2;
Console.WriteLine(sonuc1);

sonuc1= sayi1*sayi2;
Console.WriteLine(sonuc1);

sonuc1= sayi1+sayi2;
Console.WriteLine(sonuc1);

sonuc1= sayi1-sayi2;
Console.WriteLine(sonuc1);

sonuc1= ++sayi1;
Console.WriteLine(sonuc1);

// Mod Alma Operatörü= %
int sonuc2= 20%3;
Console.WriteLine(sonuc2);