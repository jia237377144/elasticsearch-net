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
using Elasticsearch.Net.Specification.MigrationApi;

// ReSharper disable once CheckNamespace
// ReSharper disable RedundantTypeArgumentsOfMethod
namespace Nest.Specification.MigrationApi
{
	///<summary>
	/// Migration APIs.
	/// <para>Not intended to be instantiated directly. Use the <see cref = "IElasticClient.Migration"/> property
	/// on <see cref = "IElasticClient"/>.
	///</para>
	///</summary>
	public class MigrationNamespace : NamespacedClientProxy
	{
		internal MigrationNamespace(ElasticClient client): base(client)
		{
		}

		/// <summary>
		/// <c>GET</c> request to the <c>migration.deprecations</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/migration-api-deprecation.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/migration-api-deprecation.html</a>
		/// </summary>
		public DeprecationInfoResponse DeprecationInfo(Func<DeprecationInfoDescriptor, IDeprecationInfoRequest> selector = null) => DeprecationInfo(selector.InvokeOrDefault(new DeprecationInfoDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>migration.deprecations</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/migration-api-deprecation.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/migration-api-deprecation.html</a>
		/// </summary>
		public Task<DeprecationInfoResponse> DeprecationInfoAsync(Func<DeprecationInfoDescriptor, IDeprecationInfoRequest> selector = null, CancellationToken ct = default) => DeprecationInfoAsync(selector.InvokeOrDefault(new DeprecationInfoDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>migration.deprecations</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/migration-api-deprecation.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/migration-api-deprecation.html</a>
		/// </summary>
		public DeprecationInfoResponse DeprecationInfo(IDeprecationInfoRequest request) => DoRequest<IDeprecationInfoRequest, DeprecationInfoResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>migration.deprecations</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/migration-api-deprecation.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/migration-api-deprecation.html</a>
		/// </summary>
		public Task<DeprecationInfoResponse> DeprecationInfoAsync(IDeprecationInfoRequest request, CancellationToken ct = default) => DoRequestAsync<IDeprecationInfoRequest, DeprecationInfoResponse>(request, request.RequestParameters, ct);
	}
}