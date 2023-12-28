Console.WriteLine("Введите количество строк цифрами");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите строки");
string [] stringArray = new string [size];
int newsize = 0;
int length = 0;
    for (int i = 0; i < size; i++)
        {
            stringArray[i] = Console.ReadLine();
            length = stringArray[i].Length; 
            if(length <= 3)
            {
                newsize ++;
            }
        }

string [] newStringArray = new string [newsize];
int j = 0;
    for (int i = 0; i < size; i++) 
        {
            length = stringArray[i].Length; 
            if(length <= 3)
            {
            newStringArray[j] = stringArray[i];
            j++;
            } 
        }

Console.WriteLine($"[{String.Join(", ", newStringArray)}]");
