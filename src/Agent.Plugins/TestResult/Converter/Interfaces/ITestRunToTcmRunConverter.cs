﻿using Agent.Plugins.TestResultParser.TestResult.Models;
using Agent.Plugins.TestResultParser.TestResult.Models.Interfaces;

namespace Agent.Plugins.TestResultParser.TestResult.Converter.Interfaces
{
    interface ITestRunToTcmRunConverter
    {
        void Convert(TestRun testRun, ITcmTestRun tcmTestRun);
    }
}
