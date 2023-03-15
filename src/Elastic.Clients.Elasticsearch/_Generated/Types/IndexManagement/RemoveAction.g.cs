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
namespace Elastic.Clients.Elasticsearch.IndexManagement;
public sealed partial class RemoveAction
{
	[JsonInclude, JsonPropertyName("alias")]
	public Elastic.Clients.Elasticsearch.IndexAlias? Alias { get; set; }

	[JsonInclude, JsonPropertyName("aliases"), SingleOrManyCollectionConverter(typeof(Elastic.Clients.Elasticsearch.IndexAlias))]
	public ICollection<Elastic.Clients.Elasticsearch.IndexAlias>? Aliases { get; set; }

	[JsonInclude, JsonPropertyName("index")]
	public Elastic.Clients.Elasticsearch.IndexName? Index { get; set; }

	[JsonInclude, JsonPropertyName("indices")]
	public Elastic.Clients.Elasticsearch.Indices? Indices { get; set; }

	[JsonInclude, JsonPropertyName("must_exist")]
	public bool? MustExist { get; set; }

	public static implicit operator Action(RemoveAction removeAction) => IndexManagement.Action.Remove(removeAction);
}

public sealed partial class RemoveActionDescriptor : SerializableDescriptor<RemoveActionDescriptor>
{
	internal RemoveActionDescriptor(Action<RemoveActionDescriptor> configure) => configure.Invoke(this);
	public RemoveActionDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.IndexAlias? AliasValue { get; set; }

	private ICollection<Elastic.Clients.Elasticsearch.IndexAlias>? AliasesValue { get; set; }

	private Elastic.Clients.Elasticsearch.IndexName? IndexValue { get; set; }

	private Elastic.Clients.Elasticsearch.Indices? IndicesValue { get; set; }

	private bool? MustExistValue { get; set; }

	public RemoveActionDescriptor Alias(Elastic.Clients.Elasticsearch.IndexAlias? alias)
	{
		AliasValue = alias;
		return Self;
	}

	public RemoveActionDescriptor Aliases(ICollection<Elastic.Clients.Elasticsearch.IndexAlias>? aliases)
	{
		AliasesValue = aliases;
		return Self;
	}

	public RemoveActionDescriptor Index(Elastic.Clients.Elasticsearch.IndexName? index)
	{
		IndexValue = index;
		return Self;
	}

	public RemoveActionDescriptor Indices(Elastic.Clients.Elasticsearch.Indices? indices)
	{
		IndicesValue = indices;
		return Self;
	}

	public RemoveActionDescriptor MustExist(bool? mustExist = true)
	{
		MustExistValue = mustExist;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AliasValue is not null)
		{
			writer.WritePropertyName("alias");
			JsonSerializer.Serialize(writer, AliasValue, options);
		}

		if (AliasesValue is not null)
		{
			writer.WritePropertyName("aliases");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.IndexAlias>(AliasesValue, writer, options);
		}

		if (IndexValue is not null)
		{
			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, IndexValue, options);
		}

		if (IndicesValue is not null)
		{
			writer.WritePropertyName("indices");
			JsonSerializer.Serialize(writer, IndicesValue, options);
		}

		if (MustExistValue.HasValue)
		{
			writer.WritePropertyName("must_exist");
			writer.WriteBooleanValue(MustExistValue.Value);
		}

		writer.WriteEndObject();
	}
}