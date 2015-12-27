namespace Problem4.GenericListVersion
{
    class Program
    {
        static void Main()
        {
			Type typeList = typeof (GenericList<>);
            Object[] attributes = typeList.GetCustomAttributes(false);
            foreach (Object attribute in attributes)
            {
                Console.WriteLine(((VersionAttribute)attribute).Version);
            }
            //Same thing using lambda 
                typeof (GenericList<>).GetCustomAttributes(false)
                    .OfType<VersionAttribute>()
                    .ToList()
                    .ForEach(p => Console.WriteLine(p.Version));
        }
    }
}
