// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Domain;
using Tests.Framework.EndpointTests;
using static Tests.Framework.EndpointTests.UrlTester;

namespace Tests.XPack.MachineLearning.ValidateDetector
{
	public class ValidateDetectorUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls() => await POST("/_ml/anomaly_detectors/_validate/detector")
			.Fluent(c => c.MachineLearning.ValidateDetector<Project>(v => v))
			.Request(c => c.MachineLearning.ValidateDetector(new ValidateDetectorRequest()))
			.FluentAsync(c => c.MachineLearning.ValidateDetectorAsync<Project>(v => v))
			.RequestAsync(c => c.MachineLearning.ValidateDetectorAsync(new ValidateDetectorRequest()));
	}
}
