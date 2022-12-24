using System;

using R5T.T0132;


namespace R5T.F0027.Construction
{
    [FunctionalityMarker]
    public partial interface IOperations : IFunctionalityMarker
    {
        public void PublishLibrary_WithNuGetPackage()
        {
            /// Inputs.
            var projectFilePath =
                //Z0018.ProjectFilePaths.Instance.R5T_F0074
                @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Z0022.Private\source\R5T.Z0022\R5T.Z0022.csproj"
                ;
            var publishDirectoryPath =
                @"C:\Temp\Publish\R5T.Z0022"
                ;


            /// Run.
            F0000.FileSystemOperator.Instance.ClearDirectory_Synchronous(
                publishDirectoryPath);

            DotnetPublishOperator.Instance.Publish(
                projectFilePath,
                publishDirectoryPath);

            F0034.WindowsExplorerOperator.Instance.OpenDirectoryInExplorer(
                publishDirectoryPath);
        }

        public void PublishLibrary()
        {
            DotnetPublishOperator.Instance.Publish(
                Z0018.ProjectFilePaths.Instance.R5T_F0069,
                @"C:\Temp\Publish\R5T.F0069");
        }
    }
}
