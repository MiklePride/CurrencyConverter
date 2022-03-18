class program
{
    static void Main(string[] args)
    {
        float rubToUsd = 104;
        float usdToRub = 100;
        float rubToEur = 120;
        float eurToRub = 115;
        float rubCount;
        float usdCount;
        float eurCount;
        int userInput;
        float currencyCount;

        Console.WriteLine("Добро пожаловать в обменник! Перед началом операции, введите количество имеющихся валют.");
        Console.WriteLine("Количество рублей:");
        rubCount = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Количество долларов:");
        usdCount = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Количество евро:");
        eurCount = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Выберите тип операции:");
        Console.WriteLine("1 - Обменять рубли на доллары.");
        Console.WriteLine("2 - Обменять доллары на рубли.");
        Console.WriteLine("3 - Обменять рубли на евро.");
        Console.WriteLine("4 - Обменять евро на рубли.");
        Console.WriteLine("5 - Для выхода из системы.");
        userInput = Convert.ToInt32(Console.ReadLine());
        
        switch (userInput)
        {
            case 1:
                Console.WriteLine("Обмен рублей на доллары. Сколько хотите обменять?");
                currencyCount = Convert.ToSingle(Console.ReadLine());
                if(currencyCount <= rubCount)
                {
                    rubCount -= currencyCount;
                    usdCount += currencyCount / rubToUsd;
                }
                else
                {
                    Console.WriteLine("Недостаточно средств для конвертации.");
                }
                break;
            case 2:
                Console.WriteLine("Обмен долларов на рубли. Сколько хотите обменять?");
                currencyCount = Convert.ToSingle(Console.ReadLine());
                if( currencyCount <= usdCount)
                {
                    usdCount -= currencyCount;
                    rubCount += currencyCount * usdToRub;
                }
                else
                {
                    Console.WriteLine("Недостаточно средств для конвертации.");
                }
                break;
            case 3:
                Console.WriteLine("Обмен рублей на евро. Сколько хотите обменять?");
                currencyCount = Convert.ToSingle(Console.ReadLine());
                if(currencyCount <= rubCount)
                {
                    rubCount -= currencyCount;
                    eurCount += currencyCount / rubToEur;
                }
                else
                {
                    Console.WriteLine("Недостаточно средств для конвертации.");
                }
                break;
            case 4:
                Console.WriteLine("Обмен евро на рубли. Сколько хотите обменять?");
                currencyCount = Convert.ToSingle(Console.ReadLine());
                if(currencyCount <= eurCount)
                {
                    eurCount -= currencyCount;
                    rubCount += currencyCount * eurToRub;
                }
                break;
            case 5:
                Console.WriteLine("Досвидания!");
                break;
            default:
                Console.WriteLine("Ошибка ввода, попробуйте снова.");
                break;
        }
        Console.WriteLine($"Операция проведена успешно. Ваш балланс: {rubCount} рублей, {usdCount} долларов, {eurCount} евро");
    }
}