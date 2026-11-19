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

// MainStats Hero_MainStats = new MainStats();
// System.Console.WriteLine();
// System.Console.Write("Введите имя героя: ");
// Hero_MainStats.Name = System.Console.ReadLine();
// System.Console.Write("Введите уровень героя: ");
// Hero_MainStats.Level = int.Parse(System.Console.ReadLine());
// OptionalStats Hero_OptionalStats = new OptionalStats();
// System.Console.Write("Хотите внести дополнительные хар-ки (true - да, false - нет): ");
// bool IsOptionalStats = bool.Parse(System.Console.ReadLine());
// if (IsOptionalStats)
// {
//     System.Console.Write("Введите расу героя: ");
//     Hero_OptionalStats.Race = System.Console.ReadLine();
//     System.Console.Write("Введите лучший атрибут героя: ");
//     Hero_OptionalStats.BestAttribute = System.Console.ReadLine();
// }
// System.Console.WriteLine();
// void PrintStats(in MainStats stats1, in OptionalStats stats2)
// {
//     System.Console.WriteLine($"Имя: {stats1.Name}");
//     System.Console.WriteLine($"Уровень: {stats1.Level}");
//     if (IsOptionalStats)
//     {
//         System.Console.WriteLine($"Раса: {stats2.Race}");
//         System.Console.WriteLine($"Лучший атрибут: {stats2.BestAttribute}");
//     }
// }
// PrintStats(Hero_MainStats, Hero_OptionalStats);
// struct MainStats
// {
//     public string Name;
//     public int Level;
// }
// struct OptionalStats
// {
//     public string Race;
//     public string BestAttribute;
// }

