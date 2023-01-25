Menu();

static void Menu()
{
    Console.Clear();

    Console.Write("Hora: ");
    int hora = int.Parse(Console.ReadLine());
    Console.Write("Minuto: ");
    int minuto = int.Parse(Console.ReadLine());

    string s = timeInWords(hora, minuto);

    Console.WriteLine(s);
}

static string timeInWords(int h, int m)
    {
        string retorno = "";

        int a = 0;

        if(m > 30)
        {
            a = 1;
        }   
        string nomeMinuto = Minuto(m);
        string nomeHora = Hora(h, a);

        if(m == 0)
        {
            retorno = nomeHora+" "+nomeMinuto;
        } else
        {
            retorno = nomeMinuto+" "+nomeHora;
        }
        return retorno;
    }
        
    static string Hora(int h, int a)
    {   
        int t = h + a;
        string nome = "";
        switch(t)
        {
        case 0: nome = "zero"; break;
        case 1: nome = "one"; break;
        case 2: nome = "two"; break;
        case 3: nome = "three"; break;
        case 4: nome = "four"; break;
        case 5: nome = "five"; break;
        case 6: nome = "six"; break;
        case 7: nome = "seven"; break;
        case 8: nome = "eight"; break;
        case 9: nome = "nine"; break;
        case 10: nome = "ten"; break;
        case 11: nome = "eleven"; break;
        case 12: nome = "twelve"; break;
        case 13: nome = "thirteen"; break;
        case 14: nome = "thirteen"; break;
        case 15: nome = "fifteen"; break;
        case 16: nome = "sixteen"; break;
        case 17: nome = "seventeen"; break;
        case 18: nome = "eighteen"; break;
        case 19: nome = "nineteen"; break;
        case 20: nome = "twenty"; break;
        case 21: nome = "twenty one"; break;
        case 22: nome = "twenty two"; break;
        case 23: nome = "twenty three"; break;
        }
        return nome;
    }
    static string Minuto(int m)
    {   
        string nome = "";
        switch(m)
        {
            case 0: nome = "o' clock"; break;
            case 1: nome = "one minute past"; break;
            case 2: nome = "two minutes past"; break;
            case 3: nome = "three minutes past"; break;
            case 4: nome = "four minutes past"; break;
            case 5: nome = "five minutes past"; break;
            case 6: nome = "six minutes past"; break;
            case 7: nome = "seven minutes past"; break;
            case 8: nome = "eight minutes past"; break;
            case 9: nome = "nine minutes past"; break;
            case 10: nome = "ten minutes past"; break;
            case 11: nome = "eleven minutes past"; break;
            case 12: nome = "twelve minutes past"; break;
            case 13: nome = "thirteen minutes past"; break;
            case 14: nome = "fourteen minutes past"; break;
            case 15: nome = "quarter past"; break;
            case 16: nome = "sixteen minutes past"; break;
            case 17: nome = "seventeen minutes past"; break;
            case 18: nome = "eighteen minutes past"; break;
            case 19: nome = "nineteen minutes past"; break;
            case 20: nome = "twenty minutes past"; break;
            case 21: nome = "twenty one minutes past"; break;
            case 22: nome = "twenty two minutes past"; break;
            case 23: nome = "twenty three minutes past"; break;
            case 24: nome = "twenty four minutes past"; break;
            case 25: nome = "twenty five minutes past"; break;
            case 26: nome = "twenty six minutes past"; break;
            case 27: nome = "twenty seven minutes past"; break;
            case 28: nome = "twenty eight minutes past"; break;
            case 29: nome = "twenty nine minutes past"; break;
            case 30: nome = "half past"; break;
            case 31: nome = "twenty nine minutes to"; break;
            case 32: nome = "twenty eight minutes to"; break;
            case 33: nome = "twenty seven minutes to"; break;
            case 34: nome = "twenty six minutes to"; break;
            case 35: nome = "twenty five minutes to"; break;
            case 36: nome = "twenty four minutes to"; break;
            case 37: nome = "twenty three minutes to"; break;
            case 38: nome = "twenty two minutes to"; break;
            case 39: nome = "twenty one minutes to"; break;
            case 40: nome = "twenty minutes to"; break;
            case 41: nome = "nineteen minutes to"; break;
            case 42: nome = "eighteen minutes to"; break;
            case 43: nome = "seventeen minutes to"; break;
            case 44: nome = "sixteen minutes to"; break;
            case 45: nome = "quarter to"; break;
            case 46: nome = "fourteen minutes to"; break;
            case 47: nome = "thirteen minutes to"; break;
            case 48: nome = "twelve minutes to"; break;
            case 49: nome = "eleven minutes to"; break;
            case 50: nome = "ten minutes to"; break;
            case 51: nome = "nine minutes to"; break;
            case 52: nome = "eight minutes to"; break;
            case 53: nome = "seven minutes to"; break;
            case 54: nome = "six minutes to"; break;
            case 55: nome = "five minutes to"; break;
            case 56: nome = "four minutes to"; break;
            case 57: nome = "three minutes to"; break;
            case 58: nome = "two minutes to"; break;
            case 59: nome = "one minute to"; break;
        }
        return nome;
    }