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
using Elasticsearch.Net.Specification.SnapshotLifecycleManagementApi;

// ReSharper disable once CheckNamespace
// ReSharper disable RedundantTypeArgumentsOfMethod
namespace Nest.Specification.SnapshotLifecycleManagementApi
{
	///<summary>
	/// Snapshot Lifecycle Management APIs.
	/// <para>Not intended to be instantiated directly. Use the <see cref = "IElasticClient.SnapshotLifecycleManagement"/> property
	/// on <see cref = "IElasticClient"/>.
	///</para>
	///</summary>
	public class SnapshotLifecycleManagementNamespace : NamespacedClientProxy
	{
		internal SnapshotLifecycleManagementNamespace(ElasticClient client): base(client)
		{
		}

		/// <summary>
		/// <c>DELETE</c> request to the <c>slm.delete_lifecycle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-delete.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-delete.html</a>
		/// </summary>
		public DeleteSnapshotLifecycleResponse DeleteSnapshotLifecycle(Id policyId, Func<DeleteSnapshotLifecycleDescriptor, IDeleteSnapshotLifecycleRequest> selector = null) => DeleteSnapshotLifecycle(selector.InvokeOrDefault(new DeleteSnapshotLifecycleDescriptor(policyId: policyId)));
		/// <summary>
		/// <c>DELETE</c> request to the <c>slm.delete_lifecycle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-delete.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-delete.html</a>
		/// </summary>
		public Task<DeleteSnapshotLifecycleResponse> DeleteSnapshotLifecycleAsync(Id policyId, Func<DeleteSnapshotLifecycleDescriptor, IDeleteSnapshotLifecycleRequest> selector = null, CancellationToken ct = default) => DeleteSnapshotLifecycleAsync(selector.InvokeOrDefault(new DeleteSnapshotLifecycleDescriptor(policyId: policyId)), ct);
		/// <summary>
		/// <c>DELETE</c> request to the <c>slm.delete_lifecycle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-delete.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-delete.html</a>
		/// </summary>
		public DeleteSnapshotLifecycleResponse DeleteSnapshotLifecycle(IDeleteSnapshotLifecycleRequest request) => DoRequest<IDeleteSnapshotLifecycleRequest, DeleteSnapshotLifecycleResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>DELETE</c> request to the <c>slm.delete_lifecycle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-delete.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-delete.html</a>
		/// </summary>
		public Task<DeleteSnapshotLifecycleResponse> DeleteSnapshotLifecycleAsync(IDeleteSnapshotLifecycleRequest request, CancellationToken ct = default) => DoRequestAsync<IDeleteSnapshotLifecycleRequest, DeleteSnapshotLifecycleResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>slm.execute_lifecycle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute.html</a>
		/// </summary>
		public ExecuteSnapshotLifecycleResponse ExecuteSnapshotLifecycle(Id policyId, Func<ExecuteSnapshotLifecycleDescriptor, IExecuteSnapshotLifecycleRequest> selector = null) => ExecuteSnapshotLifecycle(selector.InvokeOrDefault(new ExecuteSnapshotLifecycleDescriptor(policyId: policyId)));
		/// <summary>
		/// <c>POST</c> request to the <c>slm.execute_lifecycle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute.html</a>
		/// </summary>
		public Task<ExecuteSnapshotLifecycleResponse> ExecuteSnapshotLifecycleAsync(Id policyId, Func<ExecuteSnapshotLifecycleDescriptor, IExecuteSnapshotLifecycleRequest> selector = null, CancellationToken ct = default) => ExecuteSnapshotLifecycleAsync(selector.InvokeOrDefault(new ExecuteSnapshotLifecycleDescriptor(policyId: policyId)), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>slm.execute_lifecycle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute.html</a>
		/// </summary>
		public ExecuteSnapshotLifecycleResponse ExecuteSnapshotLifecycle(IExecuteSnapshotLifecycleRequest request) => DoRequest<IExecuteSnapshotLifecycleRequest, ExecuteSnapshotLifecycleResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>slm.execute_lifecycle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute.html</a>
		/// </summary>
		public Task<ExecuteSnapshotLifecycleResponse> ExecuteSnapshotLifecycleAsync(IExecuteSnapshotLifecycleRequest request, CancellationToken ct = default) => DoRequestAsync<IExecuteSnapshotLifecycleRequest, ExecuteSnapshotLifecycleResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>slm.execute_retention</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute-retention.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute-retention.html</a>
		/// </summary>
		public ExecuteRetentionResponse ExecuteRetention(Func<ExecuteRetentionDescriptor, IExecuteRetentionRequest> selector = null) => ExecuteRetention(selector.InvokeOrDefault(new ExecuteRetentionDescriptor()));
		/// <summary>
		/// <c>POST</c> request to the <c>slm.execute_retention</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute-retention.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute-retention.html</a>
		/// </summary>
		public Task<ExecuteRetentionResponse> ExecuteRetentionAsync(Func<ExecuteRetentionDescriptor, IExecuteRetentionRequest> selector = null, CancellationToken ct = default) => ExecuteRetentionAsync(selector.InvokeOrDefault(new ExecuteRetentionDescriptor()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>slm.execute_retention</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute-retention.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute-retention.html</a>
		/// </summary>
		public ExecuteRetentionResponse ExecuteRetention(IExecuteRetentionRequest request) => DoRequest<IExecuteRetentionRequest, ExecuteRetentionResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>slm.execute_retention</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute-retention.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute-retention.html</a>
		/// </summary>
		public Task<ExecuteRetentionResponse> ExecuteRetentionAsync(IExecuteRetentionRequest request, CancellationToken ct = default) => DoRequestAsync<IExecuteRetentionRequest, ExecuteRetentionResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>slm.get_lifecycle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-get.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-get.html</a>
		/// </summary>
		public GetSnapshotLifecycleResponse GetSnapshotLifecycle(Func<GetSnapshotLifecycleDescriptor, IGetSnapshotLifecycleRequest> selector = null) => GetSnapshotLifecycle(selector.InvokeOrDefault(new GetSnapshotLifecycleDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>slm.get_lifecycle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-get.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-get.html</a>
		/// </summary>
		public Task<GetSnapshotLifecycleResponse> GetSnapshotLifecycleAsync(Func<GetSnapshotLifecycleDescriptor, IGetSnapshotLifecycleRequest> selector = null, CancellationToken ct = default) => GetSnapshotLifecycleAsync(selector.InvokeOrDefault(new GetSnapshotLifecycleDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>slm.get_lifecycle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-get.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-get.html</a>
		/// </summary>
		public GetSnapshotLifecycleResponse GetSnapshotLifecycle(IGetSnapshotLifecycleRequest request) => DoRequest<IGetSnapshotLifecycleRequest, GetSnapshotLifecycleResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>slm.get_lifecycle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-get.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-get.html</a>
		/// </summary>
		public Task<GetSnapshotLifecycleResponse> GetSnapshotLifecycleAsync(IGetSnapshotLifecycleRequest request, CancellationToken ct = default) => DoRequestAsync<IGetSnapshotLifecycleRequest, GetSnapshotLifecycleResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>slm.get_stats</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/slm-get-stats.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/slm-get-stats.html</a>
		/// </summary>
		public GetSnapshotLifecycleStatsResponse GetSnapshotLifecycleStats(Func<GetSnapshotLifecycleStatsDescriptor, IGetSnapshotLifecycleStatsRequest> selector = null) => GetSnapshotLifecycleStats(selector.InvokeOrDefault(new GetSnapshotLifecycleStatsDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>slm.get_stats</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/slm-get-stats.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/slm-get-stats.html</a>
		/// </summary>
		public Task<GetSnapshotLifecycleStatsResponse> GetSnapshotLifecycleStatsAsync(Func<GetSnapshotLifecycleStatsDescriptor, IGetSnapshotLifecycleStatsRequest> selector = null, CancellationToken ct = default) => GetSnapshotLifecycleStatsAsync(selector.InvokeOrDefault(new GetSnapshotLifecycleStatsDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>slm.get_stats</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/slm-get-stats.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/slm-get-stats.html</a>
		/// </summary>
		public GetSnapshotLifecycleStatsResponse GetSnapshotLifecycleStats(IGetSnapshotLifecycleStatsRequest request) => DoRequest<IGetSnapshotLifecycleStatsRequest, GetSnapshotLifecycleStatsResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>slm.get_stats</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/slm-get-stats.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/slm-get-stats.html</a>
		/// </summary>
		public Task<GetSnapshotLifecycleStatsResponse> GetSnapshotLifecycleStatsAsync(IGetSnapshotLifecycleStatsRequest request, CancellationToken ct = default) => DoRequestAsync<IGetSnapshotLifecycleStatsRequest, GetSnapshotLifecycleStatsResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>slm.get_status</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-get-status.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-get-status.html</a>
		/// </summary>
		public GetSnapshotLifecycleManagementStatusResponse GetStatus(Func<GetSnapshotLifecycleManagementStatusDescriptor, IGetSnapshotLifecycleManagementStatusRequest> selector = null) => GetStatus(selector.InvokeOrDefault(new GetSnapshotLifecycleManagementStatusDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>slm.get_status</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-get-status.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-get-status.html</a>
		/// </summary>
		public Task<GetSnapshotLifecycleManagementStatusResponse> GetStatusAsync(Func<GetSnapshotLifecycleManagementStatusDescriptor, IGetSnapshotLifecycleManagementStatusRequest> selector = null, CancellationToken ct = default) => GetStatusAsync(selector.InvokeOrDefault(new GetSnapshotLifecycleManagementStatusDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>slm.get_status</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-get-status.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-get-status.html</a>
		/// </summary>
		public GetSnapshotLifecycleManagementStatusResponse GetStatus(IGetSnapshotLifecycleManagementStatusRequest request) => DoRequest<IGetSnapshotLifecycleManagementStatusRequest, GetSnapshotLifecycleManagementStatusResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>slm.get_status</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-get-status.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-get-status.html</a>
		/// </summary>
		public Task<GetSnapshotLifecycleManagementStatusResponse> GetStatusAsync(IGetSnapshotLifecycleManagementStatusRequest request, CancellationToken ct = default) => DoRequestAsync<IGetSnapshotLifecycleManagementStatusRequest, GetSnapshotLifecycleManagementStatusResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>slm.put_lifecycle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-put.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-put.html</a>
		/// </summary>
		public PutSnapshotLifecycleResponse PutSnapshotLifecycle(Id policyId, Func<PutSnapshotLifecycleDescriptor, IPutSnapshotLifecycleRequest> selector = null) => PutSnapshotLifecycle(selector.InvokeOrDefault(new PutSnapshotLifecycleDescriptor(policyId: policyId)));
		/// <summary>
		/// <c>PUT</c> request to the <c>slm.put_lifecycle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-put.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-put.html</a>
		/// </summary>
		public Task<PutSnapshotLifecycleResponse> PutSnapshotLifecycleAsync(Id policyId, Func<PutSnapshotLifecycleDescriptor, IPutSnapshotLifecycleRequest> selector = null, CancellationToken ct = default) => PutSnapshotLifecycleAsync(selector.InvokeOrDefault(new PutSnapshotLifecycleDescriptor(policyId: policyId)), ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>slm.put_lifecycle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-put.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-put.html</a>
		/// </summary>
		public PutSnapshotLifecycleResponse PutSnapshotLifecycle(IPutSnapshotLifecycleRequest request) => DoRequest<IPutSnapshotLifecycleRequest, PutSnapshotLifecycleResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>PUT</c> request to the <c>slm.put_lifecycle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-put.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-put.html</a>
		/// </summary>
		public Task<PutSnapshotLifecycleResponse> PutSnapshotLifecycleAsync(IPutSnapshotLifecycleRequest request, CancellationToken ct = default) => DoRequestAsync<IPutSnapshotLifecycleRequest, PutSnapshotLifecycleResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>slm.start</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-start.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-start.html</a>
		/// </summary>
		public StartSnapshotLifecycleManagementResponse Start(Func<StartSnapshotLifecycleManagementDescriptor, IStartSnapshotLifecycleManagementRequest> selector = null) => Start(selector.InvokeOrDefault(new StartSnapshotLifecycleManagementDescriptor()));
		/// <summary>
		/// <c>POST</c> request to the <c>slm.start</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-start.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-start.html</a>
		/// </summary>
		public Task<StartSnapshotLifecycleManagementResponse> StartAsync(Func<StartSnapshotLifecycleManagementDescriptor, IStartSnapshotLifecycleManagementRequest> selector = null, CancellationToken ct = default) => StartAsync(selector.InvokeOrDefault(new StartSnapshotLifecycleManagementDescriptor()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>slm.start</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-start.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-start.html</a>
		/// </summary>
		public StartSnapshotLifecycleManagementResponse Start(IStartSnapshotLifecycleManagementRequest request) => DoRequest<IStartSnapshotLifecycleManagementRequest, StartSnapshotLifecycleManagementResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>slm.start</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-start.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-start.html</a>
		/// </summary>
		public Task<StartSnapshotLifecycleManagementResponse> StartAsync(IStartSnapshotLifecycleManagementRequest request, CancellationToken ct = default) => DoRequestAsync<IStartSnapshotLifecycleManagementRequest, StartSnapshotLifecycleManagementResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>slm.stop</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-stop.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-stop.html</a>
		/// </summary>
		public StopSnapshotLifecycleManagementResponse Stop(Func<StopSnapshotLifecycleManagementDescriptor, IStopSnapshotLifecycleManagementRequest> selector = null) => Stop(selector.InvokeOrDefault(new StopSnapshotLifecycleManagementDescriptor()));
		/// <summary>
		/// <c>POST</c> request to the <c>slm.stop</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-stop.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-stop.html</a>
		/// </summary>
		public Task<StopSnapshotLifecycleManagementResponse> StopAsync(Func<StopSnapshotLifecycleManagementDescriptor, IStopSnapshotLifecycleManagementRequest> selector = null, CancellationToken ct = default) => StopAsync(selector.InvokeOrDefault(new StopSnapshotLifecycleManagementDescriptor()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>slm.stop</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-stop.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-stop.html</a>
		/// </summary>
		public StopSnapshotLifecycleManagementResponse Stop(IStopSnapshotLifecycleManagementRequest request) => DoRequest<IStopSnapshotLifecycleManagementRequest, StopSnapshotLifecycleManagementResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>slm.stop</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-stop.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-stop.html</a>
		/// </summary>
		public Task<StopSnapshotLifecycleManagementResponse> StopAsync(IStopSnapshotLifecycleManagementRequest request, CancellationToken ct = default) => DoRequestAsync<IStopSnapshotLifecycleManagementRequest, StopSnapshotLifecycleManagementResponse>(request, request.RequestParameters, ct);
	}
}