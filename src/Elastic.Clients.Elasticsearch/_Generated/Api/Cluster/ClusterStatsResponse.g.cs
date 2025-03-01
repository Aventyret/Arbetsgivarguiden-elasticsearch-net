// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

#nullable restore

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport.Products.Elasticsearch;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Cluster;

public sealed partial class ClusterStatsResponse : ElasticsearchResponse
{
	/// <summary>
	/// <para>Name of the cluster, based on the Cluster name setting setting.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("cluster_name")]
	public string ClusterName { get; init; }

	/// <summary>
	/// <para>Unique identifier for the cluster.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("cluster_uuid")]
	public string ClusterUuid { get; init; }

	/// <summary>
	/// <para>Contains statistics about indices with shards assigned to selected nodes.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("indices")]
	public Elastic.Clients.Elasticsearch.Cluster.ClusterIndices Indices { get; init; }

	/// <summary>
	/// <para>Contains statistics about nodes selected by the request’s node filters.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("nodes")]
	public Elastic.Clients.Elasticsearch.Cluster.ClusterNodes Nodes { get; init; }
	[JsonInclude, JsonPropertyName("_nodes")]
	public Elastic.Clients.Elasticsearch.NodeStatistics? NodeStats { get; init; }

	/// <summary>
	/// <para>Health status of the cluster, based on the state of its primary and replica shards.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("status")]
	public Elastic.Clients.Elasticsearch.HealthStatus Status { get; init; }

	/// <summary>
	/// <para>Unix timestamp, in milliseconds, of the last time the cluster statistics were refreshed.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("timestamp")]
	public long Timestamp { get; init; }
}