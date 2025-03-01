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

namespace Elastic.Clients.Elasticsearch.Cluster;

public sealed partial class PendingTask
{
	[JsonInclude, JsonPropertyName("executing")]
	public bool Executing { get; init; }
	[JsonInclude, JsonPropertyName("insert_order")]
	public int InsertOrder { get; init; }
	[JsonInclude, JsonPropertyName("priority")]
	public string Priority { get; init; }
	[JsonInclude, JsonPropertyName("source")]
	public string Source { get; init; }
	[JsonInclude, JsonPropertyName("time_in_queue")]
	public Elastic.Clients.Elasticsearch.Duration? TimeInQueue { get; init; }
	[JsonInclude, JsonPropertyName("time_in_queue_millis")]
	public long TimeInQueueMillis { get; init; }
}