using ConsoleDialogLib;
using ConsoleIOLib;

namespace Lab9
{
    public class Program
    {
        private static readonly Random random = new(DateTimeOffset.Now.Millisecond);

        public static void Main() => ConsoleDialog.ShowDialog(MainDialog());

        private static ConsoleDialog MainDialog() => new(
            Messages.MainDialogSelectTask,
            new()
            {
                new(
                    Messages.MainDialogTask1Option,
                    (_) =>  ConsoleDialog.ShowDialog(Task1Dialog())
                ),
                new(
                    Messages.MainDialogTask2Option,
                    (_) =>  ConsoleDialog.ShowDialog(Task2Dialog())
                ),
                new(
                    Messages.MainDialogTask3Option,
                    (_) =>  ConsoleDialog.ShowDialog(Task3Dialog())
                ),
            }
        );

        private static ConsoleDialog Task1Dialog() => new(
            Messages.Task1DialogWelcomeText,
            new()
            {
                new(
                    Messages.TasksDialogManual,
                    (_) => Task1Process(),
                    pauseAfterExecuted: true
                ),
                new(
                    Messages.TasksDialogRandom,
                    (_) => Task1Process(true),
                    pauseAfterExecuted: true
                )
            }
        );

        private static ConsoleDialog Task2Dialog() => new(
            Messages.Task2DialogWelcomeText,
            new()
            {
                new(
                    Messages.TasksDialogManual,
                    (_) => Task2Process(),
                    pauseAfterExecuted: true
                ),
                new(
                    Messages.TasksDialogRandom,
                    (_) => Task2Process(true),
                    pauseAfterExecuted: true
                )
            }
        );

        private static ConsoleDialog Task3Dialog() => new(
            Messages.Task3DialogWelcomeText,
            new()
            {
                new(
                    Messages.TasksDialogManual,
                    (_) => Task3Process(),
                    pauseAfterExecuted: true
                ),
                new(
                    Messages.TasksDialogRandom,
                    (_) => Task3Process(isRandom: true),
                    pauseAfterExecuted: true
                ),
                new(
                    Messages.TasksDialogEmpty,
                    (_) => Task3Process(isEmpty: true),
                    pauseAfterExecuted: true
                )
            }
        );

        private static void Task1Process(bool isRandom = false)
        {
            var triangle = isRandom ? Triangle.CreateRandom(random) : Triangle.Create();

            ConsoleIO.WriteLineFormat(Messages.Triangle, triangle);

            {
                ConsoleIO.WriteLine(Messages.Task1ProcessIsExists);

                ConsoleIO.WriteLineFormat(Messages.Task1ProcessIsExistsClassMethod, triangle.IsExists());

                ConsoleIO.WriteLineFormat(Messages.Task1ProcessIsExistsStaticMethod, Triangle.IsExists(triangle));
            }

            ConsoleIO.WriteLineFormat(Messages.InstanceCounterTriangle, InstanceCounter.Count<Triangle>());
        }

        private static void Task2Process(bool isRandom = false)
        {
            var triangle = isRandom ? Triangle.CreateRandom(random) : Triangle.Create();

            ConsoleIO.WriteLineFormat(Messages.Triangle, triangle);

            {
                ConsoleIO.WriteLine(Messages.Task2ProcessUnaryOperations);

                ConsoleIO.WriteLineFormat(Messages.Task2ProcessUnaryOperationsClassMethod, triangle.CalculateArea());

                ConsoleIO.WriteLineFormat(Messages.Task2ProcessUnaryOperationsStaticMethod, Triangle.CalculateArea(triangle));
            }
            {
                ConsoleIO.WriteLine(Messages.Task2ProcessTypecastOperations);

                double perimeter = triangle;
                ConsoleIO.WriteLineFormat(Messages.Task2ProcessTypecastOperationsDouble, perimeter);

                var isExists = (bool)triangle;
                ConsoleIO.WriteLineFormat(Messages.Task2ProcessTypecastOperationsBool, isExists);
            }
            {
                ConsoleIO.WriteLine(Messages.Task2ProcessBinaryOperations);

                var other = Triangle.CreateRandom(random);

                ConsoleIO.WriteLineFormat(Messages.TasksDialogOtherTriangle, other);

                bool isLessThan = triangle < other;
                ConsoleIO.WriteLineFormat(Messages.Task2ProcessBinaryOperationsIsLessThan, isLessThan);

                bool isGreaterThan = triangle > other;
                ConsoleIO.WriteLineFormat(Messages.Task2ProcessBinaryOperationsIsGreaterThan, isGreaterThan);
            }

            ConsoleIO.WriteLineFormat(Messages.InstanceCounterTriangle, InstanceCounter.Count<Triangle>());
        }

        private static void Task3Process(bool isRandom = false, bool isEmpty = false)
        {
            TriangleArray triangles;
            int resultIndex;

            if (isEmpty)
            {
                triangles = new TriangleArray();
            }
            else
            {
                var length = ConsoleIO.Input<uint>(Messages.InputTriangleArrayLength);

                triangles = isRandom ? TriangleArray.CreateRandom(length, random) : TriangleArray.Create(length);
            }

            ConsoleIO.WriteLineFormat(Messages.Task3ProcessTriangleArray, triangles);
            {
                resultIndex = Min(triangles);

                ConsoleIO.WriteLine(
                    resultIndex < 0
                        ? Messages.Task3ProcessEmptyArray
                        : string.Format(Messages.Task3ProcessMinAreaTriangle, resultIndex + 1, triangles[resultIndex])
                );

                if (resultIndex < 0) return;
            }
            {
                ConsoleIO.WriteLine(Messages.Task3ProcessCreateNewTriangle);
                var triangle = Triangle.Create();

                var isValid = false;
                do
                {
                    try
                    {
                        var index = ConsoleIO.Input<int>(Messages.Task3ProcessInputNewTriangeNumber);
                        triangles[index -1] = triangle;
                        isValid = true;
                    }
                    catch (ArgumentException)
                    {
                        ConsoleIO.WriteLine(Messages.Task3ProcessNumberNotFound);
                    }
                } while (!isValid);
                ConsoleIO.WriteLineFormat(Messages.Task3ProcessUpdatedTriangleArray, triangles);
            }
            {
                resultIndex = Min(triangles);

                ConsoleIO.WriteLine(
                    resultIndex < 0
                        ? Messages.Task3ProcessEmptyArray
                        : string.Format(Messages.Task3ProcessMinAreaTriangle, resultIndex + 1, triangles[resultIndex])
                );
            }

            ConsoleIO.WriteLineFormat(Messages.InstanceCounterTriangle, InstanceCounter.Count<Triangle>());
            ConsoleIO.WriteLineFormat(Messages.InstanceCounterTriangleArray, InstanceCounter.Count<TriangleArray>());
        }

        private static int Min(TriangleArray triangles)
        {
            if (triangles.Length == 0) return -1;

            var resultIndex = 0;

            for (int index = 1; index < triangles.Length; index++)
                if (triangles[index] < triangles[resultIndex])
                    resultIndex = index;

            return resultIndex;
        }

    }
}