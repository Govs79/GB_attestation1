//Ввод исходного массива
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string [] newArray = new string [n];
Console.Write ($"Введите {n} элементов массива ");
for (int i =0; i<newArray.Length; i++) {
newArray[i] = Console.ReadLine();
}
// Выборка элементов <=3
int m = 0;
for (int i =0; i<newArray.Length; i++) {
    if (newArray[i].Length <= 3) {
        m++;}
    }
string [] redlineArray = new string[m];
for (int i=0;i<m;i++){
    if (newArray[i].Length <= 3){
        redlineArray[i] = newArray[i];
    }
   }

// Вывод массива исходного
Console.Write("Введенные элементы массива ");
for (int i=0; i<newArray.Length; i++)
{
Console.Write(newArray[i]);}
Console.Write("Элементы массива <= 3: ");
for (int i=0; i<redlineArray.Length; i++)  {
Console.Write(redlineArray[i]);}

return 0;
