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

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch
{
	public partial class Hit<TDocument>
	{
		[JsonInclude]
		[JsonPropertyName("_explanation")]
		public Elastic.Clients.Elasticsearch.Explanation? Explanation { get; init; }

		[JsonInclude]
		[JsonPropertyName("_id")]
		public string Id { get; init; }

		[JsonInclude]
		[JsonPropertyName("_ignored")]
		public IReadOnlyCollection<string>? Ignored { get; init; }

		[JsonInclude]
		[JsonPropertyName("_index")]
		public string Index { get; init; }

		[JsonInclude]
		[JsonPropertyName("_nested")]
		public Elastic.Clients.Elasticsearch.NestedIdentity? Nested { get; init; }

		[JsonInclude]
		[JsonPropertyName("_node")]
		public string? Node { get; init; }

		[JsonInclude]
		[JsonPropertyName("_primary_term")]
		public long? PrimaryTerm { get; init; }

		[JsonInclude]
		[JsonPropertyName("_routing")]
		public string? Routing { get; init; }

		[JsonInclude]
		[JsonPropertyName("_score")]
		public double? Score { get; init; }

		[JsonInclude]
		[JsonPropertyName("_seq_no")]
		public long? SeqNo { get; init; }

		[JsonInclude]
		[JsonPropertyName("_shard")]
		public string? Shard { get; init; }

		[JsonInclude]
		[JsonPropertyName("_source")]
		[SourceConverter]
		public TDocument? Source { get; init; }

		[JsonInclude]
		[JsonPropertyName("_version")]
		public long? Version { get; init; }

		[JsonInclude]
		[JsonPropertyName("fields")]
		public Dictionary<string, object>? Fields { get; init; }

		[JsonInclude]
		[JsonPropertyName("highlight")]
		public Dictionary<string, IReadOnlyCollection<string>>? Highlight { get; init; }

		[JsonInclude]
		[JsonPropertyName("ignored_field_values")]
		public Dictionary<string, IReadOnlyCollection<string>>? IgnoredFieldValues { get; init; }

		[JsonInclude]
		[JsonPropertyName("inner_hits")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.InnerHitsResult>? InnerHits { get; init; }

		[JsonInclude]
		[JsonPropertyName("matched_queries")]
		public IReadOnlyCollection<string>? MatchedQueries { get; init; }

		[JsonInclude]
		[JsonPropertyName("sort")]
		public IReadOnlyCollection<object>? Sort { get; init; }
	}
}