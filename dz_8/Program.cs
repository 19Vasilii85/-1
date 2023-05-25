/*
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());



for (int i=1; i<=number;i++){
    if ((i % 2) == 0){
        Console.WriteLine($"Число {i} из {number}");
    }
}
*/

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

string result_str = "";

for (int i=1; i<=number;i++){
    if ((i % 2) == 0){
        if(i<number-1){
            result_str = result_str+i.ToString()+", ";
        }
        else{
            result_str = result_str+i.ToString()+"";
        }
        
    }
}

Console.WriteLine($"Число {result_str} из {number}");