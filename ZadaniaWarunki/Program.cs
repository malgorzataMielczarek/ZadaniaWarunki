// See https://aka.ms/new-console-template for more information

//1.Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie.
//Dane testowe:
//a: 5
//b: 5
//Rezultat w terminalu: 5 i 5 są równe
{
    int a = 5, b = 5;
    Console.WriteLine("1. Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie.");

    Console.WriteLine("   Np.:");
    Console.WriteLine($"\ta = {a}");
    Console.WriteLine($"\tb = {b}");

    Console.WriteLine("   {0} i {1} {2}są równe", a, b, a == b ? "" : "nie ");

    Console.WriteLine("\n   Podaj swoje liczby całkowite:");

    Console.Write("\ta = ");
    string? integer1 = Console.ReadLine();
    bool success = int.TryParse(integer1, out a);

    Console.Write("\tb = ");
    string? integer2 = Console.ReadLine();
    success &= int.TryParse(integer2, out b);

    if (success) Console.WriteLine("   {0} i {1} {2}są równe", a, b, a == b ? "" : "nie ");
    else Console.WriteLine("   Podane wartości nie są liczbami całkowitymi.");
}

Thread.Sleep(500);
Console.WriteLine("\n");

//2.Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta.
//Dane testowe : 15
//Rezultat w terminalu: 15 jest liczbą nieparzystą
{
    Console.WriteLine("2. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta.");

    Console.Write("   Podaj liczbę całkowitą: ");

    if (int.TryParse(Console.ReadLine(), out int number))
        Console.WriteLine("   {0} jest liczbą {1}", number, number % 2 == 0 ? "parzystą" : "nieparzystą");
    else Console.WriteLine("   Podana wartość nie jest liczbą całkowitą.");
}

Thread.Sleep(500);
Console.WriteLine("\n");

//3.Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna.
//Dane testowe : 14
//Rezultat w terminalu: 14 jest liczbą dodatnią
{
    Console.WriteLine("3. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna.");

    Console.Write("   Podaj liczbę: ");

    if (double.TryParse(Console.ReadLine(), out double userNumber))
        Console.WriteLine("   {0} jest liczbą {1}", userNumber, userNumber > 0 ? "dodatnią" : userNumber < 0 ? "ujemną" : "równą zero");
    else Console.WriteLine("   Podana wartość nie jest liczbą.");
}

Thread.Sleep(500);
Console.WriteLine("\n");

//4.Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym.
//Dane testowe : 2016
//Rezultat w terminalu: 2016 jest rokiem przestępnym
{
    Console.WriteLine("4. Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym.");

    Console.Write("   Podaj rok: ");
    if (int.TryParse(Console.ReadLine(), out int year))
    {
        bool isLeap = (year % 4 == 0);
        if (isLeap && (year % 100 == 0))
            isLeap = year % 400 == 0;

        Console.WriteLine("   {0} {1}jest rokiem przestępnym", year, isLeap ? "" : "nie ");
    }
    else Console.WriteLine("   Nie udało się odczytać roku.");
}

Thread.Sleep(500);
Console.WriteLine("\n");

//5.Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko:
//posła - skończone 21 lat,
//premiera - skończone 21 lat,
//sentarora - 30 lat,
//prezydenta - miasta: 25 lat, RP: 35 lat.
//Dane testowe : 21
//Rezultat w terminalu: Możesz zostać posłem
{
    Console.WriteLine("5. Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora, prezydenta.");
    Console.Write("   Podaj swój wiek: ");
    if (float.TryParse(Console.ReadLine(), out float age))
    {
        if (age < 18)
            Console.WriteLine("   Jesteś za młody/a. Nie masz jeszcze praw wyborczych.");
        else if (age < 21)
            Console.WriteLine("   Posiadasz wyłącznie czynne prawo wyborcze.");
        else
        {
            Console.Write("   Możesz zostać posłem");
            if (age < 25)
                Console.WriteLine(" i premierem.");
            else
            {
                Console.Write(", premierem");
                if (age < 30)
                    Console.WriteLine(" lub prezydentem miasta.");
                else
                {
                    Console.Write(", prezydentem miasta");
                    if (age < 35)
                        Console.WriteLine(" lub senatorem.");
                    else
                        Console.WriteLine(", senatorem lub prezydentem RP.");
                }
            }
        }
    }
    else Console.WriteLine("   Nie udało się odczytać twojego wieku.");
}

Thread.Sleep(500);
Console.WriteLine("\n");

//6.Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu.
//Dane testowe : 140
//Rezultat w terminalu: Jesteś krasnoludem
{
    Console.WriteLine("6. Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu.");
    Console.Write("   Podaj swój wzrost w centymetrach: ");
    if (int.TryParse(Console.ReadLine(), out int height))
    {
        if (height < 100) Console.WriteLine("   Jesteś chochlikiem.");
        else if (height <= 150) Console.WriteLine("   Jesteś krasnoludem.");
        else if (height <= 175) Console.WriteLine("   Jesteś wiedźmą.");
        else if (height <= 195) Console.WriteLine("   Jesteś elfem.");
        else Console.WriteLine("   Jesteś trolem.");
    }
    else Console.WriteLine("   Nie udało się odczytać twojego wzrostu.");
}

Thread.Sleep(500);
Console.WriteLine("\n");

//7.Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, która jest największa
//Dane testowe:
//25
//63
//79
//Rezultat w terminalu: 79 jest największa z podanych
{
    Console.WriteLine("7. Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, która jest największa");

    decimal a = 25, b = 63, c = 79;
    Console.WriteLine("   Np.:");
    Console.WriteLine($"\ta = {a}");
    Console.WriteLine($"\tb = {b}");
    Console.WriteLine($"\tc = {c}");

    if (b > a) a = b;
    if (c > a) a = c;
    Console.WriteLine($"   {a} jest największa z podanych");

    Console.WriteLine("\n   Podaj swoje liczby");
    Console.Write("\ta = ");
    bool success = decimal.TryParse(Console.ReadLine(), out a);
    Console.Write("\tb = ");
    success &= decimal.TryParse(Console.ReadLine(), out b);
    Console.Write("\tc = ");
    success &= decimal.TryParse(Console.ReadLine(), out c);

    if (success)
    {
        if (b > a) a = b;
        if (c > a) a = c;
        Console.WriteLine($"   {a} jest największa z podanych");
    }
    else Console.WriteLine("   Nie udało się odczytać podanych liczb.");
}

Thread.Sleep(500);
Console.WriteLine("\n");

//8.Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach wg. Następujących kryteriów:
//Wynik z Matury z matematyki powyżej 70
//Wynik z fizyki powyżej 55
//Wynik z chemii powyżej 45
//Łączny wynik z 3 przedmiotów powyżej 180
//Albo
//Wynik z matematyki i jednego przedmiotu powyżej 150

//Dane testowe:
//Matematyka 80
//Fizyka 71
//Chemia 0
//Rezultat w terminalu: Kandydat dopuszczony do rekrutacji
{
    Console.WriteLine("8. Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach wg. Następujących kryteriów:");
    Console.WriteLine("\tWynik Matury z matematyki powyżej 70");
    Console.WriteLine("\tWynik Matury z fizyki powyżej 55");
    Console.WriteLine("\tWynik Matury z chemii powyżej 45");
    Console.WriteLine("\tŁączny wynik z 3 przedmiotów powyżej 180");
    Console.WriteLine("\tAlbo");
    Console.WriteLine("\tWynik z matematyki i jednego przedmiotu powyżej 150");

    Console.WriteLine("   Np.:");
    float maths = 80, physics = 71, chemistry = 0;
    Console.WriteLine($"\tMatematyka: {maths}");
    Console.WriteLine($"\tFizyka: {physics}");
    Console.WriteLine($"\tChemia: {chemistry}");

    if (maths > 70 || physics > 55 || chemistry > 45 || maths + physics + chemistry > 180 || maths + physics > 150 || maths + chemistry > 150)
        Console.WriteLine("   Kandydat dopuszczony do rekrutacji.");
    else Console.WriteLine("   Kandydat nie dopuszczony do rekrutacji.");

    Console.WriteLine("\n   Podaj swoje wyniki:");
    Console.Write("\tMatematyka: ");
    bool success = float.TryParse(Console.ReadLine(), out maths);
    Console.Write("\tFizyka: ");
    success &= float.TryParse(Console.ReadLine(), out physics);
    Console.Write("\tChemia: ");
    success &= float.TryParse(Console.ReadLine(), out chemistry);

    if (success)
    {
        if (maths > 70 || physics > 55 || chemistry > 45 || maths + physics + chemistry > 180 || maths + physics > 150 || maths + chemistry > 150)
            Console.WriteLine("   Kandydat dopuszczony do rekrutacji.");
        else Console.WriteLine("   Kandydat nie dopuszczony do rekrutacji.");
    }
    else Console.WriteLine("   Nie udało się odczytać podanych wyników matur.");
}

Thread.Sleep(500);
Console.WriteLine("\n");

//9.Napisz program, który odczyta temperaturę I zwróci nazwę jak w poniższych kryteriach
//Temp < 0 – cholernie piździ
//Temp 0 – 10 – zimno
//Temp 10 – 20 – chłodno
//Temp 20 – 30 – w sam raz
//Temp 30 – 40 – zaczyna być słabo, bo gorąco
//Temp >= 40 – a weź wyprowadzam się na Alaskę.

//Dane testowe : 41
//Rezultat w terminalu: a weź wyprowadzam się na Alaskę.
{
    Console.WriteLine("9. Napisz program, który odczyta temperaturę I zwróci nazwę jak w poniższych kryteriach");
    Console.WriteLine("\tTemp < 0 – cholernie piździ");
    Console.WriteLine("\tTemp 0 – 10 – zimno");
    Console.WriteLine("\tTemp 10 – 20 – chłodno");
    Console.WriteLine("\tTemp 20 – 30 – w sam raz");
    Console.WriteLine("\tTemp 30 – 40 – zaczyna być słabo, bo gorąco");
    Console.WriteLine("\tTemp >= 40 – a weź wyprowadzam się na Alaskę.");
    Console.Write("\n   Podaj temperaturę w stopniach Celsjusza: ");
    if (float.TryParse(Console.ReadLine(), out float temp))
    {
        if (temp < 0) Console.WriteLine("   cholernie piździ");
        else if (temp < 10) Console.WriteLine("   zimno");
        else if (temp < 20) Console.WriteLine("   chłodno");
        else if (temp < 30) Console.WriteLine("   w sam raz");
        else if (temp < 40) Console.WriteLine("   zaczyna być słabo, bo gorąco");
        else Console.WriteLine("   a weź wyprowadzam się na Alaskę.");
    }
    else Console.WriteLine("   Nie udało się odczytać temperatury");
}

Thread.Sleep(500);
Console.WriteLine("\n");

//10.Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trójkąt
//Dane testowe: 40 55 65
//Rezultat w terminalu: Można zbudować trójkąt
{
    Console.WriteLine("10. Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trójkąt");
    Console.WriteLine("   Np.:");
    double a = 40, b = 55, c = 65;
    Console.WriteLine($"\ta = {a}");
    Console.WriteLine($"\tb = {b}");
    Console.WriteLine($"\tc = {c}");
    if (a > 0 && b > 0 && c > 0 && a < b + c && b < a + c && c < a + b) Console.WriteLine("   Można zbudować trójkąt");
    else Console.WriteLine("   Nie można zbudować trójkąta");
    Console.WriteLine("\n   Podaj trzy liczby:");
    Console.Write("\ta = ");
    bool success = double.TryParse(Console.ReadLine(), out a);
    Console.Write("\tb = ");
    success &= double.TryParse(Console.ReadLine(), out b);
    Console.Write("\tc = ");
    success &= double.TryParse(Console.ReadLine(), out c);
    if (success)
    {
        if (a > 0 && b > 0 && c > 0 && a < b + c && b < a + c && c < a + b) Console.WriteLine("   Można zbudować trójkąt");
        else Console.WriteLine("   Nie można zbudować trójkąta");
    }
    else Console.WriteLine("   Nie udało się odczytać podanych długości.");
}

Thread.Sleep(500);
Console.WriteLine("\n");

//11.Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
//Ocena         Opis
//  6          Celujący
//  5        Bardzo dobry
//  4           Dobry
//  3        Dostateczny
//  2       Dopuszczający
//  1       Niedostateczny

//Dane testowe: 3
//Rezultat w terminalu: Dostateczny
{
    Console.WriteLine("11.Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:");
    Console.WriteLine("\tOcena         Opis");
    Console.WriteLine("\t  6          Celujący");
    Console.WriteLine("\t  5        Bardzo dobry");
    Console.WriteLine("\t  4           Dobry");
    Console.WriteLine("\t  3        Dostateczny");
    Console.WriteLine("\t  2       Dopuszczający");
    Console.WriteLine("\t  1       Niedostateczny");
    Console.Write("\n   Podaj ocenę: ");
    _ = int.TryParse(Console.ReadLine(), out int note);
    switch (note)
    {
        case 6: Console.WriteLine("   Celujący"); break;
        case 5: Console.WriteLine("   Bardzo dobry"); break;
        case 4: Console.WriteLine("   Dobry"); break;
        case 3: Console.WriteLine("   Dostateczny"); break;
        case 2: Console.WriteLine("   Dopuszczający"); break;
        case 1: Console.WriteLine("   Niedostateczny"); break;
        default: Console.WriteLine("   Podano nieprawidłową wartość."); break;
    }
}

Thread.Sleep(500);
Console.WriteLine("\n");

//12.Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę
//Dane testowe: 4
//Rezultat w terminalu: Czwartek
{
    Console.WriteLine("12.Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę");
    Console.Write("\n   Podaj numer dnia tygodnia: ");
    _ = int.TryParse(Console.ReadLine(), out int dayOfWeek);
    switch (dayOfWeek)
    {
        case 1: Console.WriteLine("   Poniedziałek"); break;
        case 2: Console.WriteLine("   Wtorek"); break;
        case 3: Console.WriteLine("   Środa"); break;
        case 4: Console.WriteLine("   Czwartek"); break;
        case 5: Console.WriteLine("   Piątek"); break;
        case 6: Console.WriteLine("   Sobota"); break;
        case 7: Console.WriteLine("   Niedziela"); break;
        default: Console.WriteLine("   Podano nieprawidłową wartość."); break;
    }
}

Thread.Sleep(500);
Console.WriteLine("\n");

//13.Napisz program, który będzie posiadał proste menu(wg.Wzoru poniżej) I będzie prostym kalkulatorem
//Podaj pierwszą liczbę:
//…
//Podaj drugą liczbę:
//…
//Podaj numer operacji do wykonania:
//1.Dodawanie
//2.Odejmowanie
//3.Mnożenie
//4.Dzielenie
//…
//Twój wynik to:
{
    Console.WriteLine("13.Napisz program, który będzie posiadał proste menu i będzie prostym kalkulatorem");
    decimal a, b;
    Console.Write("\tPodaj pierwszą liczbę: ");
    bool success = decimal.TryParse(Console.ReadLine(), out a);
    Console.Write("\tPodaj drugą liczbę: ");
    success = decimal.TryParse(Console.ReadLine(), out b);
    if (success)
    {
        Console.WriteLine("   Możliwe operacje:");
        Console.WriteLine("\t1. Dodawanie");
        Console.WriteLine("\t2. Odejmowanie");
        Console.WriteLine("\t3. Mnożenie");
        Console.WriteLine("\t4. Dzielenie");
        Console.Write("Podaj numer operacji do wykonania: ");

        _ = int.TryParse(Console.ReadLine(), out int operation);

        switch (operation)
        {
            case 1: Console.WriteLine($"Twój wynik to: {a} + {b} = {a + b}"); break;
            case 2: Console.WriteLine($"Twój wynik to: {a} - {b} = {a - b}"); break;
            case 3: Console.WriteLine($"Twój wynik to: {a} * {b} = {a * b}"); break;
            case 4: 
                Console.Write($"Twój wynik to: {a} / {b} = ");
                Console.WriteLine(b == 0 ? "błąd, nie można dzielić przez 0" : a / b);
                break;
            default: Console.WriteLine("Nie ma operacji o podanym numerze."); break;
        }
    }
    else Console.WriteLine("Nie udało się odczytać podanych liczb.");
}

Thread.Sleep(500);
Console.WriteLine("\n");