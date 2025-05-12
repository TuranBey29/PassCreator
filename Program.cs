using System;
using System.IO;

class Program
{
    static void showHelp()
    {
        ConsoleWrite(".....PassCreator uygulamasına hoşgeldiniz.....", ConsoleColor.Green);
        ConsoleWrite("Kullanım: ", ConsoleColor.Green, false);
        ConsoleWrite("PassCreator.exe -length <length> -special <true/false>");
        ConsoleWrite("-length: ", ConsoleColor.Green, false);
        ConsoleWrite(" Şifrenizin uzunluğunu belirtebilirsiniz (Varsayılan değer 8'dir).");
        ConsoleWrite("-special: ", ConsoleColor.Green, false);
        ConsoleWrite("Şifrenizin özel karakterli olsun mu olmasın mı sorusudur. (Varsayılan değer false'dur).");
        ConsoleWrite("-copy: ", ConsoleColor.Green, false);
        ConsoleWrite("Şifreniz oluşturuldan sonra otomatik olarak kopyalar. (Varsayılan değer false'dur).");
        ConsoleWrite("-help: ", ConsoleColor.Green, false);
        ConsoleWrite("Yardım mesajını görüntülemeye yarar.");
        ConsoleWrite("developed by furkan lapcin", ConsoleColor.Red);
        Environment.Exit(0); // programdan çıkıyoruz.
    }

    static void ConsoleWrite(string text, ConsoleColor color = ConsoleColor.White, bool line = true)
    {
        Console.ForegroundColor = color;
        if (line)
            Console.WriteLine(text);
        else
            Console.Write(text);
        Console.ResetColor();
    }

    static string GeneratePassword(int length, bool special)
    {
        string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        if (special)
        {
            chars += "!@#$%^&*()"; // özel karakterler ekleniyor.
        }

        Random random = new Random();
        char[] password = new char[length];

        for (int i = 0; i < length; i++)
        {
            password[i] = chars[random.Next(chars.Length)];
        }

        return new string(password);
    }

    static void CopyToClipboard(string text)
    {
        TextCopy.ClipboardService.SetText(text);
    }

    static void Main(string[] args)
    {
        var length = 8; // default şifre uzunluğu
        var special = false; // default özel karakter durumu
        var copyToClipboard = false; // default panoya kopyalama durumu

        if (args.Length == 0) // eğer parametre yoksa
        {
            ConsoleWrite("Parametre yok. Varsayılan değerler kullanılıyor. Komutlar için -help", ConsoleColor.Yellow, true);
            ConsoleWrite("Varsayılan şifre: ", ConsoleColor.Green, false);
            ConsoleWrite(GeneratePassword(length, special));
            return;
        }

        foreach (var arg in args)
        {
            var index = Array.IndexOf(args, arg); // index alıyoruz.
            length = arg == "-length" ? Int32.Parse(args[index + 1]) : length; // şifre uzunluğunu alıyoruz.
            special = arg == "-special" ? Boolean.Parse(args[index + 1]) : special; // özel karakter durumunu alıyoruz.
            copyToClipboard = arg == "-copy" ? Boolean.Parse(args[index + 1]) : copyToClipboard; // panoya kopyalama durumunu alıyoruz.

            if (arg == "-help") { showHelp(); } // yardım parametresi gelirse showHelp fonsiyonunu çağırıyoruz.
        }

        var password = GeneratePassword(length, special); // şifreyi oluşturuyoruz.
        ConsoleWrite("Oluşturulan şifre: ", ConsoleColor.Green, false);
        ConsoleWrite(password);// şifreyi ekrana yazdırıyoruz.
        if (copyToClipboard) // eğer panoya kopyalama durumu varsa
        {
            CopyToClipboard(password); // şifreyi panoya kopyalıyoruz.
            ConsoleWrite("Şifre panoya kopyalandı.", ConsoleColor.Green);
        }
    }
}