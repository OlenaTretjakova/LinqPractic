using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Для масиву цілих реалізуйте наступні запити:
           //Отримати весь масив цілих.
           //Отримати парні цілі.
           //Отримати непарні цілі.
           //Отримати значення більше заданого.
           //Отримати числа в заданому діапазоні.
           //Отримати числа, кратні семи.Результат відсортуйте за
           //зростанням.
           //Отримати числа, кратні восьми.Результат відсортуйте за
            //спаданням.

            int[] arr = new int[100];
            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                int randomNumber = random.Next(-50, 51);
                arr[i] = randomNumber;
                Console.Write(arr[i]+ " ");
            }

            var listNumbers = arr;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("All elements.");
            foreach (var item in listNumbers)
            {
                Console.Write(item + " ");
            }

            var evenNumbers = arr.Where(item => item % 2 == 0);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Even elements.");
            foreach (var item in evenNumbers)
            {
                Console.Write(item + " ");
            }

            var oddNumbers = arr.Where(item => item % 2 != 0);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Odd elements.");
            foreach (var item in oddNumbers)
            {
                Console.Write(item + " ");
            }

            var moreThan = arr.Where(item => item> 25);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Elements more than 25 .");
            foreach (var item in moreThan)
            {
                Console.Write(item + " ");
            }

            var numInRang = arr.Where(item => item > 25 && item <30);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Elements more than 25 and less than 30 .");

            foreach (var item in numInRang)
            {
                Console.Write(item + " ");
            }

            var  multiple = arr.Where(item => item % 7 == 0).OrderByDescending(item=>item);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Elements multiple as applicable .");

            foreach (var item in multiple)
            {
                Console.Write(item + " ");
            }

            var multiple1 = arr.Where(item => item % 8 == 0).OrderBy(item => item);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Elements multiple by growth.");

            foreach (var item in multiple1)
            {
                Console.Write(item + " ");
            }


            //Для масиву рядків з назвою міст, реалізуйте наступні запити:
            //Отримати весь масив міст.
            //Отримати міста з довжиною назви, що дорівнює заданому.
            //Отримати міста, назви яких починаються з літери A.
            //Отримати міста, назви яких закінчуються літерою M.
            //Отримати міста, назви яких починаються з літери N і
            //закінчуються літерою K.
            //Отримати міста, назви яких починаються з Ne. Результат
            //відсортувати за спаданням.

            string[] cities = new string[]
            {
                "Київ",
                "Львів",
                "Харків",
                "Одеса",
                "Дніпро",
                "Запоріжжя",
                "Івано-Франківськ",
                "Тернопіль",
                "Чернівці",
                "Рівне",
                "Луцьк",
                "Хмельницький",
                "Черкаси",
                "Житомир",
                "Ужгород",
                "Вінниця",
                "Миколаїв",
                "Полтава",
                "Чернігів",
                "Суми",
                "Херсон",
                "Кропивницький",
                "Маріуполь",
                "Хуст",
                "Севастополь",
                "Краматорськ",
                "Славутич",
                "Харцизьк",
                "Біла Церква",
                "Мелітополь"
            };

            var allCities = cities;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Cities: ");

            int count = 0;

            foreach (var item in cities)
            {
                Console.Write(item + " ");
                count++;
                if (count == 13)
                {
                    Console.WriteLine();
                    count = 0;
                }
            }

            var allCitiesWhisLenght = cities.Where(item=>item.Length==5);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Cities whis length word 5 letters: ");

            count = 0;

            foreach (var item in allCitiesWhisLenght)
            {
                Console.Write(item + " ");
                count++;
                if (count == 13)
                {
                    Console.WriteLine();
                    count = 0;
                }
            }

            var citiesBeginingAtK = cities.Where(item =>item.StartsWith("К"));

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Cities are begen at K: ");

            count = 0;

            foreach (var item in citiesBeginingAtK)
            {
                Console.Write(item + " ");
                count++;
                if (count == 13)
                {
                    Console.WriteLine();
                    count = 0;
                }
            }

            var citiesLastAtA = cities.Where(item => item.EndsWith("а"));

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Cities are finiched at A: ");

            count = 0;

            foreach (var item in citiesLastAtA)
            {
                Console.Write(item + " ");
                count++;
                if (count == 13)
                {
                    Console.WriteLine();
                    count = 0;
                }
            }

            var fitstXLastT = cities.Where(item => item.EndsWith("т") && item.StartsWith("Х") );

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Cities are started at X and finished at t ");

            count = 0;

            foreach (var item in fitstXLastT)
            {
                Console.Write(item + " ");
                count++;
                if (count == 13)
                {
                    Console.WriteLine();
                    count = 0;
                }
            }

            var fitstK = cities.Where(item=>item.StartsWith("К")).OrderBy(item=>item);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Cities are started at K sorted:");

            count = 0;

            foreach (var item in fitstK)
            {
                Console.Write(item + " ");
                count++;
                if (count == 13)
                {
                    Console.WriteLine();
                    count = 0;
                }
            }

            //Реалізуйте тип користувача «Студент» з інформацією про ім'я,
            //прізвище, вік, назву навчального закладу.
            //Для масиву «Студент» реалізуйте наступні запити:
            // Отримати весь масив студентів.
            // Отримати список студентів з ім'ям Boris.
            // Отримати список студентів з прізвищем, яке починається з
            //Bro.
            // Отримати список студентів, старших 19 років.
            // Отримати список студентів, старших 20 років і молодших 23
            //років.
            // Отримати список студентів, які навчаються в MIT.
            // Отримати список студентів, які навчаються в Oxford, і вік
            //яких старше 18 років.Результат відсортуйте за віком, за
            //спаданням


            Student[] students = new Student[]
        {
            new Student("John", "Smith", 18, "ABC High School"),
            new Student("Emma", "Johnson", 17, "MNO Prep"),
            new Student("Michael", "Williams", 19, "PQR School"),
            new Student("Sophia", "Brown", 16, "LMN High"),
            new Student("William", "Jones", 18, "MNO Prep"),
            new Student("Olivia", "Davis", 17, "GHI College"),
            new Student("James", "Miller", 18, "STU Academy"),
            new Student("Charlotte", "Wilson", 16, "VWX School"),
            new Student("Daniel", "Taylor", 17, "MNO Prep"),
            new Student("Ava", "Moore", 18, "MNO Prep")
        };

            var allStudents = students;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("All students:");

            foreach (var item in allStudents)
            {
                Console.WriteLine(item.ToString());
            }

            var whoNamesJames = students.Where(item => item.Name == "James");

            Console.WriteLine();

            Console.WriteLine("Studens who have name James:");

            foreach (var item in whoNamesJames)
            {
                Console.WriteLine(item.ToString());
            }

            var whoLastNameStartsMo = students.Where(item => item.LastName.StartsWith("Mo"));

            Console.WriteLine();

            Console.WriteLine("Studens whose lastname begins whis Mo:");

            foreach (var item in whoLastNameStartsMo)
            {
                Console.WriteLine(item.ToString());
            }

            var studentsOlders17 = students.Where(item => item.Age > 17).Select(s => new {s.Name,s.Age});

            Console.WriteLine();

            Console.WriteLine("Studens olders 18 year:");

            foreach (var item in studentsOlders17)
            {
                Console.WriteLine(item.ToString());
            }

            var studentsAgeFrom17to19 = students.OrderByDescending(item=>item.Name)
                .Where(item => item.Age > 17 && item.Age<19)
                .Select(s => new {s.Name, s.Age});

            Console.WriteLine();

            Console.WriteLine("Studens olders 17 and janger 19 year:");

            foreach (var item in studentsAgeFrom17to19)
            {
                Console.WriteLine(item.ToString());
            }

            var studesToMNOPrepOlders17 = students.Where(item => item.SchoolName == "MNO Prep" && item.Age > 17)
                .OrderBy(item => item.Age)
                .Select(s => new {s.Name, s.Age});

            Console.WriteLine();

            Console.WriteLine("Studens olders 17 and janger 19 year:");

            foreach (var item in studesToMNOPrepOlders17)
            {
                Console.WriteLine(item.ToString());
            } 

            Console.WriteLine();



            Console.ReadLine();
        }
    }
}
