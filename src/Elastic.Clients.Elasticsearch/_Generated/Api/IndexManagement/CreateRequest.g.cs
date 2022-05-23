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
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public sealed class CreateRequestParameters : RequestParameters<CreateRequestParameters>
	{
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }
	}

	public partial class CreateRequest : PlainRequestBase<CreateRequestParameters>
	{
		public CreateRequest(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementCreate;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

		[JsonInclude]
		[JsonPropertyName("aliases")]
		public Dictionary<Elastic.Clients.Elasticsearch.Name, Elastic.Clients.Elasticsearch.IndexManagement.Alias>? Aliases { get; set; }

		[JsonInclude]
		[JsonPropertyName("mappings")]
		public Elastic.Clients.Elasticsearch.Mapping.TypeMapping? Mappings { get; set; }

		[JsonInclude]
		[JsonPropertyName("settings")]
		public Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? Settings { get; set; }
	}

	public sealed partial class CreateRequestDescriptor<TDocument> : RequestDescriptorBase<CreateRequestDescriptor<TDocument>, CreateRequestParameters>
	{
		internal CreateRequestDescriptor(Action<CreateRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
		public CreateRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
		{
		}

		public CreateRequestDescriptor(TDocument document) : this(typeof(TDocument))
		{
		}

		internal CreateRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementCreate;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		public CreateRequestDescriptor<TDocument> MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public CreateRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
		public CreateRequestDescriptor<TDocument> WaitForActiveShards(Elastic.Clients.Elasticsearch.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);
		public CreateRequestDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.IndexName index)
		{
			RouteValues.Required("index", index);
			return Self;
		}

		private Elastic.Clients.Elasticsearch.Mapping.TypeMapping? MappingsValue { get; set; }

		private Mapping.TypeMappingDescriptor<TDocument> MappingsDescriptor { get; set; }

		private Action<Mapping.TypeMappingDescriptor<TDocument>> MappingsDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? SettingsValue { get; set; }

		private IndexSettingsDescriptor<TDocument> SettingsDescriptor { get; set; }

		private Action<IndexSettingsDescriptor<TDocument>> SettingsDescriptorAction { get; set; }

		private Dictionary<Elastic.Clients.Elasticsearch.Name, Elastic.Clients.Elasticsearch.IndexManagement.Alias>? AliasesValue { get; set; }

		public CreateRequestDescriptor<TDocument> Mappings(Elastic.Clients.Elasticsearch.Mapping.TypeMapping? mappings)
		{
			MappingsDescriptor = null;
			MappingsDescriptorAction = null;
			MappingsValue = mappings;
			return Self;
		}

		public CreateRequestDescriptor<TDocument> Mappings(Mapping.TypeMappingDescriptor<TDocument> descriptor)
		{
			MappingsValue = null;
			MappingsDescriptorAction = null;
			MappingsDescriptor = descriptor;
			return Self;
		}

		public CreateRequestDescriptor<TDocument> Mappings(Action<Mapping.TypeMappingDescriptor<TDocument>> configure)
		{
			MappingsValue = null;
			MappingsDescriptor = null;
			MappingsDescriptorAction = configure;
			return Self;
		}

		public CreateRequestDescriptor<TDocument> Settings(Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? settings)
		{
			SettingsDescriptor = null;
			SettingsDescriptorAction = null;
			SettingsValue = settings;
			return Self;
		}

		public CreateRequestDescriptor<TDocument> Settings(IndexSettingsDescriptor<TDocument> descriptor)
		{
			SettingsValue = null;
			SettingsDescriptorAction = null;
			SettingsDescriptor = descriptor;
			return Self;
		}

		public CreateRequestDescriptor<TDocument> Settings(Action<IndexSettingsDescriptor<TDocument>> configure)
		{
			SettingsValue = null;
			SettingsDescriptor = null;
			SettingsDescriptorAction = configure;
			return Self;
		}

		public CreateRequestDescriptor<TDocument> Aliases(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Name, Elastic.Clients.Elasticsearch.IndexManagement.Alias>, FluentDictionary<Elastic.Clients.Elasticsearch.Name, Elastic.Clients.Elasticsearch.IndexManagement.Alias>> selector)
		{
			AliasesValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Name, Elastic.Clients.Elasticsearch.IndexManagement.Alias>());
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (MappingsDescriptor is not null)
			{
				writer.WritePropertyName("mappings");
				JsonSerializer.Serialize(writer, MappingsDescriptor, options);
			}
			else if (MappingsDescriptorAction is not null)
			{
				writer.WritePropertyName("mappings");
				JsonSerializer.Serialize(writer, new Mapping.TypeMappingDescriptor<TDocument>(MappingsDescriptorAction), options);
			}
			else if (MappingsValue is not null)
			{
				writer.WritePropertyName("mappings");
				JsonSerializer.Serialize(writer, MappingsValue, options);
			}

			if (SettingsDescriptor is not null)
			{
				writer.WritePropertyName("settings");
				JsonSerializer.Serialize(writer, SettingsDescriptor, options);
			}
			else if (SettingsDescriptorAction is not null)
			{
				writer.WritePropertyName("settings");
				JsonSerializer.Serialize(writer, new IndexSettingsDescriptor<TDocument>(SettingsDescriptorAction), options);
			}
			else if (SettingsValue is not null)
			{
				writer.WritePropertyName("settings");
				JsonSerializer.Serialize(writer, SettingsValue, options);
			}

			if (AliasesValue is not null)
			{
				writer.WritePropertyName("aliases");
				JsonSerializer.Serialize(writer, AliasesValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class CreateRequestDescriptor : RequestDescriptorBase<CreateRequestDescriptor, CreateRequestParameters>
	{
		internal CreateRequestDescriptor(Action<CreateRequestDescriptor> configure) => configure.Invoke(this);
		public CreateRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
		{
		}

		internal CreateRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementCreate;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		public CreateRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public CreateRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
		public CreateRequestDescriptor WaitForActiveShards(Elastic.Clients.Elasticsearch.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);
		public CreateRequestDescriptor Index(Elastic.Clients.Elasticsearch.IndexName index)
		{
			RouteValues.Required("index", index);
			return Self;
		}

		private Elastic.Clients.Elasticsearch.Mapping.TypeMapping? MappingsValue { get; set; }

		private Mapping.TypeMappingDescriptor MappingsDescriptor { get; set; }

		private Action<Mapping.TypeMappingDescriptor> MappingsDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? SettingsValue { get; set; }

		private IndexSettingsDescriptor SettingsDescriptor { get; set; }

		private Action<IndexSettingsDescriptor> SettingsDescriptorAction { get; set; }

		private Dictionary<Elastic.Clients.Elasticsearch.Name, Elastic.Clients.Elasticsearch.IndexManagement.Alias>? AliasesValue { get; set; }

		public CreateRequestDescriptor Mappings(Elastic.Clients.Elasticsearch.Mapping.TypeMapping? mappings)
		{
			MappingsDescriptor = null;
			MappingsDescriptorAction = null;
			MappingsValue = mappings;
			return Self;
		}

		public CreateRequestDescriptor Mappings(Mapping.TypeMappingDescriptor descriptor)
		{
			MappingsValue = null;
			MappingsDescriptorAction = null;
			MappingsDescriptor = descriptor;
			return Self;
		}

		public CreateRequestDescriptor Mappings(Action<Mapping.TypeMappingDescriptor> configure)
		{
			MappingsValue = null;
			MappingsDescriptor = null;
			MappingsDescriptorAction = configure;
			return Self;
		}

		public CreateRequestDescriptor Settings(Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? settings)
		{
			SettingsDescriptor = null;
			SettingsDescriptorAction = null;
			SettingsValue = settings;
			return Self;
		}

		public CreateRequestDescriptor Settings(IndexSettingsDescriptor descriptor)
		{
			SettingsValue = null;
			SettingsDescriptorAction = null;
			SettingsDescriptor = descriptor;
			return Self;
		}

		public CreateRequestDescriptor Settings(Action<IndexSettingsDescriptor> configure)
		{
			SettingsValue = null;
			SettingsDescriptor = null;
			SettingsDescriptorAction = configure;
			return Self;
		}

		public CreateRequestDescriptor Aliases(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Name, Elastic.Clients.Elasticsearch.IndexManagement.Alias>, FluentDictionary<Elastic.Clients.Elasticsearch.Name, Elastic.Clients.Elasticsearch.IndexManagement.Alias>> selector)
		{
			AliasesValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Name, Elastic.Clients.Elasticsearch.IndexManagement.Alias>());
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (MappingsDescriptor is not null)
			{
				writer.WritePropertyName("mappings");
				JsonSerializer.Serialize(writer, MappingsDescriptor, options);
			}
			else if (MappingsDescriptorAction is not null)
			{
				writer.WritePropertyName("mappings");
				JsonSerializer.Serialize(writer, new Mapping.TypeMappingDescriptor(MappingsDescriptorAction), options);
			}
			else if (MappingsValue is not null)
			{
				writer.WritePropertyName("mappings");
				JsonSerializer.Serialize(writer, MappingsValue, options);
			}

			if (SettingsDescriptor is not null)
			{
				writer.WritePropertyName("settings");
				JsonSerializer.Serialize(writer, SettingsDescriptor, options);
			}
			else if (SettingsDescriptorAction is not null)
			{
				writer.WritePropertyName("settings");
				JsonSerializer.Serialize(writer, new IndexSettingsDescriptor(SettingsDescriptorAction), options);
			}
			else if (SettingsValue is not null)
			{
				writer.WritePropertyName("settings");
				JsonSerializer.Serialize(writer, SettingsValue, options);
			}

			if (AliasesValue is not null)
			{
				writer.WritePropertyName("aliases");
				JsonSerializer.Serialize(writer, AliasesValue, options);
			}

			writer.WriteEndObject();
		}
	}
}