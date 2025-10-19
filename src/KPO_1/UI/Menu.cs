namespace KPO_1.UI;

public class Menu
{
    public static void PrintMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Добро пожаловать в Московский зоопарк! ^^");
        Console.WriteLine("Действия:");
        Console.WriteLine("1. Добавить животного");
        Console.WriteLine("2. Добавить вещь ");
        Console.WriteLine("3. Подсчёт потребляемой еды");
        Console.WriteLine("4. Показать животных для контактного зоопарка");
        Console.WriteLine("5. Просмотреть инвентарные номера");
        Console.WriteLine("6. Выход");
        Console.Write("Выберите действие: ");
    }
}