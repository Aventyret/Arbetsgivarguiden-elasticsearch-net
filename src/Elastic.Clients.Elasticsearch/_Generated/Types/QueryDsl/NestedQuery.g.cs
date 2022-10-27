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
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.QueryDsl;
public sealed partial class NestedQuery : Query
{
	[JsonInclude]
	[JsonPropertyName("_name")]
	public string? QueryName { get; set; }

	[JsonInclude]
	[JsonPropertyName("boost")]
	public float? Boost { get; set; }

	[JsonInclude]
	[JsonPropertyName("ignore_unmapped")]
	public bool? IgnoreUnmapped { get; set; }

	[JsonInclude]
	[JsonPropertyName("inner_hits")]
	public Elastic.Clients.Elasticsearch.Core.Search.InnerHits? InnerHits { get; set; }

	[JsonInclude]
	[JsonPropertyName("path")]
	public Elastic.Clients.Elasticsearch.Field Path { get; set; }

	[JsonInclude]
	[JsonPropertyName("query")]
	public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer Query { get; set; }

	[JsonInclude]
	[JsonPropertyName("score_mode")]
	public Elastic.Clients.Elasticsearch.QueryDsl.ChildScoreMode? ScoreMode { get; set; }

	public static implicit operator QueryContainer(NestedQuery nestedQuery) => QueryContainer.Nested(nestedQuery);
}

public sealed partial class NestedQueryDescriptor<TDocument> : SerializableDescriptor<NestedQueryDescriptor<TDocument>>
{
	internal NestedQueryDescriptor(Action<NestedQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
	public NestedQueryDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Core.Search.InnerHits? InnerHitsValue { get; set; }

	private Core.Search.InnerHitsDescriptor<TDocument> InnerHitsDescriptor { get; set; }

	private Action<Core.Search.InnerHitsDescriptor<TDocument>> InnerHitsDescriptorAction { get; set; }

	private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer QueryValue { get; set; }

	private QueryContainerDescriptor<TDocument> QueryDescriptor { get; set; }

	private Action<QueryContainerDescriptor<TDocument>> QueryDescriptorAction { get; set; }

	private string? QueryNameValue { get; set; }

	private float? BoostValue { get; set; }

	private bool? IgnoreUnmappedValue { get; set; }

	private Elastic.Clients.Elasticsearch.Field PathValue { get; set; }

	private Elastic.Clients.Elasticsearch.QueryDsl.ChildScoreMode? ScoreModeValue { get; set; }

	public NestedQueryDescriptor<TDocument> InnerHits(Elastic.Clients.Elasticsearch.Core.Search.InnerHits? innerHits)
	{
		InnerHitsDescriptor = null;
		InnerHitsDescriptorAction = null;
		InnerHitsValue = innerHits;
		return Self;
	}

	public NestedQueryDescriptor<TDocument> InnerHits(Core.Search.InnerHitsDescriptor<TDocument> descriptor)
	{
		InnerHitsValue = null;
		InnerHitsDescriptorAction = null;
		InnerHitsDescriptor = descriptor;
		return Self;
	}

	public NestedQueryDescriptor<TDocument> InnerHits(Action<Core.Search.InnerHitsDescriptor<TDocument>> configure)
	{
		InnerHitsValue = null;
		InnerHitsDescriptor = null;
		InnerHitsDescriptorAction = configure;
		return Self;
	}

	public NestedQueryDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public NestedQueryDescriptor<TDocument> Query(QueryContainerDescriptor<TDocument> descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public NestedQueryDescriptor<TDocument> Query(Action<QueryContainerDescriptor<TDocument>> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	public NestedQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public NestedQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public NestedQueryDescriptor<TDocument> IgnoreUnmapped(bool? ignoreUnmapped = true)
	{
		IgnoreUnmappedValue = ignoreUnmapped;
		return Self;
	}

	public NestedQueryDescriptor<TDocument> Path(Elastic.Clients.Elasticsearch.Field path)
	{
		PathValue = path;
		return Self;
	}

	public NestedQueryDescriptor<TDocument> Path<TValue>(Expression<Func<TDocument, TValue>> path)
	{
		PathValue = path;
		return Self;
	}

	public NestedQueryDescriptor<TDocument> ScoreMode(Elastic.Clients.Elasticsearch.QueryDsl.ChildScoreMode? scoreMode)
	{
		ScoreModeValue = scoreMode;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (InnerHitsDescriptor is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, InnerHitsDescriptor, options);
		}
		else if (InnerHitsDescriptorAction is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, new Core.Search.InnerHitsDescriptor<TDocument>(InnerHitsDescriptorAction), options);
		}
		else if (InnerHitsValue is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, InnerHitsValue, options);
		}

		if (QueryDescriptor is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryDescriptor, options);
		}
		else if (QueryDescriptorAction is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, new QueryContainerDescriptor<TDocument>(QueryDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (IgnoreUnmappedValue.HasValue)
		{
			writer.WritePropertyName("ignore_unmapped");
			writer.WriteBooleanValue(IgnoreUnmappedValue.Value);
		}

		writer.WritePropertyName("path");
		JsonSerializer.Serialize(writer, PathValue, options);
		if (ScoreModeValue is not null)
		{
			writer.WritePropertyName("score_mode");
			JsonSerializer.Serialize(writer, ScoreModeValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class NestedQueryDescriptor : SerializableDescriptor<NestedQueryDescriptor>
{
	internal NestedQueryDescriptor(Action<NestedQueryDescriptor> configure) => configure.Invoke(this);
	public NestedQueryDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Core.Search.InnerHits? InnerHitsValue { get; set; }

	private Core.Search.InnerHitsDescriptor InnerHitsDescriptor { get; set; }

	private Action<Core.Search.InnerHitsDescriptor> InnerHitsDescriptorAction { get; set; }

	private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer QueryValue { get; set; }

	private QueryContainerDescriptor QueryDescriptor { get; set; }

	private Action<QueryContainerDescriptor> QueryDescriptorAction { get; set; }

	private string? QueryNameValue { get; set; }

	private float? BoostValue { get; set; }

	private bool? IgnoreUnmappedValue { get; set; }

	private Elastic.Clients.Elasticsearch.Field PathValue { get; set; }

	private Elastic.Clients.Elasticsearch.QueryDsl.ChildScoreMode? ScoreModeValue { get; set; }

	public NestedQueryDescriptor InnerHits(Elastic.Clients.Elasticsearch.Core.Search.InnerHits? innerHits)
	{
		InnerHitsDescriptor = null;
		InnerHitsDescriptorAction = null;
		InnerHitsValue = innerHits;
		return Self;
	}

	public NestedQueryDescriptor InnerHits(Core.Search.InnerHitsDescriptor descriptor)
	{
		InnerHitsValue = null;
		InnerHitsDescriptorAction = null;
		InnerHitsDescriptor = descriptor;
		return Self;
	}

	public NestedQueryDescriptor InnerHits(Action<Core.Search.InnerHitsDescriptor> configure)
	{
		InnerHitsValue = null;
		InnerHitsDescriptor = null;
		InnerHitsDescriptorAction = configure;
		return Self;
	}

	public NestedQueryDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public NestedQueryDescriptor Query(QueryContainerDescriptor descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public NestedQueryDescriptor Query(Action<QueryContainerDescriptor> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	public NestedQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public NestedQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public NestedQueryDescriptor IgnoreUnmapped(bool? ignoreUnmapped = true)
	{
		IgnoreUnmappedValue = ignoreUnmapped;
		return Self;
	}

	public NestedQueryDescriptor Path(Elastic.Clients.Elasticsearch.Field path)
	{
		PathValue = path;
		return Self;
	}

	public NestedQueryDescriptor Path<TDocument, TValue>(Expression<Func<TDocument, TValue>> path)
	{
		PathValue = path;
		return Self;
	}

	public NestedQueryDescriptor Path<TDocument>(Expression<Func<TDocument, object>> path)
	{
		PathValue = path;
		return Self;
	}

	public NestedQueryDescriptor ScoreMode(Elastic.Clients.Elasticsearch.QueryDsl.ChildScoreMode? scoreMode)
	{
		ScoreModeValue = scoreMode;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (InnerHitsDescriptor is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, InnerHitsDescriptor, options);
		}
		else if (InnerHitsDescriptorAction is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, new Core.Search.InnerHitsDescriptor(InnerHitsDescriptorAction), options);
		}
		else if (InnerHitsValue is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, InnerHitsValue, options);
		}

		if (QueryDescriptor is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryDescriptor, options);
		}
		else if (QueryDescriptorAction is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, new QueryContainerDescriptor(QueryDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (IgnoreUnmappedValue.HasValue)
		{
			writer.WritePropertyName("ignore_unmapped");
			writer.WriteBooleanValue(IgnoreUnmappedValue.Value);
		}

		writer.WritePropertyName("path");
		JsonSerializer.Serialize(writer, PathValue, options);
		if (ScoreModeValue is not null)
		{
			writer.WritePropertyName("score_mode");
			JsonSerializer.Serialize(writer, ScoreModeValue, options);
		}

		writer.WriteEndObject();
	}
}