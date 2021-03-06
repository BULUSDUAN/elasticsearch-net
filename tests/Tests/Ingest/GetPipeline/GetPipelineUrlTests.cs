﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework.EndpointTests;
using static Tests.Framework.EndpointTests.UrlTester;

namespace Tests.Ingest.GetPipeline
{
	public class GetPipelineUrlTests
	{
		[U] public async Task Urls()
		{
			await GET($"/_ingest/pipeline")
					.Fluent(c => c.Ingest.GetPipeline())
					.Request(c => c.Ingest.GetPipeline(new GetPipelineRequest()))
					.FluentAsync(c => c.Ingest.GetPipelineAsync())
					.RequestAsync(c => c.Ingest.GetPipelineAsync())
				;

			var id = "id";

			await GET($"/_ingest/pipeline/{id}")
					.Fluent(c => c.Ingest.GetPipeline(g => g.Id(id)))
					.Request(c => c.Ingest.GetPipeline(new GetPipelineRequest(id)))
					.FluentAsync(c => c.Ingest.GetPipelineAsync(g => g.Id(id)))
					.RequestAsync(c => c.Ingest.GetPipelineAsync(new GetPipelineRequest(id)))
				;
		}
	}
}
