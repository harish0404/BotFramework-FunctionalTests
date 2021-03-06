﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;
using System.Threading.Tasks;
using Microsoft.Bot.Connector;
using SkillFunctionalTests.Common;
using TranscriptTestRunner;
using TranscriptTestRunner.XUnit;
using Xunit;
using Xunit.Abstractions;

namespace SkillFunctionalTests.LegacyTests
{
    [Trait("TestCategory", "FunctionalTests")]
    [Trait("TestCategory", "Legacy")]
    public class SimpleHostBotToDialogSkillTest : ScriptTestBase
    {
        private readonly string _testScriptsFolder = Directory.GetCurrentDirectory() + @"/LegacyTests/TestScripts";

        public SimpleHostBotToDialogSkillTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact(Skip = "Skipped until DialogSkillBot is supported.")]
        public async Task DialogSkillShouldConnect()
        {
            var runner = new XUnitTestRunner(new TestClientFactory(Channels.Directline, TestClientOptions[HostBot.EchoHostBot], Logger).GetTestClient(), TestRequestTimeout, Logger);
            await runner.RunTestAsync(Path.Combine(_testScriptsFolder, "DialogSkill.json"));
        }
    }
}
