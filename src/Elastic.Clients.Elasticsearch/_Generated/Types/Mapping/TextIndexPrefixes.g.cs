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
namespace Elastic.Clients.Elasticsearch.Mapping;
public sealed partial class TextIndexPrefixes
{
	[JsonInclude, JsonPropertyName("max_chars")]
	public int MaxChars { get; set; }

	[JsonInclude, JsonPropertyName("min_chars")]
	public int MinChars { get; set; }
}

public sealed partial class TextIndexPrefixesDescriptor : SerializableDescriptor<TextIndexPrefixesDescriptor>, IBuildableDescriptor<TextIndexPrefixes>
{
	internal TextIndexPrefixesDescriptor(Action<TextIndexPrefixesDescriptor> configure) => configure.Invoke(this);
	public TextIndexPrefixesDescriptor() : base()
	{
	}

	private int MaxCharsValue { get; set; }

	private int MinCharsValue { get; set; }

	public TextIndexPrefixesDescriptor MaxChars(int maxChars)
	{
		MaxCharsValue = maxChars;
		return Self;
	}

	public TextIndexPrefixesDescriptor MinChars(int minChars)
	{
		MinCharsValue = minChars;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("max_chars");
		writer.WriteNumberValue(MaxCharsValue);
		writer.WritePropertyName("min_chars");
		writer.WriteNumberValue(MinCharsValue);
		writer.WriteEndObject();
	}

	TextIndexPrefixes IBuildableDescriptor<TextIndexPrefixes>.Build() => new()
	{
		MaxChars = MaxCharsValue,
		MinChars = MinCharsValue
	};
}