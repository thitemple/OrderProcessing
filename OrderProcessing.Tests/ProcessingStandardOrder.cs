using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BizUnit.Xaml;
using BizUnit.TestSteps.File;
using System.Collections.ObjectModel;
using BizUnit.TestSteps.DataLoaders.File;

namespace OrderProcessing.Tests
{
    [TestClass]
    public class ProcessingStandardOrder
    {
        [TestMethod]
        public void StandardOrderShouldBeSavedInCorrectFolder()
        {
            var testCase = new TestCase { Name = "Test that standard order is saved in correct folder" };

            testCase.SetupSteps.Add(DeleteFilesStep());

            testCase.ExecutionSteps.Add(CreateFileStep());

            testCase.ExecutionSteps.Add(ValidateFileExits());

            var bizUnit = new BizUnit.BizUnit(testCase);
            bizUnit.RunTest();
        }

        private TestStepBase ValidateFileExits()
        {
            var validateFileExistsSTep = new FileReadMultipleStep
            {
                DirectoryPath = @"C:\Biztalk InOut\OrderProcessing\Standard",
                SearchPattern = "*.xml",
                ExpectedNumberOfFiles = 1,
                Timeout = 3000,
                DeleteFiles = true
            };
            return validateFileExistsSTep;
        }

        private static CreateStep CreateFileStep()
        {
            var createImportTestFile = new CreateStep
            {
                CreationPath = @"C:\Biztalk InOut\OrderProcessing\In\StandardOrder.xml",
                DataSource = new FileDataLoader { FilePath = @"..\..\..\OrderProcessing.Tests\TestData\StandardOrder.xml" }
            };
            return createImportTestFile;
        }

        private static DeleteStep DeleteFilesStep()
        {
            var deleteFiles = new DeleteStep
            {
                FilePathsToDelete = new Collection<string> { @"C:\Biztalk InOut\OrderProcessing\In\*.xml", @"C:\Biztalk InOut\OrderProcessing\Standard\*.xml" }
            };
            return deleteFiles;
        }
    }
}
