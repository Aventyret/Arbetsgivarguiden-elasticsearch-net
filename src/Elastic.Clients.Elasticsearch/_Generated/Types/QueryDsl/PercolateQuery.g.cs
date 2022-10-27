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
public sealed partial class PercolateQuery : Query
{
	[JsonInclude]
	[JsonPropertyName("_name")]
	public string? QueryName { get; set; }

	[JsonInclude]
	[JsonPropertyName("boost")]
	public float? Boost { get; set; }

	[JsonInclude]
	[JsonPropertyName("document")]
	public object? Document { get; set; }

	[JsonInclude]
	[JsonPropertyName("documents")]
	public IList<object>? Documents { get; set; }

	[JsonInclude]
	[JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Field Field { get; set; }

	[JsonInclude]
	[JsonPropertyName("id")]
	public Elastic.Clients.Elasticsearch.Id? Id { get; set; }

	[JsonInclude]
	[JsonPropertyName("index")]
	public Elastic.Clients.Elasticsearch.IndexName? Index { get; set; }

	[JsonInclude]
	[JsonPropertyName("name")]
	public string? Name { get; set; }

	[JsonInclude]
	[JsonPropertyName("preference")]
	public string? Preference { get; set; }

	[JsonInclude]
	[JsonPropertyName("routing")]
	public Elastic.Clients.Elasticsearch.Routing? Routing { get; set; }

	[JsonInclude]
	[JsonPropertyName("version")]
	public long? Version { get; set; }

	public static implicit operator QueryContainer(PercolateQuery percolateQuery) => QueryContainer.Percolate(percolateQuery);
}

public sealed partial class PercolateQueryDescriptor<TDocument> : SerializableDescriptor<PercolateQueryDescriptor<TDocument>>
{
	internal PercolateQueryDescriptor(Action<PercolateQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
	public PercolateQueryDescriptor() : base()
	{
	}

	private string? QueryNameValue { get; set; }

	private float? BoostValue { get; set; }

	private object? DocumentValue { get; set; }

	private IList<object>? DocumentsValue { get; set; }

	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

	private Elastic.Clients.Elasticsearch.Id? IdValue { get; set; }

	private Elastic.Clients.Elasticsearch.IndexName? IndexValue { get; set; }

	private string? NameValue { get; set; }

	private string? PreferenceValue { get; set; }

	private Elastic.Clients.Elasticsearch.Routing? RoutingValue { get; set; }

	private long? VersionValue { get; set; }

	public PercolateQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public PercolateQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public PercolateQueryDescriptor<TDocument> Document(object? document)
	{
		DocumentValue = document;
		return Self;
	}

	public PercolateQueryDescriptor<TDocument> Documents(IList<object>? documents)
	{
		DocumentsValue = documents;
		return Self;
	}

	public PercolateQueryDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public PercolateQueryDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public PercolateQueryDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id? id)
	{
		IdValue = id;
		return Self;
	}

	public PercolateQueryDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.IndexName? index)
	{
		IndexValue = index;
		return Self;
	}

	public PercolateQueryDescriptor<TDocument> Name(string? name)
	{
		NameValue = name;
		return Self;
	}

	public PercolateQueryDescriptor<TDocument> Preference(string? preference)
	{
		PreferenceValue = preference;
		return Self;
	}

	public PercolateQueryDescriptor<TDocument> Routing(Elastic.Clients.Elasticsearch.Routing? routing)
	{
		RoutingValue = routing;
		return Self;
	}

	public PercolateQueryDescriptor<TDocument> Version(long? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
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

		if (DocumentsValue is not null)
		{
			writer.WritePropertyName("documents");
			JsonSerializer.Serialize(writer, DocumentsValue, options);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (IdValue is not null)
		{
			writer.WritePropertyName("id");
			JsonSerializer.Serialize(writer, IdValue, options);
		}

		if (IndexValue is not null)
		{
			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, IndexValue, options);
		}

		if (!string.IsNullOrEmpty(NameValue))
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(NameValue);
		}

		if (!string.IsNullOrEmpty(PreferenceValue))
		{
			writer.WritePropertyName("preference");
			writer.WriteStringValue(PreferenceValue);
		}

		if (RoutingValue is not null)
		{
			writer.WritePropertyName("routing");
			JsonSerializer.Serialize(writer, RoutingValue, options);
		}

		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class PercolateQueryDescriptor : SerializableDescriptor<PercolateQueryDescriptor>
{
	internal PercolateQueryDescriptor(Action<PercolateQueryDescriptor> configure) => configure.Invoke(this);
	public PercolateQueryDescriptor() : base()
	{
	}

	private string? QueryNameValue { get; set; }

	private float? BoostValue { get; set; }

	private object? DocumentValue { get; set; }

	private IList<object>? DocumentsValue { get; set; }

	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

	private Elastic.Clients.Elasticsearch.Id? IdValue { get; set; }

	private Elastic.Clients.Elasticsearch.IndexName? IndexValue { get; set; }

	private string? NameValue { get; set; }

	private string? PreferenceValue { get; set; }

	private Elastic.Clients.Elasticsearch.Routing? RoutingValue { get; set; }

	private long? VersionValue { get; set; }

	public PercolateQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public PercolateQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public PercolateQueryDescriptor Document(object? document)
	{
		DocumentValue = document;
		return Self;
	}

	public PercolateQueryDescriptor Documents(IList<object>? documents)
	{
		DocumentsValue = documents;
		return Self;
	}

	public PercolateQueryDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public PercolateQueryDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public PercolateQueryDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public PercolateQueryDescriptor Id(Elastic.Clients.Elasticsearch.Id? id)
	{
		IdValue = id;
		return Self;
	}

	public PercolateQueryDescriptor Index(Elastic.Clients.Elasticsearch.IndexName? index)
	{
		IndexValue = index;
		return Self;
	}

	public PercolateQueryDescriptor Name(string? name)
	{
		NameValue = name;
		return Self;
	}

	public PercolateQueryDescriptor Preference(string? preference)
	{
		PreferenceValue = preference;
		return Self;
	}

	public PercolateQueryDescriptor Routing(Elastic.Clients.Elasticsearch.Routing? routing)
	{
		RoutingValue = routing;
		return Self;
	}

	public PercolateQueryDescriptor Version(long? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
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

		if (DocumentsValue is not null)
		{
			writer.WritePropertyName("documents");
			JsonSerializer.Serialize(writer, DocumentsValue, options);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (IdValue is not null)
		{
			writer.WritePropertyName("id");
			JsonSerializer.Serialize(writer, IdValue, options);
		}

		if (IndexValue is not null)
		{
			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, IndexValue, options);
		}

		if (!string.IsNullOrEmpty(NameValue))
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(NameValue);
		}

		if (!string.IsNullOrEmpty(PreferenceValue))
		{
			writer.WritePropertyName("preference");
			writer.WriteStringValue(PreferenceValue);
		}

		if (RoutingValue is not null)
		{
			writer.WritePropertyName("routing");
			JsonSerializer.Serialize(writer, RoutingValue, options);
		}

		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}
}