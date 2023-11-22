namespace Lab9
{
    public static class InstanceCounter
    {
        private static readonly Dictionary<Type, uint> memory = new();

        public static uint Count<T>()
        {
            var type = typeof(T);
            if (memory.ContainsKey(type))
                return memory[type];
            else
                throw new ArgumentException(string.Format(Messages.InstanceCounterNoInstanceErrorMessage, type));
        }

        public static void Increase<T>()
        {
            var type = typeof(T);
            if (memory.ContainsKey(type))
                memory[type]++;
            else
                memory[type] = 1;
        }

        public static void Decrease<T>()
        {
            var type = typeof(T);
            if (!memory.ContainsKey(type) || memory[type] == 0)
                memory.Remove(type);
            else
                memory[type]--;
        }

        public static void Reset<T>()
        {
            var type = typeof(T);
            if (!memory.ContainsKey(type))
                throw new ArgumentException(string.Format(Messages.InstanceCounterNoInstanceErrorMessage, type));
            else
                memory[type] = 0;
        }
    }
}