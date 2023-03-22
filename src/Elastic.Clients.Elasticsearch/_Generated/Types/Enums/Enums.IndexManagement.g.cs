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

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using Elastic.Transport;
using Elastic.Clients.Elasticsearch.Serialization;

namespace Elastic.Clients.Elasticsearch.IndexManagement;

[JsonConverter(typeof(FeatureConverter))]
public enum Feature
{
	[EnumMember(Value = "settings")]
	Settings,
	[EnumMember(Value = "mappings")]
	Mappings,
	[EnumMember(Value = "aliases")]
	Aliases
}

internal sealed class FeatureConverter : JsonConverter<Feature>
{
	public override Feature Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "settings":
				return Feature.Settings;
			case "mappings":
				return Feature.Mappings;
			case "aliases":
				return Feature.Aliases;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, Feature value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case Feature.Settings:
				writer.WriteStringValue("settings");
				return;
			case Feature.Mappings:
				writer.WriteStringValue("mappings");
				return;
			case Feature.Aliases:
				writer.WriteStringValue("aliases");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(IndexCheckOnStartupConverter))]
public enum IndexCheckOnStartup
{
	[EnumMember(Value = "true")]
	True,
	[EnumMember(Value = "false")]
	False,
	[EnumMember(Value = "checksum")]
	Checksum
}

internal sealed class IndexCheckOnStartupConverter : JsonConverter<IndexCheckOnStartup>
{
	public override IndexCheckOnStartup Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "true":
				return IndexCheckOnStartup.True;
			case "false":
				return IndexCheckOnStartup.False;
			case "checksum":
				return IndexCheckOnStartup.Checksum;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, IndexCheckOnStartup value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case IndexCheckOnStartup.True:
				writer.WriteStringValue("true");
				return;
			case IndexCheckOnStartup.False:
				writer.WriteStringValue("false");
				return;
			case IndexCheckOnStartup.Checksum:
				writer.WriteStringValue("checksum");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(IndexMetadataStateConverter))]
public enum IndexMetadataState
{
	[EnumMember(Value = "open")]
	Open,
	[EnumMember(Value = "close")]
	Close
}

internal sealed class IndexMetadataStateConverter : JsonConverter<IndexMetadataState>
{
	public override IndexMetadataState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "open":
				return IndexMetadataState.Open;
			case "close":
				return IndexMetadataState.Close;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, IndexMetadataState value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case IndexMetadataState.Open:
				writer.WriteStringValue("open");
				return;
			case IndexMetadataState.Close:
				writer.WriteStringValue("close");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(IndexRoutingAllocationOptionsConverter))]
public enum IndexRoutingAllocationOptions
{
	[EnumMember(Value = "primaries")]
	Primaries,
	[EnumMember(Value = "none")]
	None,
	[EnumMember(Value = "new_primaries")]
	NewPrimaries,
	[EnumMember(Value = "all")]
	All
}

internal sealed class IndexRoutingAllocationOptionsConverter : JsonConverter<IndexRoutingAllocationOptions>
{
	public override IndexRoutingAllocationOptions Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "primaries":
				return IndexRoutingAllocationOptions.Primaries;
			case "none":
				return IndexRoutingAllocationOptions.None;
			case "new_primaries":
				return IndexRoutingAllocationOptions.NewPrimaries;
			case "all":
				return IndexRoutingAllocationOptions.All;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, IndexRoutingAllocationOptions value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case IndexRoutingAllocationOptions.Primaries:
				writer.WriteStringValue("primaries");
				return;
			case IndexRoutingAllocationOptions.None:
				writer.WriteStringValue("none");
				return;
			case IndexRoutingAllocationOptions.NewPrimaries:
				writer.WriteStringValue("new_primaries");
				return;
			case IndexRoutingAllocationOptions.All:
				writer.WriteStringValue("all");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(IndexRoutingRebalanceOptionsConverter))]
public enum IndexRoutingRebalanceOptions
{
	[EnumMember(Value = "replicas")]
	Replicas,
	[EnumMember(Value = "primaries")]
	Primaries,
	[EnumMember(Value = "none")]
	None,
	[EnumMember(Value = "all")]
	All
}

internal sealed class IndexRoutingRebalanceOptionsConverter : JsonConverter<IndexRoutingRebalanceOptions>
{
	public override IndexRoutingRebalanceOptions Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "replicas":
				return IndexRoutingRebalanceOptions.Replicas;
			case "primaries":
				return IndexRoutingRebalanceOptions.Primaries;
			case "none":
				return IndexRoutingRebalanceOptions.None;
			case "all":
				return IndexRoutingRebalanceOptions.All;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, IndexRoutingRebalanceOptions value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case IndexRoutingRebalanceOptions.Replicas:
				writer.WriteStringValue("replicas");
				return;
			case IndexRoutingRebalanceOptions.Primaries:
				writer.WriteStringValue("primaries");
				return;
			case IndexRoutingRebalanceOptions.None:
				writer.WriteStringValue("none");
				return;
			case IndexRoutingRebalanceOptions.All:
				writer.WriteStringValue("all");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(NumericFielddataFormatConverter))]
public enum NumericFielddataFormat
{
	[EnumMember(Value = "disabled")]
	Disabled,
	[EnumMember(Value = "array")]
	Array
}

internal sealed class NumericFielddataFormatConverter : JsonConverter<NumericFielddataFormat>
{
	public override NumericFielddataFormat Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "disabled":
				return NumericFielddataFormat.Disabled;
			case "array":
				return NumericFielddataFormat.Array;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, NumericFielddataFormat value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case NumericFielddataFormat.Disabled:
				writer.WriteStringValue("disabled");
				return;
			case NumericFielddataFormat.Array:
				writer.WriteStringValue("array");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(SegmentSortMissingConverter))]
public enum SegmentSortMissing
{
	[EnumMember(Value = "_last")]
	Last,
	[EnumMember(Value = "_first")]
	First
}

internal sealed class SegmentSortMissingConverter : JsonConverter<SegmentSortMissing>
{
	public override SegmentSortMissing Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "_last":
				return SegmentSortMissing.Last;
			case "_first":
				return SegmentSortMissing.First;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, SegmentSortMissing value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case SegmentSortMissing.Last:
				writer.WriteStringValue("_last");
				return;
			case SegmentSortMissing.First:
				writer.WriteStringValue("_first");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(SegmentSortModeConverter))]
public enum SegmentSortMode
{
	[EnumMember(Value = "min")]
	Min,
	[EnumMember(Value = "max")]
	Max
}

internal sealed class SegmentSortModeConverter : JsonConverter<SegmentSortMode>
{
	public override SegmentSortMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "min":
			case "MIN":
				return SegmentSortMode.Min;
			case "max":
			case "MAX":
				return SegmentSortMode.Max;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, SegmentSortMode value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case SegmentSortMode.Min:
				writer.WriteStringValue("min");
				return;
			case SegmentSortMode.Max:
				writer.WriteStringValue("max");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(SegmentSortOrderConverter))]
public enum SegmentSortOrder
{
	[EnumMember(Value = "desc")]
	Desc,
	[EnumMember(Value = "asc")]
	Asc
}

internal sealed class SegmentSortOrderConverter : JsonConverter<SegmentSortOrder>
{
	public override SegmentSortOrder Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "desc":
			case "DESC":
				return SegmentSortOrder.Desc;
			case "asc":
			case "ASC":
				return SegmentSortOrder.Asc;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, SegmentSortOrder value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case SegmentSortOrder.Desc:
				writer.WriteStringValue("desc");
				return;
			case SegmentSortOrder.Asc:
				writer.WriteStringValue("asc");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(ShardRoutingStateConverter))]
public enum ShardRoutingState
{
	[EnumMember(Value = "UNASSIGNED")]
	Unassigned,
	[EnumMember(Value = "STARTED")]
	Started,
	[EnumMember(Value = "RELOCATING")]
	Relocating,
	[EnumMember(Value = "INITIALIZING")]
	Initializing
}

internal sealed class ShardRoutingStateConverter : JsonConverter<ShardRoutingState>
{
	public override ShardRoutingState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "UNASSIGNED":
				return ShardRoutingState.Unassigned;
			case "STARTED":
				return ShardRoutingState.Started;
			case "RELOCATING":
				return ShardRoutingState.Relocating;
			case "INITIALIZING":
				return ShardRoutingState.Initializing;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, ShardRoutingState value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case ShardRoutingState.Unassigned:
				writer.WriteStringValue("UNASSIGNED");
				return;
			case ShardRoutingState.Started:
				writer.WriteStringValue("STARTED");
				return;
			case ShardRoutingState.Relocating:
				writer.WriteStringValue("RELOCATING");
				return;
			case ShardRoutingState.Initializing:
				writer.WriteStringValue("INITIALIZING");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(EnumStructConverter<StorageType>))]
public readonly partial struct StorageType
{
	public StorageType(string value) => Value = value;

	public readonly string Value { get; }

	/// <summary>
	/// <para>The NIO FS type stores the shard index on the file system (maps to Lucene NIOFSDirectory) using NIO. It allows multiple<br/>threads to read from the same file concurrently. It is not recommended on Windows because of a bug in the SUN Java<br/>implementation and disables some optimizations for heap memory usage.</para>
	/// </summary>
	public static StorageType Niofs { get; } = new StorageType("niofs");

	/// <summary>
	/// <para>The MMap FS type stores the shard index on the file system (maps to Lucene MMapDirectory) by mapping a file into<br/>memory (mmap). Memory mapping uses up a portion of the virtual memory address space in your process equal to the size<br/>of the file being mapped. Before using this class, be sure you have allowed plenty of virtual address space.</para>
	/// </summary>
	public static StorageType Mmapfs { get; } = new StorageType("mmapfs");

	/// <summary>
	/// <para>The hybridfs type is a hybrid of niofs and mmapfs, which chooses the best file system type for each type of file<br/>based on the read access pattern. Currently only the Lucene term dictionary, norms and doc values files are memory<br/>mapped. All other files are opened using Lucene NIOFSDirectory. Similarly to mmapfs be sure you have allowed<br/>plenty of virtual address space.</para>
	/// </summary>
	public static StorageType Hybridfs { get; } = new StorageType("hybridfs");

	/// <summary>
	/// <para>Default file system implementation. This will pick the best implementation depending on the operating environment, which<br/>is currently hybridfs on all supported systems but is subject to change.</para>
	/// </summary>
	public static StorageType Fs { get; } = new StorageType("fs");

	public override string ToString() => Value ?? string.Empty;

	public static implicit operator string(StorageType storageType) => storageType.Value;
	public static implicit operator StorageType(string value) => new(value);

	public override int GetHashCode() => Value.GetHashCode();
	public override bool Equals(object obj) => obj is StorageType other && this.Equals(other);
	public bool Equals(StorageType other) => Value == other.Value;

	public static bool operator ==(StorageType a, StorageType b) => a.Equals(b);
	public static bool operator !=(StorageType a, StorageType b) => !(a == b);
}

[JsonConverter(typeof(TranslogDurabilityConverter))]
public enum TranslogDurability
{
	/// <summary>
	/// <para>(default) fsync and commit after every request. In the event of hardware failure, all acknowledged writes<br/>will already have been committed to disk.</para>
	/// </summary>
	[EnumMember(Value = "request")]
	Request,
	/// <summary>
	/// <para>fsync and commit in the background every sync_interval. In the event of a failure, all acknowledged writes<br/>since the last automatic commit will be discarded.</para>
	/// </summary>
	[EnumMember(Value = "async")]
	Async
}

internal sealed class TranslogDurabilityConverter : JsonConverter<TranslogDurability>
{
	public override TranslogDurability Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "request":
			case "REQUEST":
				return TranslogDurability.Request;
			case "async":
			case "ASYNC":
				return TranslogDurability.Async;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, TranslogDurability value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case TranslogDurability.Request:
				writer.WriteStringValue("request");
				return;
			case TranslogDurability.Async:
				writer.WriteStringValue("async");
				return;
		}

		writer.WriteNullValue();
	}
}