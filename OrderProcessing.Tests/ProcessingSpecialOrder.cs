using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BizUnit.Xaml;
using BizUnit.TestSteps.File;
using BizUnit.TestSteps.DataLoaders.File;
using System.Collections.ObjectModel;

namespace OrderProcessing.Tests
{
    [TestClass]
    public class ProcessingSpecialOrder
    {
        [TestMethod]
        public void SpecialOrderShouldBeSavedInCorrectFolder()
        {
            var testCase = new TestCase { Name = "Test that special order is saved in correct folder" };

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
                DirectoryPath = @"C:\Biztalk InOut\OrderProcessing\Special",
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
                CreationPath = @"C:\Biztalk InOut\OrderProcessing\In\SpecialOrder.xml",
                DataSource = new FileDataLoader { FilePath = @"..\..\..\OrderProcessing.Tests\TestData\SpecialOrder.xml" }
            };
            return createImportTestFile;
        }

        private static DeleteStep DeleteFilesStep()
        {
            var deleteFiles = new DeleteStep
            {
                FilePathsToDelete = new Collection<string> { @"C:\Biztalk InOut\OrderProcessing\In\*.xml", @"C:\Biztalk InOut\OrderProcessing\Special\*.xml" }
            };
            return deleteFiles;
        }
    }
}
