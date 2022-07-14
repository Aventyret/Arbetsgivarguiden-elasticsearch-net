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
	public sealed class MlUpdateJobRequestParameters : RequestParameters<MlUpdateJobRequestParameters>
	{
	}

	public partial class MlUpdateJobRequest : PlainRequestBase<MlUpdateJobRequestParameters>
	{
		public MlUpdateJobRequest(Elastic.Clients.Elasticsearch.Id job_id) : base(r => r.Required("job_id", job_id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningUpdateJob;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonInclude]
		[JsonPropertyName("allow_lazy_open")]
		public bool? AllowLazyOpen { get; set; }

		[JsonInclude]
		[JsonPropertyName("analysis_limits")]
		public Elastic.Clients.Elasticsearch.Ml.AnalysisMemoryLimit? AnalysisLimits { get; set; }

		[JsonInclude]
		[JsonPropertyName("background_persist_interval")]
		public Elastic.Clients.Elasticsearch.Duration? BackgroundPersistInterval { get; set; }

		[JsonInclude]
		[JsonPropertyName("custom_settings")]
		public Dictionary<string, object>? CustomSettings { get; set; }

		[JsonInclude]
		[JsonPropertyName("categorization_filters")]
		public IEnumerable<string>? CategorizationFilters { get; set; }

		[JsonInclude]
		[JsonPropertyName("description")]
		public string? Description { get; set; }

		[JsonInclude]
		[JsonPropertyName("model_plot_config")]
		public Elastic.Clients.Elasticsearch.Ml.ModelPlotConfig? ModelPlotConfig { get; set; }

		[JsonInclude]
		[JsonPropertyName("daily_model_snapshot_retention_after_days")]
		public long? DailyModelSnapshotRetentionAfterDays { get; set; }

		[JsonInclude]
		[JsonPropertyName("model_snapshot_retention_days")]
		public long? ModelSnapshotRetentionDays { get; set; }

		[JsonInclude]
		[JsonPropertyName("renormalization_window_days")]
		public long? RenormalizationWindowDays { get; set; }

		[JsonInclude]
		[JsonPropertyName("results_retention_days")]
		public long? ResultsRetentionDays { get; set; }

		[JsonInclude]
		[JsonPropertyName("groups")]
		public IEnumerable<string>? Groups { get; set; }

		[JsonInclude]
		[JsonPropertyName("detectors")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Ml.Detector>? Detectors { get; set; }

		[JsonInclude]
		[JsonPropertyName("per_partition_categorization")]
		public Elastic.Clients.Elasticsearch.Ml.PerPartitionCategorization? PerPartitionCategorization { get; set; }
	}

	public sealed partial class MlUpdateJobRequestDescriptor<TDocument> : RequestDescriptorBase<MlUpdateJobRequestDescriptor<TDocument>, MlUpdateJobRequestParameters>
	{
		internal MlUpdateJobRequestDescriptor(Action<MlUpdateJobRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
		public MlUpdateJobRequestDescriptor(Elastic.Clients.Elasticsearch.Id job_id) : base(r => r.Required("job_id", job_id))
		{
		}

		internal MlUpdateJobRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningUpdateJob;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		public MlUpdateJobRequestDescriptor<TDocument> JobId(Elastic.Clients.Elasticsearch.Id job_id)
		{
			RouteValues.Required("job_id", job_id);
			return Self;
		}

		private IEnumerable<Elastic.Clients.Elasticsearch.Ml.Detector>? DetectorsValue { get; set; }

		private DetectorDescriptor<TDocument> DetectorsDescriptor { get; set; }

		private Action<DetectorDescriptor<TDocument>> DetectorsDescriptorAction { get; set; }

		private Action<DetectorDescriptor<TDocument>>[] DetectorsDescriptorActions { get; set; }

		private Elastic.Clients.Elasticsearch.Ml.ModelPlotConfig? ModelPlotConfigValue { get; set; }

		private ModelPlotConfigDescriptor<TDocument> ModelPlotConfigDescriptor { get; set; }

		private Action<ModelPlotConfigDescriptor<TDocument>> ModelPlotConfigDescriptorAction { get; set; }

		private bool? AllowLazyOpenValue { get; set; }

		private Elastic.Clients.Elasticsearch.Ml.AnalysisMemoryLimit? AnalysisLimitsValue { get; set; }

		private AnalysisMemoryLimitDescriptor AnalysisLimitsDescriptor { get; set; }

		private Action<AnalysisMemoryLimitDescriptor> AnalysisLimitsDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Duration? BackgroundPersistIntervalValue { get; set; }

		private IEnumerable<string>? CategorizationFiltersValue { get; set; }

		private Dictionary<string, object>? CustomSettingsValue { get; set; }

		private long? DailyModelSnapshotRetentionAfterDaysValue { get; set; }

		private string? DescriptionValue { get; set; }

		private IEnumerable<string>? GroupsValue { get; set; }

		private long? ModelSnapshotRetentionDaysValue { get; set; }

		private Elastic.Clients.Elasticsearch.Ml.PerPartitionCategorization? PerPartitionCategorizationValue { get; set; }

		private PerPartitionCategorizationDescriptor PerPartitionCategorizationDescriptor { get; set; }

		private Action<PerPartitionCategorizationDescriptor> PerPartitionCategorizationDescriptorAction { get; set; }

		private long? RenormalizationWindowDaysValue { get; set; }

		private long? ResultsRetentionDaysValue { get; set; }

		public MlUpdateJobRequestDescriptor<TDocument> Detectors(IEnumerable<Elastic.Clients.Elasticsearch.Ml.Detector>? detectors)
		{
			DetectorsDescriptor = null;
			DetectorsDescriptorAction = null;
			DetectorsDescriptorActions = null;
			DetectorsValue = detectors;
			return Self;
		}

		public MlUpdateJobRequestDescriptor<TDocument> Detectors(DetectorDescriptor<TDocument> descriptor)
		{
			DetectorsValue = null;
			DetectorsDescriptorAction = null;
			DetectorsDescriptorActions = null;
			DetectorsDescriptor = descriptor;
			return Self;
		}

		public MlUpdateJobRequestDescriptor<TDocument> Detectors(Action<DetectorDescriptor<TDocument>> configure)
		{
			DetectorsValue = null;
			DetectorsDescriptor = null;
			DetectorsDescriptorActions = null;
			DetectorsDescriptorAction = configure;
			return Self;
		}

		public MlUpdateJobRequestDescriptor<TDocument> Detectors(params Action<DetectorDescriptor<TDocument>>[] configure)
		{
			DetectorsValue = null;
			DetectorsDescriptor = null;
			DetectorsDescriptorAction = null;
			DetectorsDescriptorActions = configure;
			return Self;
		}

		public MlUpdateJobRequestDescriptor<TDocument> ModelPlotConfig(Elastic.Clients.Elasticsearch.Ml.ModelPlotConfig? modelPlotConfig)
		{
			ModelPlotConfigDescriptor = null;
			ModelPlotConfigDescriptorAction = null;
			ModelPlotConfigValue = modelPlotConfig;
			return Self;
		}

		public MlUpdateJobRequestDescriptor<TDocument> ModelPlotConfig(ModelPlotConfigDescriptor<TDocument> descriptor)
		{
			ModelPlotConfigValue = null;
			ModelPlotConfigDescriptorAction = null;
			ModelPlotConfigDescriptor = descriptor;
			return Self;
		}

		public MlUpdateJobRequestDescriptor<TDocument> ModelPlotConfig(Action<ModelPlotConfigDescriptor<TDocument>> configure)
		{
			ModelPlotConfigValue = null;
			ModelPlotConfigDescriptor = null;
			ModelPlotConfigDescriptorAction = configure;
			return Self;
		}

		public MlUpdateJobRequestDescriptor<TDocument> AllowLazyOpen(bool? allowLazyOpen = true)
		{
			AllowLazyOpenValue = allowLazyOpen;
			return Self;
		}

		public MlUpdateJobRequestDescriptor<TDocument> AnalysisLimits(Elastic.Clients.Elasticsearch.Ml.AnalysisMemoryLimit? analysisLimits)
		{
			AnalysisLimitsDescriptor = null;
			AnalysisLimitsDescriptorAction = null;
			AnalysisLimitsValue = analysisLimits;
			return Self;
		}

		public MlUpdateJobRequestDescriptor<TDocument> AnalysisLimits(AnalysisMemoryLimitDescriptor descriptor)
		{
			AnalysisLimitsValue = null;
			AnalysisLimitsDescriptorAction = null;
			AnalysisLimitsDescriptor = descriptor;
			return Self;
		}

		public MlUpdateJobRequestDescriptor<TDocument> AnalysisLimits(Action<AnalysisMemoryLimitDescriptor> configure)
		{
			AnalysisLimitsValue = null;
			AnalysisLimitsDescriptor = null;
			AnalysisLimitsDescriptorAction = configure;
			return Self;
		}

		public MlUpdateJobRequestDescriptor<TDocument> BackgroundPersistInterval(Elastic.Clients.Elasticsearch.Duration? backgroundPersistInterval)
		{
			BackgroundPersistIntervalValue = backgroundPersistInterval;
			return Self;
		}

		public MlUpdateJobRequestDescriptor<TDocument> CategorizationFilters(IEnumerable<string>? categorizationFilters)
		{
			CategorizationFiltersValue = categorizationFilters;
			return Self;
		}

		public MlUpdateJobRequestDescriptor<TDocument> CustomSettings(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			CustomSettingsValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public MlUpdateJobRequestDescriptor<TDocument> DailyModelSnapshotRetentionAfterDays(long? dailyModelSnapshotRetentionAfterDays)
		{
			DailyModelSnapshotRetentionAfterDaysValue = dailyModelSnapshotRetentionAfterDays;
			return Self;
		}

		public MlUpdateJobRequestDescriptor<TDocument> Description(string? description)
		{
			DescriptionValue = description;
			return Self;
		}

		public MlUpdateJobRequestDescriptor<TDocument> Groups(IEnumerable<string>? groups)
		{
			GroupsValue = groups;
			return Self;
		}

		public MlUpdateJobRequestDescriptor<TDocument> ModelSnapshotRetentionDays(long? modelSnapshotRetentionDays)
		{
			ModelSnapshotRetentionDaysValue = modelSnapshotRetentionDays;
			return Self;
		}

		public MlUpdateJobRequestDescriptor<TDocument> PerPartitionCategorization(Elastic.Clients.Elasticsearch.Ml.PerPartitionCategorization? perPartitionCategorization)
		{
			PerPartitionCategorizationDescriptor = null;
			PerPartitionCategorizationDescriptorAction = null;
			PerPartitionCategorizationValue = perPartitionCategorization;
			return Self;
		}

		public MlUpdateJobRequestDescriptor<TDocument> PerPartitionCategorization(PerPartitionCategorizationDescriptor descriptor)
		{
			PerPartitionCategorizationValue = null;
			PerPartitionCategorizationDescriptorAction = null;
			PerPartitionCategorizationDescriptor = descriptor;
			return Self;
		}

		public MlUpdateJobRequestDescriptor<TDocument> PerPartitionCategorization(Action<PerPartitionCategorizationDescriptor> configure)
		{
			PerPartitionCategorizationValue = null;
			PerPartitionCategorizationDescriptor = null;
			PerPartitionCategorizationDescriptorAction = configure;
			return Self;
		}

		public MlUpdateJobRequestDescriptor<TDocument> RenormalizationWindowDays(long? renormalizationWindowDays)
		{
			RenormalizationWindowDaysValue = renormalizationWindowDays;
			return Self;
		}

		public MlUpdateJobRequestDescriptor<TDocument> ResultsRetentionDays(long? resultsRetentionDays)
		{
			ResultsRetentionDaysValue = resultsRetentionDays;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (DetectorsDescriptor is not null)
			{
				writer.WritePropertyName("detectors");
				writer.WriteStartArray();
				JsonSerializer.Serialize(writer, DetectorsDescriptor, options);
				writer.WriteEndArray();
			}
			else if (DetectorsDescriptorAction is not null)
			{
				writer.WritePropertyName("detectors");
				writer.WriteStartArray();
				JsonSerializer.Serialize(writer, new DetectorDescriptor<TDocument>(DetectorsDescriptorAction), options);
				writer.WriteEndArray();
			}
			else if (DetectorsDescriptorActions is not null)
			{
				writer.WritePropertyName("detectors");
				writer.WriteStartArray();
				foreach (var action in DetectorsDescriptorActions)
				{
					JsonSerializer.Serialize(writer, new DetectorDescriptor<TDocument>(action), options);
				}

				writer.WriteEndArray();
			}
			else if (DetectorsValue is not null)
			{
				writer.WritePropertyName("detectors");
				JsonSerializer.Serialize(writer, DetectorsValue, options);
			}

			if (ModelPlotConfigDescriptor is not null)
			{
				writer.WritePropertyName("model_plot_config");
				JsonSerializer.Serialize(writer, ModelPlotConfigDescriptor, options);
			}
			else if (ModelPlotConfigDescriptorAction is not null)
			{
				writer.WritePropertyName("model_plot_config");
				JsonSerializer.Serialize(writer, new ModelPlotConfigDescriptor<TDocument>(ModelPlotConfigDescriptorAction), options);
			}
			else if (ModelPlotConfigValue is not null)
			{
				writer.WritePropertyName("model_plot_config");
				JsonSerializer.Serialize(writer, ModelPlotConfigValue, options);
			}

			if (AllowLazyOpenValue.HasValue)
			{
				writer.WritePropertyName("allow_lazy_open");
				writer.WriteBooleanValue(AllowLazyOpenValue.Value);
			}

			if (AnalysisLimitsDescriptor is not null)
			{
				writer.WritePropertyName("analysis_limits");
				JsonSerializer.Serialize(writer, AnalysisLimitsDescriptor, options);
			}
			else if (AnalysisLimitsDescriptorAction is not null)
			{
				writer.WritePropertyName("analysis_limits");
				JsonSerializer.Serialize(writer, new AnalysisMemoryLimitDescriptor(AnalysisLimitsDescriptorAction), options);
			}
			else if (AnalysisLimitsValue is not null)
			{
				writer.WritePropertyName("analysis_limits");
				JsonSerializer.Serialize(writer, AnalysisLimitsValue, options);
			}

			if (BackgroundPersistIntervalValue is not null)
			{
				writer.WritePropertyName("background_persist_interval");
				JsonSerializer.Serialize(writer, BackgroundPersistIntervalValue, options);
			}

			if (CategorizationFiltersValue is not null)
			{
				writer.WritePropertyName("categorization_filters");
				JsonSerializer.Serialize(writer, CategorizationFiltersValue, options);
			}

			if (CustomSettingsValue is not null)
			{
				writer.WritePropertyName("custom_settings");
				JsonSerializer.Serialize(writer, CustomSettingsValue, options);
			}

			if (DailyModelSnapshotRetentionAfterDaysValue.HasValue)
			{
				writer.WritePropertyName("daily_model_snapshot_retention_after_days");
				writer.WriteNumberValue(DailyModelSnapshotRetentionAfterDaysValue.Value);
			}

			if (!string.IsNullOrEmpty(DescriptionValue))
			{
				writer.WritePropertyName("description");
				writer.WriteStringValue(DescriptionValue);
			}

			if (GroupsValue is not null)
			{
				writer.WritePropertyName("groups");
				JsonSerializer.Serialize(writer, GroupsValue, options);
			}

			if (ModelSnapshotRetentionDaysValue.HasValue)
			{
				writer.WritePropertyName("model_snapshot_retention_days");
				writer.WriteNumberValue(ModelSnapshotRetentionDaysValue.Value);
			}

			if (PerPartitionCategorizationDescriptor is not null)
			{
				writer.WritePropertyName("per_partition_categorization");
				JsonSerializer.Serialize(writer, PerPartitionCategorizationDescriptor, options);
			}
			else if (PerPartitionCategorizationDescriptorAction is not null)
			{
				writer.WritePropertyName("per_partition_categorization");
				JsonSerializer.Serialize(writer, new PerPartitionCategorizationDescriptor(PerPartitionCategorizationDescriptorAction), options);
			}
			else if (PerPartitionCategorizationValue is not null)
			{
				writer.WritePropertyName("per_partition_categorization");
				JsonSerializer.Serialize(writer, PerPartitionCategorizationValue, options);
			}

			if (RenormalizationWindowDaysValue.HasValue)
			{
				writer.WritePropertyName("renormalization_window_days");
				writer.WriteNumberValue(RenormalizationWindowDaysValue.Value);
			}

			if (ResultsRetentionDaysValue.HasValue)
			{
				writer.WritePropertyName("results_retention_days");
				writer.WriteNumberValue(ResultsRetentionDaysValue.Value);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class MlUpdateJobRequestDescriptor : RequestDescriptorBase<MlUpdateJobRequestDescriptor, MlUpdateJobRequestParameters>
	{
		internal MlUpdateJobRequestDescriptor(Action<MlUpdateJobRequestDescriptor> configure) => configure.Invoke(this);
		public MlUpdateJobRequestDescriptor(Elastic.Clients.Elasticsearch.Id job_id) : base(r => r.Required("job_id", job_id))
		{
		}

		internal MlUpdateJobRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningUpdateJob;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		public MlUpdateJobRequestDescriptor JobId(Elastic.Clients.Elasticsearch.Id job_id)
		{
			RouteValues.Required("job_id", job_id);
			return Self;
		}

		private IEnumerable<Elastic.Clients.Elasticsearch.Ml.Detector>? DetectorsValue { get; set; }

		private DetectorDescriptor DetectorsDescriptor { get; set; }

		private Action<DetectorDescriptor> DetectorsDescriptorAction { get; set; }

		private Action<DetectorDescriptor>[] DetectorsDescriptorActions { get; set; }

		private Elastic.Clients.Elasticsearch.Ml.ModelPlotConfig? ModelPlotConfigValue { get; set; }

		private ModelPlotConfigDescriptor ModelPlotConfigDescriptor { get; set; }

		private Action<ModelPlotConfigDescriptor> ModelPlotConfigDescriptorAction { get; set; }

		private bool? AllowLazyOpenValue { get; set; }

		private Elastic.Clients.Elasticsearch.Ml.AnalysisMemoryLimit? AnalysisLimitsValue { get; set; }

		private AnalysisMemoryLimitDescriptor AnalysisLimitsDescriptor { get; set; }

		private Action<AnalysisMemoryLimitDescriptor> AnalysisLimitsDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Duration? BackgroundPersistIntervalValue { get; set; }

		private IEnumerable<string>? CategorizationFiltersValue { get; set; }

		private Dictionary<string, object>? CustomSettingsValue { get; set; }

		private long? DailyModelSnapshotRetentionAfterDaysValue { get; set; }

		private string? DescriptionValue { get; set; }

		private IEnumerable<string>? GroupsValue { get; set; }

		private long? ModelSnapshotRetentionDaysValue { get; set; }

		private Elastic.Clients.Elasticsearch.Ml.PerPartitionCategorization? PerPartitionCategorizationValue { get; set; }

		private PerPartitionCategorizationDescriptor PerPartitionCategorizationDescriptor { get; set; }

		private Action<PerPartitionCategorizationDescriptor> PerPartitionCategorizationDescriptorAction { get; set; }

		private long? RenormalizationWindowDaysValue { get; set; }

		private long? ResultsRetentionDaysValue { get; set; }

		public MlUpdateJobRequestDescriptor Detectors(IEnumerable<Elastic.Clients.Elasticsearch.Ml.Detector>? detectors)
		{
			DetectorsDescriptor = null;
			DetectorsDescriptorAction = null;
			DetectorsDescriptorActions = null;
			DetectorsValue = detectors;
			return Self;
		}

		public MlUpdateJobRequestDescriptor Detectors(DetectorDescriptor descriptor)
		{
			DetectorsValue = null;
			DetectorsDescriptorAction = null;
			DetectorsDescriptorActions = null;
			DetectorsDescriptor = descriptor;
			return Self;
		}

		public MlUpdateJobRequestDescriptor Detectors(Action<DetectorDescriptor> configure)
		{
			DetectorsValue = null;
			DetectorsDescriptor = null;
			DetectorsDescriptorActions = null;
			DetectorsDescriptorAction = configure;
			return Self;
		}

		public MlUpdateJobRequestDescriptor Detectors(params Action<DetectorDescriptor>[] configure)
		{
			DetectorsValue = null;
			DetectorsDescriptor = null;
			DetectorsDescriptorAction = null;
			DetectorsDescriptorActions = configure;
			return Self;
		}

		public MlUpdateJobRequestDescriptor ModelPlotConfig(Elastic.Clients.Elasticsearch.Ml.ModelPlotConfig? modelPlotConfig)
		{
			ModelPlotConfigDescriptor = null;
			ModelPlotConfigDescriptorAction = null;
			ModelPlotConfigValue = modelPlotConfig;
			return Self;
		}

		public MlUpdateJobRequestDescriptor ModelPlotConfig(ModelPlotConfigDescriptor descriptor)
		{
			ModelPlotConfigValue = null;
			ModelPlotConfigDescriptorAction = null;
			ModelPlotConfigDescriptor = descriptor;
			return Self;
		}

		public MlUpdateJobRequestDescriptor ModelPlotConfig(Action<ModelPlotConfigDescriptor> configure)
		{
			ModelPlotConfigValue = null;
			ModelPlotConfigDescriptor = null;
			ModelPlotConfigDescriptorAction = configure;
			return Self;
		}

		public MlUpdateJobRequestDescriptor AllowLazyOpen(bool? allowLazyOpen = true)
		{
			AllowLazyOpenValue = allowLazyOpen;
			return Self;
		}

		public MlUpdateJobRequestDescriptor AnalysisLimits(Elastic.Clients.Elasticsearch.Ml.AnalysisMemoryLimit? analysisLimits)
		{
			AnalysisLimitsDescriptor = null;
			AnalysisLimitsDescriptorAction = null;
			AnalysisLimitsValue = analysisLimits;
			return Self;
		}

		public MlUpdateJobRequestDescriptor AnalysisLimits(AnalysisMemoryLimitDescriptor descriptor)
		{
			AnalysisLimitsValue = null;
			AnalysisLimitsDescriptorAction = null;
			AnalysisLimitsDescriptor = descriptor;
			return Self;
		}

		public MlUpdateJobRequestDescriptor AnalysisLimits(Action<AnalysisMemoryLimitDescriptor> configure)
		{
			AnalysisLimitsValue = null;
			AnalysisLimitsDescriptor = null;
			AnalysisLimitsDescriptorAction = configure;
			return Self;
		}

		public MlUpdateJobRequestDescriptor BackgroundPersistInterval(Elastic.Clients.Elasticsearch.Duration? backgroundPersistInterval)
		{
			BackgroundPersistIntervalValue = backgroundPersistInterval;
			return Self;
		}

		public MlUpdateJobRequestDescriptor CategorizationFilters(IEnumerable<string>? categorizationFilters)
		{
			CategorizationFiltersValue = categorizationFilters;
			return Self;
		}

		public MlUpdateJobRequestDescriptor CustomSettings(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			CustomSettingsValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public MlUpdateJobRequestDescriptor DailyModelSnapshotRetentionAfterDays(long? dailyModelSnapshotRetentionAfterDays)
		{
			DailyModelSnapshotRetentionAfterDaysValue = dailyModelSnapshotRetentionAfterDays;
			return Self;
		}

		public MlUpdateJobRequestDescriptor Description(string? description)
		{
			DescriptionValue = description;
			return Self;
		}

		public MlUpdateJobRequestDescriptor Groups(IEnumerable<string>? groups)
		{
			GroupsValue = groups;
			return Self;
		}

		public MlUpdateJobRequestDescriptor ModelSnapshotRetentionDays(long? modelSnapshotRetentionDays)
		{
			ModelSnapshotRetentionDaysValue = modelSnapshotRetentionDays;
			return Self;
		}

		public MlUpdateJobRequestDescriptor PerPartitionCategorization(Elastic.Clients.Elasticsearch.Ml.PerPartitionCategorization? perPartitionCategorization)
		{
			PerPartitionCategorizationDescriptor = null;
			PerPartitionCategorizationDescriptorAction = null;
			PerPartitionCategorizationValue = perPartitionCategorization;
			return Self;
		}

		public MlUpdateJobRequestDescriptor PerPartitionCategorization(PerPartitionCategorizationDescriptor descriptor)
		{
			PerPartitionCategorizationValue = null;
			PerPartitionCategorizationDescriptorAction = null;
			PerPartitionCategorizationDescriptor = descriptor;
			return Self;
		}

		public MlUpdateJobRequestDescriptor PerPartitionCategorization(Action<PerPartitionCategorizationDescriptor> configure)
		{
			PerPartitionCategorizationValue = null;
			PerPartitionCategorizationDescriptor = null;
			PerPartitionCategorizationDescriptorAction = configure;
			return Self;
		}

		public MlUpdateJobRequestDescriptor RenormalizationWindowDays(long? renormalizationWindowDays)
		{
			RenormalizationWindowDaysValue = renormalizationWindowDays;
			return Self;
		}

		public MlUpdateJobRequestDescriptor ResultsRetentionDays(long? resultsRetentionDays)
		{
			ResultsRetentionDaysValue = resultsRetentionDays;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (DetectorsDescriptor is not null)
			{
				writer.WritePropertyName("detectors");
				writer.WriteStartArray();
				JsonSerializer.Serialize(writer, DetectorsDescriptor, options);
				writer.WriteEndArray();
			}
			else if (DetectorsDescriptorAction is not null)
			{
				writer.WritePropertyName("detectors");
				writer.WriteStartArray();
				JsonSerializer.Serialize(writer, new DetectorDescriptor(DetectorsDescriptorAction), options);
				writer.WriteEndArray();
			}
			else if (DetectorsDescriptorActions is not null)
			{
				writer.WritePropertyName("detectors");
				writer.WriteStartArray();
				foreach (var action in DetectorsDescriptorActions)
				{
					JsonSerializer.Serialize(writer, new DetectorDescriptor(action), options);
				}

				writer.WriteEndArray();
			}
			else if (DetectorsValue is not null)
			{
				writer.WritePropertyName("detectors");
				JsonSerializer.Serialize(writer, DetectorsValue, options);
			}

			if (ModelPlotConfigDescriptor is not null)
			{
				writer.WritePropertyName("model_plot_config");
				JsonSerializer.Serialize(writer, ModelPlotConfigDescriptor, options);
			}
			else if (ModelPlotConfigDescriptorAction is not null)
			{
				writer.WritePropertyName("model_plot_config");
				JsonSerializer.Serialize(writer, new ModelPlotConfigDescriptor(ModelPlotConfigDescriptorAction), options);
			}
			else if (ModelPlotConfigValue is not null)
			{
				writer.WritePropertyName("model_plot_config");
				JsonSerializer.Serialize(writer, ModelPlotConfigValue, options);
			}

			if (AllowLazyOpenValue.HasValue)
			{
				writer.WritePropertyName("allow_lazy_open");
				writer.WriteBooleanValue(AllowLazyOpenValue.Value);
			}

			if (AnalysisLimitsDescriptor is not null)
			{
				writer.WritePropertyName("analysis_limits");
				JsonSerializer.Serialize(writer, AnalysisLimitsDescriptor, options);
			}
			else if (AnalysisLimitsDescriptorAction is not null)
			{
				writer.WritePropertyName("analysis_limits");
				JsonSerializer.Serialize(writer, new AnalysisMemoryLimitDescriptor(AnalysisLimitsDescriptorAction), options);
			}
			else if (AnalysisLimitsValue is not null)
			{
				writer.WritePropertyName("analysis_limits");
				JsonSerializer.Serialize(writer, AnalysisLimitsValue, options);
			}

			if (BackgroundPersistIntervalValue is not null)
			{
				writer.WritePropertyName("background_persist_interval");
				JsonSerializer.Serialize(writer, BackgroundPersistIntervalValue, options);
			}

			if (CategorizationFiltersValue is not null)
			{
				writer.WritePropertyName("categorization_filters");
				JsonSerializer.Serialize(writer, CategorizationFiltersValue, options);
			}

			if (CustomSettingsValue is not null)
			{
				writer.WritePropertyName("custom_settings");
				JsonSerializer.Serialize(writer, CustomSettingsValue, options);
			}

			if (DailyModelSnapshotRetentionAfterDaysValue.HasValue)
			{
				writer.WritePropertyName("daily_model_snapshot_retention_after_days");
				writer.WriteNumberValue(DailyModelSnapshotRetentionAfterDaysValue.Value);
			}

			if (!string.IsNullOrEmpty(DescriptionValue))
			{
				writer.WritePropertyName("description");
				writer.WriteStringValue(DescriptionValue);
			}

			if (GroupsValue is not null)
			{
				writer.WritePropertyName("groups");
				JsonSerializer.Serialize(writer, GroupsValue, options);
			}

			if (ModelSnapshotRetentionDaysValue.HasValue)
			{
				writer.WritePropertyName("model_snapshot_retention_days");
				writer.WriteNumberValue(ModelSnapshotRetentionDaysValue.Value);
			}

			if (PerPartitionCategorizationDescriptor is not null)
			{
				writer.WritePropertyName("per_partition_categorization");
				JsonSerializer.Serialize(writer, PerPartitionCategorizationDescriptor, options);
			}
			else if (PerPartitionCategorizationDescriptorAction is not null)
			{
				writer.WritePropertyName("per_partition_categorization");
				JsonSerializer.Serialize(writer, new PerPartitionCategorizationDescriptor(PerPartitionCategorizationDescriptorAction), options);
			}
			else if (PerPartitionCategorizationValue is not null)
			{
				writer.WritePropertyName("per_partition_categorization");
				JsonSerializer.Serialize(writer, PerPartitionCategorizationValue, options);
			}

			if (RenormalizationWindowDaysValue.HasValue)
			{
				writer.WritePropertyName("renormalization_window_days");
				writer.WriteNumberValue(RenormalizationWindowDaysValue.Value);
			}

			if (ResultsRetentionDaysValue.HasValue)
			{
				writer.WritePropertyName("results_retention_days");
				writer.WriteNumberValue(ResultsRetentionDaysValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}