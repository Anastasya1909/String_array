// Вариант, когда первоначальный массив массив можно ввести с клавиатуры
Console.WriteLine("Enter strings:");

string[] AS; 
int count; 
string s;
string[] AS2; 

count = 0; 
AS = new string[count]; 

do
{       
    s = Console.ReadLine();        
    if (s!="")
    {          
        count++;      
        AS2 = new string[count];

        for (int i = 0; i < AS2.Length - 1; i++)            
        AS2[i] = AS[i];
        AS2[count - 1] = s;
        AS = AS2;
    }
} while (s != "");

for (int i = 0; i < AS.Length; i++)
    if(AS[i].Length <= 3)
    {
        Console.Write($"{AS[i]} ");
    }
Console.WriteLine();
