using System;


namespace R5T.F0027
{
    public static class Instances
    {
        public static L0066.ICommandLineOperator CommandLineOperator => L0066.CommandLineOperator.Instance;
        public static IDotnetCommandLineOperator DotnetCommandLineOperator => F0027.DotnetCommandLineOperator.Instance;
        public static IDotnetCommandNames DotnetCommandNames => F0027.DotnetCommandNames.Instance;
        public static IDotnetNugetOperator DotnetNugetOperator => F0027.DotnetNugetOperator.Instance;
        public static IDotnetNugetPushOperator DotnetNugetPushOperator => F0027.DotnetNugetPushOperator.Instance;
        public static IDotnetOperator DotnetOperator => F0027.DotnetOperator.Instance;
        public static IDotnetPackOperator DotnetPackOperator => F0027.DotnetPackOperator.Instance;
        public static IDotnetPublishOperator DotnetPublishOperator => F0027.DotnetPublishOperator.Instance;
        public static L0066.IEnvironmentOperator EnvironmentOperator => L0066.EnvironmentOperator.Instance;
        public static L0066.IExceptionOperator ExceptionOperator => L0066.ExceptionOperator.Instance;
        public static IExecutableNames ExecutableNames => F0027.ExecutableNames.Instance;
        public static L0066.IExitCodeOperator ExitCodeOperator => L0066.ExitCodeOperator.Instance;
        public static L0066.IFileSystemOperator FileSystemOperator => L0066.FileSystemOperator.Instance;
        public static L0066.IPathOperator PathOperator => L0066.PathOperator.Instance;
        public static F0020.IProjectFileOperator ProjectFileOperator => F0020.ProjectFileOperator.Instance;
        public static L0066.IStringOperator StringOperator => L0066.StringOperator.Instance;
        public static IUrls Urls => F0027.Urls.Instance;
        public static L0066.IVersionOperator VersionOperator => L0066.VersionOperator.Instance;
    }
}