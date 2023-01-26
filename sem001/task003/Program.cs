Console.Clear();
Console.Write("Введите первое число от 1 до 7: ");
int day = int.Parse(Console.ReadLine());
if(day == 1){
    Console.Write("Понедельник");
}
if(day == 2){
    Console.Write("Вторник");
}
if(day == 3){
    Console.Write("Среда");
}
if(day == 4){
    Console.Write("Четверг");
}
if(day == 5){
    Console.Write("Пятница");
}
if(day == 6){
    Console.Write("Суббота");
}
if(day == 7){
    Console.Write("Воскресенье");
}