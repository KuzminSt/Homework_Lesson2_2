using System;

namespace HomeWork_Lesson2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
              
            Console.WriteLine("Введите название продукта:");             //Запрашиваем Название
            string prod1 = Console.ReadLine();            
            prod1 = prod1.Trim().ToUpper();
            Console.WriteLine("Введите единицы измерения:" );               //Запрашиваем Ед измерения
            string measure = Console.ReadLine();
            measure = measure.Trim().ToLower();
            Console.WriteLine("Введите количество продукта:");           //Запрашиваем количество 
            string quantity = Console.ReadLine();
            quantity = quantity.Trim();
            quantity = quantity.Replace(".", ",");                     //Приводим количество  к дробному числу
            double quantityDouble = Convert.ToDouble(quantity);
            Console.WriteLine("Введите цену продукта за 1 ед:");          //Запрашиваем цену
            string price = Console.ReadLine();
            price = price.Trim();
            price = price.Replace(".", ",");                         //Приводим цену к дробному числу
            double priceDouble = Convert.ToDouble(price);

            Console.Clear();

            Console.WriteLine($"Наименование продукта: {prod1}\nЕдиницы измерения: {measure}");
            Console.WriteLine($"Цена за единицу: {priceDouble}\nКоличество: {quantityDouble}");
            Console.ReadLine();


        }
    }
}
