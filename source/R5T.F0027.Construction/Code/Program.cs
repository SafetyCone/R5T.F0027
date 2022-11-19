using System;


namespace R5T.F0027.Construction
{
    public class Program
    {
        public static void Main()
        {
            DotnetPublishOperator.Instance.Publish(
                @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.F0069\source\R5T.F0069\R5T.F0069.csproj",
                @"C:\Temp\Publish\R5T.F0069");
        }
    }
}
