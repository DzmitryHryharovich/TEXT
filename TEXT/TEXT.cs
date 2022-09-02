namespace Text
{
    class NumbersToWords
    {
        public static string Number(int number)
        {
            string[] num1_9 = { "", "ОДИН ", "ДВА ", "ТРИ ", "ЧЕТЫРЕ ", "ПЯТЬ ", "ШЕСТЬ ", "СЕМЬ ", "ВОСЕМЬ ", "ДЕВЯТЬ " };
            string[] num11_19 = { "ДЕСЯТЬ ", "ОДИНАДЦАТЬ ", "ДВЕНАДЦАТЬ ", "ТРИНАДЦАТЬ ", "ЧЕТЫРНАДЦАТЬ ", "ПЯТНАДЦАТЬ ", "ШЕСНАДЦАТЬ ", "СЕМНАДЦАТЬ ", "ВОСЕМНАДЦАТЬ ", "ДЕВЯТНАДЦАТЬ " };
            string[] num10_90 = { "", "ДЕСЯТЬ ", "ДВАДЦАТЬ ", "ТРИДЦАТЬ ", "СОРОК ", "ПЯТЬДЕСЯТ ", "ШЕСТЬДЕСЯТ ", "СЕМДЕСЯТ ", "ВОСЕМДЕСЯТ ", "ДЕВЯНОСТА " };
            string[] num100_900 = { "", "СТО ", "ДВЕСТЕ ", "ТРИСТА ", "ЧЕТЫРЕСТА ", "ПЯТЬСОТ ", "ШЕСТЬСОТ ", "СЕМЬСОТ ", "ВОСЕМЬСОТ ", "ДЕВЯТЬСОТ " };
            string[] num1000_9000 = { "", "ОДНА ТЫСЯЧА ", "ДВЕ ТЫСЯЧИ ", "ТРИ ТЫСЯЧИ ", "ЧЕТЫРЕ ТЫСЯЧИ ", "ПЯТЬ ТЫСЯЧ ", "ШЕСТЬ ТЫСЯЧ ", "СЕМЬ ТЫСЯЧ ", "ВОСЕМЬ ТЫСЯЧ ", "ДЕВЯТЬ ТЫСЯЧ " };

            if (number >= 1 && number <= 9)
                return num1_9[number];
            else if (number == 0)
            {
                return "НОЛЬ ";
            }
            else if (number == 10)
            {
                return num10_90[1];
            }
            else if (number > 10 && number < 20)
            {
                return num11_19[number % 10];
            }
            else if (number > 19 && number < 100)
            {
                return num10_90[number / 10] +
                num1_9[number % 10];
            }
            else if (number > 99 && number < 1000)
            {
                if (number / 10 % 10 == 1)
                {
                    return num100_900[number / 100] +
                    num11_19[number % 10];
                }
                else
                {
                    return num100_900[number / 100] +
                    num10_90[number / 10 % 10] +
                    num1_9[number % 10];
                }
            }
            else if (number > 999 && number < 10000)
            {
                if (number / 10 % 10 == 1)
                {
                    return num1000_9000[number / 1000] +
                    num100_900[number / 100 % 10] +
                    num11_19[number % 10];
                }
                else
                {
                    return num1000_9000[number / 1000] +
                    num100_900[number / 100 % 10] +
                    num10_90[number / 10 % 10] +
                    num1_9[number % 10];
                }
            }
            return default;
        }
    }
}


