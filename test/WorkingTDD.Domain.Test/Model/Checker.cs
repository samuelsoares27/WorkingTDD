namespace WorkingTDD.Domain.Test.Model
{
    public class Checker
    {
        public bool Check<T>(T valueA, T valueB)
        {
            if (typeof(T) != typeof(string))
                throw new NotSupportedException();

            return true;
        }
    }
}
