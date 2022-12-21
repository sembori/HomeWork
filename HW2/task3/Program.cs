using static System.Console;
Clear();

Write ("Введите номер дня недели: ");
int day = Convert.ToInt32(ReadLine());
if (day > 7){
WriteLine("К сожалению, в неделе меньше дней.");
}else if(day < 1){
    WriteLine("Нулевого дня в неделе нет. Хоть и хотелось бы еще денечек перед понедельником.");
}else{
WriteLine (day > 5? "Да" : "Нет" );
}