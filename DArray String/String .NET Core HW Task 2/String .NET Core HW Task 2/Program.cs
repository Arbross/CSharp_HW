using System;

namespace String_.NET_Core_HW_Task_2
{
    class Program
    {
        static String RemoveAllChoosedSymbols(String str, params char[] symbol)
        {
            if (str != null)
            {
                str = str.ToLower();
                for (int i = 0; i < str.Length; i++)
                {
                    for (int j = 0; j < symbol.Length; j++)
                    {
                        if (str[i] == symbol[j])
                        {
                            str = str.Replace(symbol[j], '\0');
                        }
                    }
                }
                String tmp = null;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] != '\0')
                    {
                        tmp += str[i];
                    }
                }
                str = tmp;
                return str;
            }
            return str;
        }
        static void Main()
        {
            Console.WriteLine(RemoveAllChoosedSymbols("Program", 'p', 'r'));
        }
    }
}
