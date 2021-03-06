// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net.Specification.GraphApi;

// ReSharper disable once CheckNamespace
// ReSharper disable RedundantTypeArgumentsOfMethod
namespace Nest.Specification.GraphApi
{
	///<summary>
	/// Graph APIs.
	/// <para>Not intended to be instantiated directly. Use the <see cref = "IElasticClient.Graph"/> property
	/// on <see cref = "IElasticClient"/>.
	///</para>
	///</summary>
	public class GraphNamespace : NamespacedClientProxy
	{
		internal GraphNamespace(ElasticClient client): base(client)
		{
		}

		/// <summary>
		/// <c>POST</c> request to the <c>graph.explore</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/graph-explore-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/graph-explore-api.html</a>
		/// </summary>
		public GraphExploreResponse Explore<TDocument>(Func<GraphExploreDescriptor<TDocument>, IGraphExploreRequest> selector = null)
			where TDocument : class => Explore(selector.InvokeOrDefault(new GraphExploreDescriptor<TDocument>()));
		/// <summary>
		/// <c>POST</c> request to the <c>graph.explore</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/graph-explore-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/graph-explore-api.html</a>
		/// </summary>
		public Task<GraphExploreResponse> ExploreAsync<TDocument>(Func<GraphExploreDescriptor<TDocument>, IGraphExploreRequest> selector = null, CancellationToken ct = default)
			where TDocument : class => ExploreAsync(selector.InvokeOrDefault(new GraphExploreDescriptor<TDocument>()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>graph.explore</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/graph-explore-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/graph-explore-api.html</a>
		/// </summary>
		public GraphExploreResponse Explore(IGraphExploreRequest request) => DoRequest<IGraphExploreRequest, GraphExploreResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>graph.explore</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/graph-explore-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/graph-explore-api.html</a>
		/// </summary>
		public Task<GraphExploreResponse> ExploreAsync(IGraphExploreRequest request, CancellationToken ct = default) => DoRequestAsync<IGraphExploreRequest, GraphExploreResponse>(request, request.RequestParameters, ct);
	}
}