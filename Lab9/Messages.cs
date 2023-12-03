namespace Lab9
{
    public class Messages
    {
        public const string InputTriangleArrayLength = "Введите кол-во элементов массива: ";
        public const string InputTriangleA = "Введите длину стороны a: ";
        public const string InputTriangleB = "Введите длину стороны b: ";
        public const string InputTriangleC = "Введите длину стороны c: ";
        public const string OutOfBoundsErrorMessage = "Индекс не входит в массив.";
        public const string TriangleToString = "Triangle({0:F3}, {1:F3}, {2:F3})";
        public const string TriangleArrayToString = "TriangleArray(\n\t{0}\n)";
        public const string InstanceCounterNoInstanceErrorMessage = "No instance counter for type {0}.";
        public const string MainDialogSelectTask = "Выберите задание:";
        public const string MainDialogTask1Option = "Задание 1";
        public const string MainDialogTask2Option = "Задание 2";
        public const string MainDialogTask3Option = "Задание 3";
        public const string Task1DialogWelcomeText = 
            "1. Реализовать (в отдельном файле) определение нового класса/типа данных (закрытые атрибуты, свойства, конструкторы, инициализация и вывод атрибутов). "
            + "\n2. Для демонстрации работы с объектами написать главную функцию, в которой создаются объекты класса и выводится информация, которая содержится в атрибутах. "
            + "\n3. Написать функцию, реализующую указанное в варианте действие. Рассмотреть два варианта:"
            + "\n\t1) статическую функцию; "
            + "\n\t2) метод класса. "
            + "\nВ основной функции продемонстрировать работу функции."
            + "\n4. Используя статическую компоненту класса подсчитать количество созданных в программе объектов."
            + "\n\nВариант 10:"
            + "\n1. Название класса: Triangle"
            + "\n2. Атрибуты (поля): double a, double b, double c (длины сторон треугольника)"
            + "\n3. Методы: Определить существует ли треугольник с такими длинами сторон. Результат должен быть типа bool"
            + "\n\nВыберите метод создания треугольника:";
        public const string Task2DialogWelcomeText = 
            "1. Добавить к реализованному классу указанные в варианте перегруженные операции."
            + "\n2. Написать демонстрационную программу, в которой создаются объекты пользовательских классов и выполняются указанные операции."
            + "\n\nВариант 10:"
            + "\n1. Название класса: Triangle"
            + "\n2. Методы:"
            + "\n\tУнарные операции:"
            + "\n\tВычисляется площадь треугольника, результатом должно быть вещественное число."
            + "\n\tОперации приведения типа:"
            + "\n\tdouble (неявная) – результатом является периметр треугольника;"
            + "\n\tbool (явная) – результатом является true, если треугольник с такими длинами сторон существует и false в противном случае."
            + "\n\tБинарные операции:"
            + "\n\t< - сравниваются площади треугольников;"
            + "\n\t> - сравниваются площади треугольников."
            + "\n\nВыберите метод создания треугольника:";
        public const string Task3DialogWelcomeText =
            "1. Реализовать класс-коллекцию (в отдельном файле), полем которого является одномерный массив (не использовать стандартные коллекции C#!) из элементов заданного в варианте типа. Например, для класса Fraction нужно создать класс FractionArray следующим образом:"
            + "\nВ классе реализовать:"
            + "\n• конструктор без параметров,"
            + "\n• конструктор с параметрами, заполняющий элементы случайными значениями, "
            + "\n• конструктор с параметрами, позволяющий заполнить массив элементами, заданными пользователем с клавиатуры,"
            + "\n• метод для просмотра элементов массива."
            + "\n2. Реализовать индексатор для доступа к элементам коллекции. Предусмотреть проверку при выходе индекса за пределы массива. "
            + "\n3. Написать демонстрационную программу, позволяющую создать массив разными способами и распечатать элементы массива. Подсчитать количество созданных объектов."
            + "\n4. Написать функцию в классе Program для выполнения указанного в варианте задания (использовать индексатор и, если необходимо, перегрузить нужные для выполнения задачи операции)."
            + "\n\nВариант 10:"
            + "\n1. Название класса: Triangle"
            + "\n2. Функция: Треугольник с минимальной площадью"
            + "\n\nВыберите метод создания коллекции:";
        public const string TasksDialogManual = "Вручную";
        public const string TasksDialogRandom = "Случайно";
        public const string TasksDialogEmpty = "Пустой";
        public const string InstanceCounterTriangle = "Количество экземпляров класса Triangle: {0}";
        public const string InstanceCounterTriangleArray = "Количество экземпляров класса TriangleArray: {0}";
        public const string Triangle = "Треугольник: {0}";
        public const string Task1ProcessIsExists = "Существует ли треугольник с такими длинами сторон:";
        public const string Task1ProcessIsExistsClassMethod = "triangle.IsExists() (метод класса) результат: {0}";
        public const string Task1ProcessIsExistsStaticMethod =  "Triangle.IsExists(triangle) (статический метод) результат: {0}";
        public const string Task2ProcessUnaryOperations = "Унарные операции:";
        public const string Task2ProcessUnaryOperationsClassMethod = "triangle.CalculateArea() (метод класса) результат: {0}";
        public const string Task2ProcessUnaryOperationsStaticMethod = "Triangle.CalculateArea(triangle) (статический метод) результат: {0}";
        public const string Task2ProcessTypecastOperations = "Операции приведения типа:";
        public const string Task2ProcessTypecastOperationsDouble = "Явное преобразование к double: {0}";
        public const string Task2ProcessTypecastOperationsBool = "Неявное преобразование к bool: {0}";
        public const string Task2ProcessBinaryOperations = "Бинарные операции:";
        public const string TasksDialogOtherTriangle = "Другой треугольник (создан рандомно): {0}";
        public const string Task2ProcessBinaryOperationsIsLessThan = "triangle < other: {0}";
        public const string Task2ProcessBinaryOperationsIsGreaterThan = "triangle > other: {0}";
        public const string Task3ProcessTriangleArray = "Коллекция треугольников: {0}";
        public const string Task3ProcessEmptyArray = "Коллекция пуста.";
        public const string Task3ProcessMinAreaTriangle = "Минимальный элемент (под номером {0}): {1}";
        public const string Task3ProcessSwapMinTriangle = "Замена минимального элемента случайным: {0}";
        public const string Task3ProcessUpdatedTriangleArray = "Обновленная коллекция треугольников: {0}";
        public const string Task3ProcessCreateNewTriangle = "Создайте новый треугольник, для проверки нахождения минимума: ";
        public const string Task3ProcessInputNewTriangeNumber = "Введите номер треугольника, на вместо которого будет вставлен новый треугольник: ";
        public const string Task3ProcessNumberNotFound = "Нет треугольника с таким номером!";
    }
}