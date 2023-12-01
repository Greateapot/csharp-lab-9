namespace Lab9Tests
{
    public class Lab9Test
    {
        [Fact]
        public void Test()
        {
            var consoleIO = new TestableConsoleIO();

            //* main menu -> task 1 menu
            consoleIO.PushKey(ConsoleKey.Enter);

            //* t1m -> t1o1e
            consoleIO.PushKey(ConsoleKey.Enter);
            //* input 20, 30, 40
            consoleIO.PushLine("20", "30", "40");
            //* test output
            consoleIO.PushTest(Test1);
            //* pakt
            consoleIO.PushKey(ConsoleKey.Enter);
            //* t1o2s -> t1o2e -> pakt
            consoleIO.PushKey(ConsoleKey.DownArrow, ConsoleKey.Enter, ConsoleKey.Enter);
            //* back -> mm -> mmo2s -> mmo2e
            consoleIO.PushKey(ConsoleKey.Backspace, ConsoleKey.DownArrow, ConsoleKey.Enter);
            //* t2m -> t2o1e
            consoleIO.PushKey(ConsoleKey.Enter);
            //* input: 40, 10, 50
            consoleIO.PushLine("40", "10", "50");
            //* test output
            consoleIO.PushTest(Test2);
            //* pakt
            consoleIO.PushKey(ConsoleKey.Enter);
            //* t2o2s -> t2o2e -> pakt
            consoleIO.PushKey(ConsoleKey.DownArrow, ConsoleKey.Enter, ConsoleKey.Enter);
            //* back -> mm -> mmo3s -> mmo3e
            consoleIO.PushKey(ConsoleKey.Backspace, ConsoleKey.DownArrow, ConsoleKey.Enter);
            //* t3m -> t3o1e
            consoleIO.PushKey(ConsoleKey.Enter);
            //* input: 2, 20, 30, 40, 40, 10, 50
            consoleIO.PushLine("2", "20", "30", "40", "40", "10", "50");
            //* test output
            consoleIO.PushTest(Test3);
            //* pakt
            consoleIO.PushKey(ConsoleKey.Enter);
            //* t3o2s -> t3o2e
            consoleIO.PushKey(ConsoleKey.DownArrow, ConsoleKey.Enter);
            //* input: 10
            consoleIO.PushLine("10");
            //* pakt
            consoleIO.PushKey(ConsoleKey.Enter);
            //* t3o3s -> t3o3e -> pakt
            consoleIO.PushKey(ConsoleKey.DownArrow, ConsoleKey.Enter, ConsoleKey.Enter);
            //* back -> exit
            consoleIO.PushKey(ConsoleKey.Backspace, ConsoleKey.Backspace);

            Program.Main();
        }

        private static void Test1(string? output)
        {
            // arrange
            var exceptedOutput = string.Join("\n", new string[]{
                "Треугольник: Triangle(20, 30, 40)",
                "Существует ли треугольник с такими длинами сторон:",
                "triangle.IsExists() (метод класса) результат: True",
                "Triangle.IsExists(triangle) (статический метод) результат: True",
                "Количество экземпляров класса Triangle: 1"
            });

            // act

            // assert
            Assert.Contains(exceptedOutput, output);
        }

        private static void Test2(string? output)
        {
            // arrange
            var exceptedOutput1 = string.Join("\n", new string[]{
                "Треугольник: Triangle(40, 10, 50)",
                "Унарные операции:",
                "triangle.CalculateArea() (метод класса) результат: 0",
                "Triangle.CalculateArea(triangle) (статический метод) результат: 0",
                "Операции приведения типа:",
                "Явное преобразование к double: 0",
                "Неявное преобразование к bool: False",
                "Бинарные операции:"
            });
            var exceptedOutput2 = "Количество экземпляров класса Triangle: 4";

            // act

            // assert
            Assert.Contains(exceptedOutput1, output);
            Assert.Contains(exceptedOutput2, output);
        }

        private static void Test3(string? output)
        {
            // arrange
            var exceptedOutput1 = string.Join("\n", new string[]{
                "Коллекция треугольников: TriangleArray(Triangle(20, 30, 40), Triangle(40, 10, 50))",
                "Минимальный элемент (под номером 1): Triangle(20, 30, 40)"
            });
            var exceptedOutput2 = string.Join("\n", new string[]{
                "Количество экземпляров класса Triangle: 9",
                "Количество экземпляров класса TriangleArray: 1"
            });

            // act

            // assert
            Assert.Contains(exceptedOutput1, output);
            Assert.Contains(exceptedOutput2, output);
        }
    }
}