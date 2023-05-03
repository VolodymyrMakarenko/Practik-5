using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    
    const string Disc1 = "Математика";
    const string Disc2 = "Фізика";
    const string Disc3 = "Історія";
    const string Disc4 = "Основи програмування";
    const string Disc5 = "Економіка";
    const string Disc6 = "Дискретна математика";
    const string Disc7 = "Філософія";
    const string Disc8 = "Англійська мова";
    const string Disc9 = "Соціологія";

    static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        List<string> generalDisciplines = new List<string> { Disc1, Disc2, Disc3 };
        List<string> mandatoryProfessionalDisciplines = new List<string> { Disc4, Disc5, Disc6 };
        List<string> electiveDisciplines = new List<string> { Disc7, Disc8, Disc9 };

        
        Console.WriteLine("Загальноосвітні дисципліни:");
        PrintDisciplines(generalDisciplines);
        Console.WriteLine();

        Console.WriteLine("Обов'язкові професійні дисципліни:");
        PrintDisciplines(mandatoryProfessionalDisciplines);
        Console.WriteLine();

        Console.WriteLine("Дисципліни за вибором студента:");
        PrintDisciplines(electiveDisciplines);
        Console.WriteLine();

        
        Console.Write("Введіть номери дисциплін, які ви хочете вивчити (від 1 до 9, через кому): ");
        string input = Console.ReadLine();

        
        string[] selectedDisciplines = input.Split(',');

        
        List<string> selectedDisciplinesNames = new List<string>();

        
        foreach (string number in selectedDisciplines)
        {
            switch (number.Trim())
            {
                case "1":
                    selectedDisciplinesNames.Add(Disc1);
                    break;
                case "2":
                    selectedDisciplinesNames.Add(Disc2);
                    break;
                case "3":
                    selectedDisciplinesNames.Add(Disc3);
                    break;
                case "4":
                    selectedDisciplinesNames.Add(Disc4);
                    break;
                case "5":
                    selectedDisciplinesNames.Add(Disc5);
                    break;
                case "6":
                    selectedDisciplinesNames.Add(Disc6);
                    break;
                case "7":
                    selectedDisciplinesNames.Add(Disc7);
                    break;
                case "8":
                    selectedDisciplinesNames.Add(Disc8);
                    break;
                case "9":
                    selectedDisciplinesNames.Add(Disc9);
                    break;
                default:
                    break;
            }
        }

        
        Console.WriteLine("Ви вибрали наступні дисципліни:");
        PrintDisciplines(selectedDisciplinesNames);
        Console.WriteLine();

        
        Console.WriteLine("Автор програми: <Volodymyr Makarenko>");

        
        Console.ReadKey();
    }

    
    static void PrintDisciplines(List<string> disciplines)
    {
        for (int i = 0; i < disciplines.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {disciplines[i]}");
        }
    }
}