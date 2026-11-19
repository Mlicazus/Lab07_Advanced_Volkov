// // Шаг 2. ref — Swap

// void DoubleValue(ref int number)
// {
//     number = number * 2;
// }
// int x = 5;
// DoubleValue(ref x);
// Console.WriteLine(x); // 10 — изменилось
// void Swap(ref int a, ref int b)
// {
//     int ref_a = a;
//     int ref_b = b;
//     a = ref_b;
//     b = ref_a;
// }
// int a = 7;
// int b = 6;
// Swap(ref a, ref b);
// System.Console.WriteLine($"a = [{a}], b = [{b}]");

// // Шаг 3. out — частное и остаток

// bool TryDivide(int a, int b, out int result)
// {
//     if (b == 0)
//     {
//         result = 0;
//         return false;
//     }
//     else
//     {
//         result = a / b;
//         return true;
//     }
// }
// int a = 8;
// int b = 0;
// bool res = TryDivide(a, b, out int result);
// System.Console.WriteLine($"Результат - [{result}], [{res}]");

// void Division(int a, int b, out int quotient, out int remainder)
// {
//     quotient = a / b;
//     remainder = a % b;
// }
// int a = 9;
// int b = 3;
// Division(a, b, out int quotient, out int remainder);
// System.Console.WriteLine($"Частное - [{quotient}], остаток от деления - [{remainder}]");

// // Шаг 4. in

// CharacterStats Hero = new CharacterStats();
// Hero.Health = 100;
// Hero.Damage = 25;
// Hero.Armor = 50;
// PrintStats(Hero);
// void PrintStats(in CharacterStats stats)
// {
//     Console.WriteLine($"HP: {stats.Health}");
//     Console.WriteLine($"Урон: {stats.Damage}");
//     Console.WriteLine($"Броня: {stats.Armor}");
// }
// struct CharacterStats
// {
//     public int Health;
//     public int Damage;
//     public int Armor;
// }

// // Шаг 5. Необязательные параметры и именованные аргументы

// void PrintBox(string name, int level, int speed = 1, string race = "человек")
// {
//     Console.WriteLine($"Имя: {name}");
//     Console.WriteLine($"Уровень: {level}");
//     Console.WriteLine($"Скорость: {speed}");
//     Console.WriteLine($"Раса: {race}");
// }
// System.Console.WriteLine();
// PrintBox("Mlicazus", 15);
// System.Console.WriteLine();
// PrintBox("Mlicazus", 15, race: "эльф");
// System.Console.WriteLine();
// PrintBox(speed: 2, name: "Mlicazus", race: "эльф", level: 15);


// Итоговая задача. Проектирование системы персонажа

// void firstMethod(ref int health)
// {
//     health *= 10;
// }
// int health = 10;
// firstMethod(ref health);
// System.Console.WriteLine();
// System.Console.WriteLine($"Измененное здоровье: {health}");

// int secondMethod(int DM, out int damage)
// {
//     damage = DM;
//     return damage;
// }
// System.Console.WriteLine();
// int DM = 5;
// System.Console.WriteLine($"Итоговый урон вернувшийся с помощью return: {secondMethod(DM, out int damage)}");

// System.Console.WriteLine();
// void fourthMethod(int characteristics, bool description, string content = "подробное")
// {
//     System.Console.WriteLine($"Кол-во характеристик: {characteristics}");
//     System.Console.WriteLine($"Нужно ли описание: {description}");
//     System.Console.WriteLine($"Вид описание (если оно есть): {content}");
// }
// fourthMethod(5, content: "краткое", description: true);

// Characteristic hero = new Characteristic();
// hero.strength = 2;
// hero.intelligence = 10;
// hero.agility = 3;
// System.Console.WriteLine();
// thirdMethod(hero);
// void thirdMethod(in Characteristic stats)
// {
//     System.Console.WriteLine($"Сила: {stats.strength}");
//     System.Console.WriteLine($"Разум: {stats.intelligence}");
//     System.Console.WriteLine($"Ловкость: {stats.agility}");
// }
// struct Characteristic
// {
//     public int strength;
//     public int intelligence;
//     public int agility;
// }

// Самостоятельное задание (Базовое)

