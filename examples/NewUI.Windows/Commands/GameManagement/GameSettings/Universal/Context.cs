﻿using System.Text.Json.Serialization;

namespace XLauncher.GameSettings.Universal
{
    [JsonSourceGenerationOptions(IncludeFields = false, GenerationMode = JsonSourceGenerationMode.Metadata, IgnoreReadOnlyFields = true)]
    [JsonSerializable(typeof(CollapseScreenSetting))]
    internal sealed partial class CollapseScreenSettingContext : JsonSerializerContext { }
}