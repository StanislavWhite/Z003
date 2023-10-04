// Проект программы для ВПИ
// Возможности программы
// 1. Расчёт результатов боевых столкновений на основе
// 1.1 Технологического качества войска
// 1.2 Боевого духа войска
// 1.3 Дисциплине войска
// 1.4 Типу войска
// 1.5 Количеству войска
// 1.6 Стратегии генерала (в случае с игроком, ведущий оценивает качество и детальность приказа, выставляя "оценку")
// 1.7 Укреплённости войска
// 1.8 Рельефа местности    
// 1.9 Погоды
// 1.20 Броска кубика

Console.Clear();

//Ручная генерация войска защиты
Console.WriteLine("-=- Ручная генерация войска защиты | Качество -=-");

Console.WriteLine("1. Введите 1 - 10 для определения технологического качества войска защиты: ");
int defendArmyTechQuality = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. Введите 1 - 10 для определения боевого духа войск защиты: ");
int defendArmyMoralSpirit = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("3. Введите 1 - 10 для определения дисциплины войска защиты: ");
int defendArmyDiscipline = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("4. Введите 1 - 10 для определения укреплённости войска защиты: ");
int defendArmyForty = Convert.ToInt32(Console.ReadLine());

Console.Clear();

Console.WriteLine("-=- Ручная генерация войска защиты | Количество -=-");

Console.WriteLine("1. Введите количество войск пехоты: ");
int defendArmyInfantry = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. Введите количество войск кавалерии: ");
int defendArmyCavalry = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("3. Введите количество войск артиллерии: ");
int defendArmyArtillery = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("4. Введите количество войск гвардии: ");
int defendArmyGuards = Convert.ToInt32(Console.ReadLine());

Console.Clear();

Console.WriteLine("-=- Ручная генерация войска защиты | Стратегия -=-");

Console.WriteLine("1. Введите оценку стратегии генерала: ");
int defendArmyGeneralStrategy = Convert.ToInt32(Console.ReadLine());

Console.Clear();


//Ручная генерация войск атаки
Console.WriteLine("-=- Ручная генерация войск атаки | Качество -=-");

Console.WriteLine("1. Введите 1 - 10 для определения технологического качества войска атаки: ");
int attackArmyTechQuality = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. Введите 1 - 10 для определения боевого духа войск атаки: ");
int attackArmyMoralSpirit = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("3. Введите 1 - 10 для определения дисциплины войска атаки: ");
int attackArmyDiscipline = Convert.ToInt32(Console.ReadLine());

Console.Clear();

Console.WriteLine("-=- Ручная генерация войска атаки | Количество -=-");

Console.WriteLine("1. Введите количество войск пехоты: ");
int attackArmyInfantry = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. Введите количество войск кавалерии: ");
int attackArmyCavalry = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("3. Введите количество войск артиллерии: ");
int attackArmyArtillery = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("4. Введите количество войск гвардии: ");
int attackArmyGuards = Convert.ToInt32(Console.ReadLine());

Console.Clear();

Console.WriteLine("-=- Ручная генерация войск атаки | Стратегия -=-");

Console.WriteLine("1. Введите оценку стратегии генерала: ");
int attackArmyGeneralStrategy = Convert.ToInt32(Console.ReadLine());

Console.Clear();

//Остальная часть ручной генерации

Console.WriteLine("-=- Остальная часть ручной генерации -=-");

Console.WriteLine("Выберите тип местности, указав цифру: ");
Console.WriteLine("1. Поля ");
Console.WriteLine("2. Леса ");
Console.WriteLine("3. Холмы ");
Console.WriteLine("4. Горы ");
Console.WriteLine("5. Болота ");
Console.WriteLine("6. Джунгли ");
Console.WriteLine("7. Пустыни ");
int terrain = Convert.ToInt32(Console.ReadLine());

Console.Clear();

Console.WriteLine("-=- Остальная часть ручной генерации -=-");

Console.WriteLine("Выберите сооружения: ");
Console.WriteLine("1. Деревня ");
Console.WriteLine("2. Город ");
Console.WriteLine("3. Форпост ");
Console.WriteLine("4. Крепость ");
int building = Convert.ToInt32(Console.ReadLine());

Console.Clear();

Console.WriteLine("-=- Остальная часть ручной генерации -=-");

Console.WriteLine("Выберите реку: ");
Console.WriteLine("1. Отсутствует ");
Console.WriteLine("2. Мелкая река ");
Console.WriteLine("3. Широкая река ");
int river = Convert.ToInt32(Console.ReadLine());

Console.Clear();


//Рандомная генерация

Console.WriteLine("-=- Параметры случайной генерации -=-");

int weather = new Random().Next(1, 4);
if (weather == 1)
{
    Console.WriteLine("Погода: Ясная ");
}
else if (weather == 2)
{
    Console.WriteLine("Погода: Пасмурная ");
}
else
{
    Console.WriteLine("Погода: Шторм ");
}

int bonceDefend = new Random().Next(1, 21);
Console.WriteLine($"Бросок кубика защиты: {bonceDefend}");

int bonceAttack = new Random().Next(1, 21);
Console.WriteLine($"Бросок кубика атаки: {bonceAttack}");

Console.WriteLine("Для того, чтобы провести расчёт, напишите что угодно: ");
Console.ReadLine();

Console.Clear();


//Расчёт

int StageDmg(int attack, int defend)
{
    int attackDmg = 0;
    int defendDmg = 0;
    if (attack < defend)
    {
        defendDmg = new Random().Next(5, 21);
        attackDmg = new Random().Next(1, 11);
    }
    else if (attack > defend)
    {
        defendDmg = new Random().Next(1, 11);
        attackDmg = new Random().Next(5, 21);
    }
    else if (attack == defend)
    {
        defendDmg = new Random().Next(1, 11);
        attackDmg = new Random().Next(1, 11);
    }
    return attackDmg;
    return defendDmg;
}
StageDmg(attackArmyMoralSpirit, defendArmyMoralSpirit);

int StageDf(int attack, int defend)
{
    int attackDf = 0;
    int defendDf = 0;
    if (attack < defend)
    {
        defendDf = new Random().Next(5, 21);
        attackDf = new Random().Next(1, 11);
    }
    else if (attack > defend)
    {
        defendDf = new Random().Next(1, 11);
        attackDf = new Random().Next(5, 21);
    }
    else if (attack == defend)
    {
        defendDf = new Random().Next(1, 11);
        attackDf = new Random().Next(1, 11);
    }
    return attackDf;
    return defendDf;
}
StageDmg(attackArmyDiscipline, defendArmyDiscipline);