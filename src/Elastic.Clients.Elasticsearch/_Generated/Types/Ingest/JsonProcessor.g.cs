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
namespace Elastic.Clients.Elasticsearch.Ingest;
public sealed partial class JsonProcessor
{
	[JsonInclude, JsonPropertyName("add_to_root")]
	public bool? AddToRoot { get; set; }

	[JsonInclude, JsonPropertyName("add_to_root_conflict_strategy")]
	public Elastic.Clients.Elasticsearch.Ingest.JsonProcessorConflictStrategy? AddToRootConflictStrategy { get; set; }

	[JsonInclude, JsonPropertyName("allow_duplicate_keys")]
	public bool? AllowDuplicateKeys { get; set; }

	[JsonInclude, JsonPropertyName("description")]
	public string? Description { get; set; }

	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Field Field { get; set; }

	[JsonInclude, JsonPropertyName("if")]
	public string? If { get; set; }

	[JsonInclude, JsonPropertyName("ignore_failure")]
	public bool? IgnoreFailure { get; set; }

	[JsonInclude, JsonPropertyName("on_failure")]
	public ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailure { get; set; }

	[JsonInclude, JsonPropertyName("tag")]
	public string? Tag { get; set; }

	[JsonInclude, JsonPropertyName("target_field")]
	public Elastic.Clients.Elasticsearch.Field? TargetField { get; set; }

	public static implicit operator Processor(JsonProcessor jsonProcessor) => Ingest.Processor.Json(jsonProcessor);
}

public sealed partial class JsonProcessorDescriptor<TDocument> : SerializableDescriptor<JsonProcessorDescriptor<TDocument>>
{
	internal JsonProcessorDescriptor(Action<JsonProcessorDescriptor<TDocument>> configure) => configure.Invoke(this);
	public JsonProcessorDescriptor() : base()
	{
	}

	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailureValue { get; set; }

	private ProcessorDescriptor<TDocument> OnFailureDescriptor { get; set; }

	private Action<ProcessorDescriptor<TDocument>> OnFailureDescriptorAction { get; set; }

	private Action<ProcessorDescriptor<TDocument>>[] OnFailureDescriptorActions { get; set; }

	private bool? AddToRootValue { get; set; }

	private Elastic.Clients.Elasticsearch.Ingest.JsonProcessorConflictStrategy? AddToRootConflictStrategyValue { get; set; }

	private bool? AllowDuplicateKeysValue { get; set; }

	private string? DescriptionValue { get; set; }

	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

	private string? IfValue { get; set; }

	private bool? IgnoreFailureValue { get; set; }

	private string? TagValue { get; set; }

	private Elastic.Clients.Elasticsearch.Field? TargetFieldValue { get; set; }

	public JsonProcessorDescriptor<TDocument> OnFailure(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public JsonProcessorDescriptor<TDocument> OnFailure(ProcessorDescriptor<TDocument> descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public JsonProcessorDescriptor<TDocument> OnFailure(Action<ProcessorDescriptor<TDocument>> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public JsonProcessorDescriptor<TDocument> OnFailure(params Action<ProcessorDescriptor<TDocument>>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	public JsonProcessorDescriptor<TDocument> AddToRoot(bool? addToRoot = true)
	{
		AddToRootValue = addToRoot;
		return Self;
	}

	public JsonProcessorDescriptor<TDocument> AddToRootConflictStrategy(Elastic.Clients.Elasticsearch.Ingest.JsonProcessorConflictStrategy? addToRootConflictStrategy)
	{
		AddToRootConflictStrategyValue = addToRootConflictStrategy;
		return Self;
	}

	public JsonProcessorDescriptor<TDocument> AllowDuplicateKeys(bool? allowDuplicateKeys = true)
	{
		AllowDuplicateKeysValue = allowDuplicateKeys;
		return Self;
	}

	public JsonProcessorDescriptor<TDocument> Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	public JsonProcessorDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public JsonProcessorDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public JsonProcessorDescriptor<TDocument> If(string? ifValue)
	{
		IfValue = ifValue;
		return Self;
	}

	public JsonProcessorDescriptor<TDocument> IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	public JsonProcessorDescriptor<TDocument> Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	public JsonProcessorDescriptor<TDocument> TargetField(Elastic.Clients.Elasticsearch.Field? targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	public JsonProcessorDescriptor<TDocument> TargetField<TValue>(Expression<Func<TDocument, TValue>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (OnFailureDescriptor is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, OnFailureDescriptor, options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorAction is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new ProcessorDescriptor<TDocument>(OnFailureDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorActions is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			foreach (var action in OnFailureDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new ProcessorDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else if (OnFailureValue is not null)
		{
			writer.WritePropertyName("on_failure");
			JsonSerializer.Serialize(writer, OnFailureValue, options);
		}

		if (AddToRootValue.HasValue)
		{
			writer.WritePropertyName("add_to_root");
			writer.WriteBooleanValue(AddToRootValue.Value);
		}

		if (AddToRootConflictStrategyValue is not null)
		{
			writer.WritePropertyName("add_to_root_conflict_strategy");
			JsonSerializer.Serialize(writer, AddToRootConflictStrategyValue, options);
		}

		if (AllowDuplicateKeysValue.HasValue)
		{
			writer.WritePropertyName("allow_duplicate_keys");
			writer.WriteBooleanValue(AllowDuplicateKeysValue.Value);
		}

		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (!string.IsNullOrEmpty(IfValue))
		{
			writer.WritePropertyName("if");
			writer.WriteStringValue(IfValue);
		}

		if (IgnoreFailureValue.HasValue)
		{
			writer.WritePropertyName("ignore_failure");
			writer.WriteBooleanValue(IgnoreFailureValue.Value);
		}

		if (!string.IsNullOrEmpty(TagValue))
		{
			writer.WritePropertyName("tag");
			writer.WriteStringValue(TagValue);
		}

		if (TargetFieldValue is not null)
		{
			writer.WritePropertyName("target_field");
			JsonSerializer.Serialize(writer, TargetFieldValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class JsonProcessorDescriptor : SerializableDescriptor<JsonProcessorDescriptor>
{
	internal JsonProcessorDescriptor(Action<JsonProcessorDescriptor> configure) => configure.Invoke(this);
	public JsonProcessorDescriptor() : base()
	{
	}

	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailureValue { get; set; }

	private ProcessorDescriptor OnFailureDescriptor { get; set; }

	private Action<ProcessorDescriptor> OnFailureDescriptorAction { get; set; }

	private Action<ProcessorDescriptor>[] OnFailureDescriptorActions { get; set; }

	private bool? AddToRootValue { get; set; }

	private Elastic.Clients.Elasticsearch.Ingest.JsonProcessorConflictStrategy? AddToRootConflictStrategyValue { get; set; }

	private bool? AllowDuplicateKeysValue { get; set; }

	private string? DescriptionValue { get; set; }

	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

	private string? IfValue { get; set; }

	private bool? IgnoreFailureValue { get; set; }

	private string? TagValue { get; set; }

	private Elastic.Clients.Elasticsearch.Field? TargetFieldValue { get; set; }

	public JsonProcessorDescriptor OnFailure(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public JsonProcessorDescriptor OnFailure(ProcessorDescriptor descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public JsonProcessorDescriptor OnFailure(Action<ProcessorDescriptor> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public JsonProcessorDescriptor OnFailure(params Action<ProcessorDescriptor>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	public JsonProcessorDescriptor AddToRoot(bool? addToRoot = true)
	{
		AddToRootValue = addToRoot;
		return Self;
	}

	public JsonProcessorDescriptor AddToRootConflictStrategy(Elastic.Clients.Elasticsearch.Ingest.JsonProcessorConflictStrategy? addToRootConflictStrategy)
	{
		AddToRootConflictStrategyValue = addToRootConflictStrategy;
		return Self;
	}

	public JsonProcessorDescriptor AllowDuplicateKeys(bool? allowDuplicateKeys = true)
	{
		AllowDuplicateKeysValue = allowDuplicateKeys;
		return Self;
	}

	public JsonProcessorDescriptor Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	public JsonProcessorDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public JsonProcessorDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public JsonProcessorDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public JsonProcessorDescriptor If(string? ifValue)
	{
		IfValue = ifValue;
		return Self;
	}

	public JsonProcessorDescriptor IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	public JsonProcessorDescriptor Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	public JsonProcessorDescriptor TargetField(Elastic.Clients.Elasticsearch.Field? targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	public JsonProcessorDescriptor TargetField<TDocument, TValue>(Expression<Func<TDocument, TValue>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	public JsonProcessorDescriptor TargetField<TDocument>(Expression<Func<TDocument, object>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (OnFailureDescriptor is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, OnFailureDescriptor, options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorAction is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new ProcessorDescriptor(OnFailureDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorActions is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			foreach (var action in OnFailureDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new ProcessorDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (OnFailureValue is not null)
		{
			writer.WritePropertyName("on_failure");
			JsonSerializer.Serialize(writer, OnFailureValue, options);
		}

		if (AddToRootValue.HasValue)
		{
			writer.WritePropertyName("add_to_root");
			writer.WriteBooleanValue(AddToRootValue.Value);
		}

		if (AddToRootConflictStrategyValue is not null)
		{
			writer.WritePropertyName("add_to_root_conflict_strategy");
			JsonSerializer.Serialize(writer, AddToRootConflictStrategyValue, options);
		}

		if (AllowDuplicateKeysValue.HasValue)
		{
			writer.WritePropertyName("allow_duplicate_keys");
			writer.WriteBooleanValue(AllowDuplicateKeysValue.Value);
		}

		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (!string.IsNullOrEmpty(IfValue))
		{
			writer.WritePropertyName("if");
			writer.WriteStringValue(IfValue);
		}

		if (IgnoreFailureValue.HasValue)
		{
			writer.WritePropertyName("ignore_failure");
			writer.WriteBooleanValue(IgnoreFailureValue.Value);
		}

		if (!string.IsNullOrEmpty(TagValue))
		{
			writer.WritePropertyName("tag");
			writer.WriteStringValue(TagValue);
		}

		if (TargetFieldValue is not null)
		{
			writer.WritePropertyName("target_field");
			JsonSerializer.Serialize(writer, TargetFieldValue, options);
		}

		writer.WriteEndObject();
	}
}