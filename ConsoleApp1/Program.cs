using System;

int x, y, z;
char actiondev;
string  repeater,langselector;
string quitText="", xText = "", yText = "", actionText = "", result="";
Console.WriteLine("Hello, World!");
StartPoint2:
Console.WriteLine("Select language(Enter ru or en and enter) ");
langselector = Console.ReadLine()!;
switch (langselector )
{
    case "ru":
        quitText = "Работа завершена, нажмите на 'r' повтора задачи, 'l' для выбора языка,  'q' для выхода из программы";
        xText = "Введите число X";
        yText = "Введите число Y";
        actionText = "Введите символ для действия ('+','-','*','/')";
        result = "Результат: ";
        break;
    case "en":
        quitText = "Job done, press 'r' to repeat again, 'l' to chose language, 'q' for exit.";
        xText = "Enter you x";
        yText = "Enter you y";
        actionText = "Enter action ('+','-','*','/')";
        result = "Result: ";
        break;
}
/*
if (Console.ReadLine()=="ru")
{
    quitText = "Работа завершена, нажмите на 'r' повтора задачи, 'q' для выхода из программы";
    Xtext = "Введите число X";
    Ytext = "Введите число Y";
    ActionText = "Введите символ для действия ('+','-','*','/')";
    Result = "Результат: ";
}
else if (Console.ReadLine()=="en")
{
    
        quitText = "Job done, press 'r' to repeat again, 'q' for exit.";
        Xtext = "Enter you x";
        Ytext = "Enter you y";
        ActionText = "Enter action ('+','-','*','/')";
        Result = "Result: ";
    
}
*/
StartPoint:
Console.WriteLine(xText);
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(yText);
y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(actionText);
actiondev = Convert.ToChar(Console.ReadLine()!);

switch (z = actiondev)
{
    case '+': z = x + y;
        break;
    case '-': z = x - y;
        break;
    case '*': z = x * y;
        break;
    case '/': z = x / y;
        break;
        
}

Console.WriteLine(result + Convert.ToString(z));
Console.WriteLine(quitText);
repeater = Console.ReadLine()!;
switch (repeater)
{
    case "r":
        goto StartPoint;
        
    case "l":
        goto StartPoint2;
        
    case "q":
        Environment.Exit(0);
        break;
    
}


/*if (repeater == "r")
{
    goto StartPoint;
}

else if (repeater =="q")
{
    
    {
        Environment.Exit(0);
    }
}*/

