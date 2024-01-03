using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Iphone iphone = new Iphone("123456789");
        iphone.InstalarAplicativo("Instagram");

        Nokia nokia = new Nokia("987654321");
        nokia.InstalarAplicativo("WhatsApp");
    }
}