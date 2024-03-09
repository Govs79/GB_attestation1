//Ввод исходного массива
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n<=0) {
    Console.WriteLine("Ошибка ввода");
    return 0;
}
string [] newArray = new string [n];
Console.Write ($"Введите {n} элементов массива ");
for (int i =0; i<newArray.Length; i++) {
newArray[i] = Console.ReadLine();
}
// Подсчет элементов <=3
int m = 0;
for (int i =0; i<newArray.Length; i++) {
    if (newArray[i].Length <= 3) {
        m++;}
    }
// Занесение элементов <=3 в массив
string [] redlineArray = new string[m];
int j = 0;
for (int i=0; i<newArray.Length; i++) {
    if (newArray[i].Length <= 3){
        redlineArray[j] = newArray[i];
        j++;
    }
   }

// Вывод массива исходного
Console.WriteLine("Введенные элементы массива ");
for (int i=0; i<newArray.Length; i++)
{
Console.Write($"{newArray[i]}" + "||");}
Console.WriteLine();
// Вывод массива c элементами <=3
Console.WriteLine("Элементы массива <= 3: ");
for (int i=0; i<redlineArray.Length; i++)  {
Console.WriteLine(redlineArray[i]);}

return 0;
