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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ml
{
	public class MlUpdateFilterRequestParameters : RequestParameters<MlUpdateFilterRequestParameters>
	{
	}

	public partial class MlUpdateFilterRequest : PlainRequestBase<MlUpdateFilterRequestParameters>
	{
		public MlUpdateFilterRequest(Elastic.Clients.Elasticsearch.Id filter_id) : base(r => r.Required("filter_id", filter_id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningUpdateFilter;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonInclude]
		[JsonPropertyName("add_items")]
		public IEnumerable<string>? AddItems { get; set; }

		[JsonInclude]
		[JsonPropertyName("description")]
		public string? Description { get; set; }

		[JsonInclude]
		[JsonPropertyName("remove_items")]
		public IEnumerable<string>? RemoveItems { get; set; }
	}

	public sealed partial class MlUpdateFilterRequestDescriptor : RequestDescriptorBase<MlUpdateFilterRequestDescriptor, MlUpdateFilterRequestParameters>
	{
		internal MlUpdateFilterRequestDescriptor(Action<MlUpdateFilterRequestDescriptor> configure) => configure.Invoke(this);
		public MlUpdateFilterRequestDescriptor(Elastic.Clients.Elasticsearch.Id filter_id) : base(r => r.Required("filter_id", filter_id))
		{
		}

		internal MlUpdateFilterRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningUpdateFilter;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		public MlUpdateFilterRequestDescriptor FilterId(Elastic.Clients.Elasticsearch.Id filter_id)
		{
			RouteValues.Required("filter_id", filter_id);
			return Self;
		}

		private IEnumerable<string>? AddItemsValue { get; set; }

		private string? DescriptionValue { get; set; }

		private IEnumerable<string>? RemoveItemsValue { get; set; }

		public MlUpdateFilterRequestDescriptor AddItems(IEnumerable<string>? addItems)
		{
			AddItemsValue = addItems;
			return Self;
		}

		public MlUpdateFilterRequestDescriptor Description(string? description)
		{
			DescriptionValue = description;
			return Self;
		}

		public MlUpdateFilterRequestDescriptor RemoveItems(IEnumerable<string>? removeItems)
		{
			RemoveItemsValue = removeItems;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (AddItemsValue is not null)
			{
				writer.WritePropertyName("add_items");
				JsonSerializer.Serialize(writer, AddItemsValue, options);
			}

			if (!string.IsNullOrEmpty(DescriptionValue))
			{
				writer.WritePropertyName("description");
				writer.WriteStringValue(DescriptionValue);
			}

			if (RemoveItemsValue is not null)
			{
				writer.WritePropertyName("remove_items");
				JsonSerializer.Serialize(writer, RemoveItemsValue, options);
			}

			writer.WriteEndObject();
		}
	}
}