// See https://aka.ms/new-console-template for more information
{
    Console.Write("Bir şifre girin: ");
    string sifre = Console.ReadLine();

    if (SifreGecerliMi(sifre))
    {
        Console.WriteLine("Girilen şifre güçlüdür.");
    }
    else
    {
        Console.WriteLine("Girilen şifre zayıftır. Lütfen belirtilen kurallara uygun bir şifre girin.");
    }
}

static bool SifreGecerliMi(string sifre)
{
    if (sifre.Length < 8)
        return false;

    if (!sifre.Any(char.IsUpper))
        return false;

    if (!sifre.Any(ch => "@#$%".Contains(ch)))
        return false;

    return true;
}
