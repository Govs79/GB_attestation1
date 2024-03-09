//Ввод исходного массива
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string [] newArray = new string [n];
Console.Write ($"Введите {n} элементов массива ");
for (int i =0; i<newArray.Length; i++) {
newArray[i] = Console.ReadLine();
}
// Выборка элементов <=3


// Вывод массива исходного

for (int i =0; i<newArray.Length; i++) {
Console.WriteLine(newArray[i]);
}
return 0;
