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
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Aggregations;

public sealed partial class StringStatsAggregate : IAggregate
{
	[JsonInclude, JsonPropertyName("avg_length")]
	public double? AvgLength { get; init; }
	[JsonInclude, JsonPropertyName("avg_length_as_string")]
	public string? AvgLengthAsString { get; init; }
	[JsonInclude, JsonPropertyName("count")]
	public long Count { get; init; }
	[JsonInclude, JsonPropertyName("distribution")]
	public IReadOnlyDictionary<string, double>? Distribution { get; init; }
	[JsonInclude, JsonPropertyName("entropy")]
	public double? Entropy { get; init; }
	[JsonInclude, JsonPropertyName("max_length")]
	public int? MaxLength { get; init; }
	[JsonInclude, JsonPropertyName("max_length_as_string")]
	public string? MaxLengthAsString { get; init; }
	[JsonInclude, JsonPropertyName("meta")]
	public IReadOnlyDictionary<string, object>? Meta { get; init; }
	[JsonInclude, JsonPropertyName("min_length")]
	public int? MinLength { get; init; }
	[JsonInclude, JsonPropertyName("min_length_as_string")]
	public string? MinLengthAsString { get; init; }
}