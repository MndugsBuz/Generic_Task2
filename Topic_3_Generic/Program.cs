// See https://aka.ms/new-console-template for more information
using Topic_3_Generic; 
Console.WriteLine("Hello, World!");

// Task 2

/*
Sukurkite generic klasę su type T sąrašu viduje.

Turi būti funkcijos:
1. Atspausdinti sąrašą
2. Funkcija, kuri grąžina sąrašą konvertuotą į masyvą;
3. Funkcija, kuri prideda narį į sąrašą;
4. Funkcija, kuri prideda sąrašą narių į sąrašą;
5. Funkcija, kuri ištrina elementą sąraše;
6. Funkcija, kuri ištrina elementą sąraše pagal indeksą;
7. Funkcija, kuri ištrina visus atitinkamus elementus sąraše(pvz.: ištrina visus dvejetus);

*/

Console.WriteLine("Task 5(2) ");

var myList = new List<int> { 1, 2, 3, 4, 5, 3 };
Generic<int> generic = new Generic<int>(myList);

var secondList = new List<int> { 10, 22, 3, 4 };
Task2_Generic<int> generic2 = new Task2_Generic<int>(myList);

generic2.AddItem(10);
generic2.AddItem(10);
generic2.AddList(secondList);
generic2.RemoveElementFromList(2);
generic2.RemoveElementFromListByIndex(1);
generic2.RemoveDublicatesFromList(3);
generic2.PrintList();

