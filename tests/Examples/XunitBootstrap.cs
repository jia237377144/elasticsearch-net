// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System;
using Elastic.Xunit;
using Examples;
using Tests.Configuration;
using Tests.Core.Xunit;
using Xunit;

[assembly: TestFramework("Elastic.Xunit.Sdk.ElasticTestFramework", "Elastic.Xunit")]
[assembly: ElasticXunitConfiguration(typeof(ExamplesXunitRunOptions))]

namespace Examples
{
	public class ExamplesXunitRunOptions : NestXunitRunOptions
	{
		public ExamplesXunitRunOptions() : base()
		{
			Environment.SetEnvironmentVariable($"NEST_RANDOM_TYPED_KEYS", "false");

			RunIntegrationTests = false;
			RunUnitTests = true;
			ClusterFilter = TestConfiguration.Instance.ClusterFilter;
			TestFilter = TestConfiguration.Instance.TestFilter;
			Version = TestConfiguration.Instance.ElasticsearchVersion;
			IntegrationTestsMayUseAlreadyRunningNode = false;
		}
	}
}
