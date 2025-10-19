using KPO_1.Abstractions;
using KPO_1.Services;
using KPO_1.UI;
using Microsoft.Extensions.DependencyInjection;

namespace KPO_1;

internal class Program
{
    static void Main()
    {
        var services = new ServiceCollection();
        services.AddSingleton<IHealtCheck, VeterinaryClinic>();
        services.AddSingleton<IZooRepository, ZooRepository>();
        services.AddSingleton<IZooServices, Zoo>();
        var provider = services.BuildServiceProvider();
        var zoo = provider.GetRequiredService<IZooServices>();

        while (true)
        {
            Menu.PrintMenu();
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "6":
                {
                    Console.WriteLine("Завершение работы");
                    return;
                }

                case "1":
                {
                    ChoiceAnimal.AddAnimal(zoo);
                    break;
                }

                case "2":
                {
                    ChoiceThing.AddThing(zoo);
                    break;
                }

                case "3":
                {
                    Reports.ShowSumFood(zoo);
                    break;
                }

                case "4":
                {
                    Reports.ShowContactZoo(zoo);
                    break;
                }

                case "5":
                {
                    Reports.ShowInventory(zoo);
                    break;
                }
                default:
                {
                    Console.WriteLine("Неизвестная команда, повторите её: ");
                    break;
                }
            }
        }
    }
}
