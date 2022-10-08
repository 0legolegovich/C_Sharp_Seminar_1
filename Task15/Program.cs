Console.WriteLine("Введите число, соответствующее дню недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number==6 || number==7 )
    Console.WriteLine("Да");
else if (number==1 || number==2 || number==3 || number==4 || number==5)
    Console.WriteLine("Нет");
else
    Console.WriteLine("Данные введены некорректно");
