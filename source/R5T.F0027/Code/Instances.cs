using System;


namespace R5T.F0027
{
    public static class Instances
    {
        public static IDotnetCommandLineOperator DotnetCommandLineOperator { get; } = F0027.DotnetCommandLineOperator.Instance;
        public static IDotnetCommandNames DotnetCommandNames { get; } = F0027.DotnetCommandNames.Instance;
        public static IDotnetNugetOperator DotnetNugetOperator { get; } = F0027.DotnetNugetOperator.Instance;
        public static IDotnetNugetPushOperator DotnetNugetPushOperator { get; } = F0027.DotnetNugetPushOperator.Instance;
        public static IDotnetOperator DotnetOperator { get; } = F0027.DotnetOperator.Instance;
        public static IDotnetPackOperator DotnetPackOperator { get; } = F0027.DotnetPackOperator.Instance;
        public static IDotnetPublishOperator DotnetPublishOperator { get; } = F0027.DotnetPublishOperator.Instance;
        public static IExecutableNames ExecutableNames { get; } = F0027.ExecutableNames.Instance;
        public static IUrls Urls { get; } = F0027.Urls.Instance;
    }
}