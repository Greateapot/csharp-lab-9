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
            //* input 20, 30, 40
            //* test output
            //* pakt
            //* t1o2s -> t1o2e -> pakt
            //* back -> mm -> mmo2s -> mmo2e
            //* t2m -> t2o1e
            //* input: 40, 10, 50
            //* test output
            //* pakt
            //* t2o2s -> t2o2e -> pakt
            //* back -> mm -> mmo3s -> mmo3e
            //* t3m -> t3o1e
            //* input: 2, 20, 30, 40, 40, 10, 50
            //* test output
            //* pakt
            //* t3o2s -> t3o2e
            //* input: 10
            //* pakt
            //* t3o3s -> t3o3e -> pakt
            //* back -> exit

            Program.Main();
        }
    }
}