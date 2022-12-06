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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport.Products.Elasticsearch;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch;
public sealed partial class SearchShardsResponse : ElasticsearchResponse
{
	[JsonInclude]
	[JsonPropertyName("indices")]
	[ReadOnlyIndexNameDictionaryConverter(typeof(Elastic.Clients.Elasticsearch.Core.SearchShards.ShardStoreIndex))]
	public IReadOnlyDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.Core.SearchShards.ShardStoreIndex> Indices { get; init; }

	[JsonInclude]
	[JsonPropertyName("nodes")]
	public IReadOnlyDictionary<string, Elastic.Clients.Elasticsearch.NodeAttributes> Nodes { get; init; }

	[JsonInclude]
	[JsonPropertyName("shards")]
	public IReadOnlyCollection<IReadOnlyCollection<Elastic.Clients.Elasticsearch.NodeShard>> Shards { get; init; }
}