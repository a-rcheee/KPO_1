namespace KPO_1.UI;

public class Input
{
    public static int ReadInt(string input, InputField field)
    {
        while (true)
        {
            Console.Write(input);
            string? line = Console.ReadLine();
            int value;
            if (!int.TryParse(line, out value))
            {
                Console.WriteLine("Число должно быть целым!");
                continue;
            }

            if (field == InputField.InventoryNumber)
            {
                return value;
            }

            if (field == InputField.Food)
            {
                return value;
            }

            if (field == InputField.Kindness)
            {
                if (value > 0 && value < 11)
                {
                    return value;
                }
                Console.WriteLine("Минимальное настроение у животного 1, максимальное - 10");
            }
        }
    }
    
}