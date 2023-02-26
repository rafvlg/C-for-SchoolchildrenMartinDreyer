//Урок 2 Учимся общаться с компьютером.

// Barsic = new Animal();
// class Animal
// {
//    public string kindOfAnimal;
//    public string name;
//    public int numberOfLegs;
//    public int height;
//    public int lenght;
//    public string color;
//     bool hasTail;
//    protected bool isMammal;
//    private bool spellingCorrect;
// }

// class Zoo
// {
//     Animal a = new Animal();
//     // Следующая строка будет выполнена успешно, поскольку классу “Zoo”
//     // разрешено обращаться к открытым полям в классе “Animal”
//     a.kindOfAnimal = "Kangaroo"; 
//     // Обе следующие строки НЕ будут выполнены, поскольку классу “Zoo”
//     // не разрешено обращаться к закрытым или защищенным полям
//     a.isMammal = false; // Попытка обращения к защищенному методу
//     a.spellingCorrect = true;  // Попытка обращения к закрытому методу
// }

// Animal Barsik;
// Barsik = new Animal();
// Barsik.kingOfAnimal = "Cat";
// Barsik.name = "Кот Бфарсик";
// Barsik.numberOfLegs = 4;
// Barsik.height = 50;
// Barsik.lenght = 110;
// Barsik.color = "Black";
// Barsik.hasTail = true;
// Barsik.isMammal = true;

// void WriteHello(string firstName, string lastName)
// {
// Console.WriteLine("Hello " + firstName + " " + lastName);
// }
// WriteHello("Petr", "Ivanov");
// // Barsic = new Animal();

// int numberOfLegs(string animalName)
// {
//     if (animalName == "слон") //Если название животного — слон
//     {
//         return 4; // Возвращаемое значение 4
//     }
//     else if (animalName == "индейка") //Иначе, если животное — индейка
//     {
//         return 2; // Возвращаемое значение 2
//     }
//     else if (animalName == "устрица") //Иначе, если животное — устрица
//     {
//         return 1; // Возвращаемое значение 1
//     }
    
//     else //Иначе (при всех других условиях)
//     {
//         return 0; // Возвращаемое значение 0
//     }
// }

// int i;
// //Переменная “i” будет хранить значение числа конечностей.
// i = numberOfLegs("индейка");
// //Теперь i = 2, получив значение, возвращенное методом NumberOfLegs
// Console.WriteLine("У индейки конечностей - " + i);
// i = numberOfLegs("обезъяна");
// //Теперь i = 0. Догадайтесь, почему!
// Console.WriteLine("У обезьяны конечностей - " + i);

// class Animal
// {
//     //Поля
//     public string kindOfAnimal;
//     public string name;
//     public int numberOfLegs;
//     public int height;
//     public int lenght;
//     public string color; 
//     bool hasTail;
//     protected bool isMammal;
//     private bool spellingCorrect;
//     //Методы
//     // Открытый метод, получающий информацию о том, чем питается животное
//     public string GetFoodInfo()
//     {
//         // Представим, что здесь расположен код, выполняющий поиск по базе данных
//         //...
//     }
//      // Закрытый метод для проверки правильности написания вида животного
//     private void spellingCorrect()
//     {
//     // Представим, что здесь расположен код для проверки правописания
      
//     }
//     // Защищенный метод, определяет существование данного вида животного
//     protected bool IsVallidAnimalType()
//     {
//         //код для проверки существующих видов животных

//     }
// }

// class Zoo
// {
//     Animal a = new Animal();
//     a.name = "Kangaro";
//     string food;
//     bool animalExists;

//     // Следующий код будет выполнен успешно, поскольку классу “Zoo” разрешено
//     // обращаться к открытым методам в классе “Animal”
//     food = a.GetFoodInfo();  // Вызов открытого метода
//     // Обе следующие строки НЕ будут выполнены, поскольку классу “Zoo”
//     // не разрешено обращаться к закрытым или защищенным методам
//     a.spellingCorrect(); // Попытка вызова закрытого метода
//     animalExists = a.IsVallidAnimalType();   // Попытка вызова защищенного метода
// }

// class Person
// {
//     //Поля
//     string firstName;
//     string lastName;
//     //Метод-конструктор для класса Person
//     public Person()
//     {
//         firstName = "Jonny";
//         lastName = "Rocket";
//     }
//     // Второй метод-конструктор
//     public Person(string f, string l)
//     {
//         this.firstName =f;
//         this.lastName = l;
//     }
// }
// Person p = new Person();
// Person p = new Person("Petr", "Ivanov");


// using System;
// using System.Windows.Forms;
// class MyButtonClass: Form
// {
// private Button mrButton;
// // Метод-конструктор
// public MyButtonClass()
// {
// mrButton = new.Button();
// mrButton.Text = "Нажми меня";
// this.Controls.Add(mrButton);
// }
// // Основной метод
// static void Main()
// {
// Application.Run(new MyButtonClass());
// }
// }
// namespace AutoLotDAL2.Models
// {
// 	public class NewCar
// 	{
// 		public int CarID { get; set; }
// 		public string Color { get; set; }
// 		public string Make { get; set; }
// 		public string PetName { get; set; }
// 	}
// }





