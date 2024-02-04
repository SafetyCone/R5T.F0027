using System;


namespace R5T.F0027
{
    public static class Instances
    {
        public static IDotnetCommandLineOperator DotnetCommandLineOperator => F0027.DotnetCommandLineOperator.Instance;
        public static IDotnetCommandNames DotnetCommandNames => F0027.DotnetCommandNames.Instance;
        public static IDotnetNugetOperator DotnetNugetOperator => F0027.DotnetNugetOperator.Instance;
        public static IDotnetNugetPushOperator DotnetNugetPushOperator => F0027.DotnetNugetPushOperator.Instance;
        public static IDotnetOperator DotnetOperator => F0027.DotnetOperator.Instance;
        public static IDotnetPackOperator DotnetPackOperator => F0027.DotnetPackOperator.Instance;
        public static IDotnetPublishOperator DotnetPublishOperator => F0027.DotnetPublishOperator.Instance;
        public static IExecutableNames ExecutableNames => F0027.ExecutableNames.Instance;
        public static L0066.IFileSystemOperator FileSystemOperator => L0066.FileSystemOperator.Instance;
        public static L0066.IPathOperator PathOperator => L0066.PathOperator.Instance;
        public static IUrls Urls => F0027.Urls.Instance;
    }
}