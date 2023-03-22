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

namespace Elastic.Clients.Elasticsearch.IndexManagement;

public sealed partial class IndexSettingsLifecycleStep
{
	/// <summary>
	/// <para>Time to wait for the cluster to resolve allocation issues during an ILM shrink action. Must be greater than 1h (1 hour).<br/>See Shard allocation for shrink.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("wait_time_threshold")]
	public Elastic.Clients.Elasticsearch.Duration? WaitTimeThreshold { get; set; }
}

public sealed partial class IndexSettingsLifecycleStepDescriptor : SerializableDescriptor<IndexSettingsLifecycleStepDescriptor>
{
	internal IndexSettingsLifecycleStepDescriptor(Action<IndexSettingsLifecycleStepDescriptor> configure) => configure.Invoke(this);

	public IndexSettingsLifecycleStepDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Duration? WaitTimeThresholdValue { get; set; }

	/// <summary>
	/// <para>Time to wait for the cluster to resolve allocation issues during an ILM shrink action. Must be greater than 1h (1 hour).<br/>See Shard allocation for shrink.</para>
	/// </summary>
	public IndexSettingsLifecycleStepDescriptor WaitTimeThreshold(Elastic.Clients.Elasticsearch.Duration? waitTimeThreshold)
	{
		WaitTimeThresholdValue = waitTimeThreshold;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (WaitTimeThresholdValue is not null)
		{
			writer.WritePropertyName("wait_time_threshold");
			JsonSerializer.Serialize(writer, WaitTimeThresholdValue, options);
		}

		writer.WriteEndObject();
	}
}