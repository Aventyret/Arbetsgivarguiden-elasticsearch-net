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
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	internal sealed class CumulativeCardinalityAggregationConverter : JsonConverter<CumulativeCardinalityAggregation>
	{
		public override CumulativeCardinalityAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			reader.Read();
			var aggName = reader.GetString();
			if (aggName != "cumulative_cardinality")
				throw new JsonException("Unexpected JSON detected.");
			var agg = new CumulativeCardinalityAggregation(aggName);
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("format"))
					{
						reader.Read();
						var value = JsonSerializer.Deserialize<string?>(ref reader, options);
						if (value is not null)
						{
							agg.Format = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("gap_policy"))
					{
						reader.Read();
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.GapPolicy?>(ref reader, options);
						if (value is not null)
						{
							agg.GapPolicy = value;
						}

						continue;
					}
				}
			}

			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("meta"))
					{
						var value = JsonSerializer.Deserialize<Dictionary<string, object>>(ref reader, options);
						if (value is not null)
						{
							agg.Meta = value;
						}

						continue;
					}
				}
			}

			return agg;
		}

		public override void Write(Utf8JsonWriter writer, CumulativeCardinalityAggregation value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("cumulative_cardinality");
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(value.Format))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(value.Format);
			}

			if (value.GapPolicy is not null)
			{
				writer.WritePropertyName("gap_policy");
				JsonSerializer.Serialize(writer, value.GapPolicy, options);
			}

			writer.WriteEndObject();
			if (value.Meta is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, value.Meta, options);
			}

			writer.WriteEndObject();
		}
	}

	[JsonConverter(typeof(CumulativeCardinalityAggregationConverter))]
	public sealed partial class CumulativeCardinalityAggregation : Aggregation
	{
		public CumulativeCardinalityAggregation(string name) => Name = name;
		internal CumulativeCardinalityAggregation()
		{
		}

		public string? Format { get; set; }

		public Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? GapPolicy { get; set; }

		public Dictionary<string, object>? Meta { get; set; }

		public override string? Name { get; internal set; }
	}

	public sealed partial class CumulativeCardinalityAggregationDescriptor : SerializableDescriptorBase<CumulativeCardinalityAggregationDescriptor>
	{
		internal CumulativeCardinalityAggregationDescriptor(Action<CumulativeCardinalityAggregationDescriptor> configure) => configure.Invoke(this);
		public CumulativeCardinalityAggregationDescriptor() : base()
		{
		}

		private string? FormatValue { get; set; }

		private Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? GapPolicyValue { get; set; }

		private Dictionary<string, object>? MetaValue { get; set; }

		public CumulativeCardinalityAggregationDescriptor Format(string? format)
		{
			FormatValue = format;
			return Self;
		}

		public CumulativeCardinalityAggregationDescriptor GapPolicy(Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? gapPolicy)
		{
			GapPolicyValue = gapPolicy;
			return Self;
		}

		public CumulativeCardinalityAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("cumulative_cardinality");
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(FormatValue))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(FormatValue);
			}

			if (GapPolicyValue is not null)
			{
				writer.WritePropertyName("gap_policy");
				JsonSerializer.Serialize(writer, GapPolicyValue, options);
			}

			writer.WriteEndObject();
			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			writer.WriteEndObject();
		}
	}
}