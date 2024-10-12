// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("ENGİN ZEYBEK");

// Implicit Conversion

byte a = 5;

sbyte b = 30;

short c = 50;

int d = a + b + c;

Console.WriteLine("d: " + d);

string n = "İrem Aytepe";

char s = 'A';

Object sn = n + s + d;

Console.WriteLine("SN: " + sn);

// Explicit Conversion

Console.Write("Yaşınızı giriniz: ");

int age = int.Parse(Console.ReadLine());

Console.WriteLine("-----------------");

Console.WriteLine("Yaşınız: " + age);

Console.WriteLine("Cinsiyetiniz: ");

char x = Convert.ToChar(Console.ReadLine());

Console.WriteLine("cinsiyet: " + x);

int y = 28;
byte ab = (byte)x;
Console.WriteLine(y + ab);

