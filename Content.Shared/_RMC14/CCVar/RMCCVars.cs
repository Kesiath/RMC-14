﻿using Robust.Shared;
using Robust.Shared.Configuration;

namespace Content.Shared._RMC14.CCVar;

[CVarDefs]
public sealed class RMCCVars : CVars
{
    public static readonly CVarDef<float> CMXenoDamageDealtMultiplier =
        CVarDef.Create("rmc.xeno_damage_dealt_multiplier", 1f, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<float> CMXenoDamageReceivedMultiplier =
        CVarDef.Create("rmc.xeno_damage_received_multiplier", 1f, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<float> CMXenoSpeedMultiplier =
        CVarDef.Create("rmc.xeno_speed_multiplier", 1f, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<bool> CMPlayVoicelinesArachnid =
        CVarDef.Create("rmc.play_voicelines_arachnid", true, CVar.REPLICATED | CVar.CLIENT | CVar.ARCHIVE);

    public static readonly CVarDef<bool> CMPlayVoicelinesDiona =
        CVarDef.Create("rmc.play_voicelines_diona", true, CVar.REPLICATED | CVar.CLIENT | CVar.ARCHIVE);

    public static readonly CVarDef<bool> CMPlayVoicelinesDwarf =
        CVarDef.Create("rmc.play_voicelines_dwarf", true, CVar.REPLICATED | CVar.CLIENT | CVar.ARCHIVE);

    public static readonly CVarDef<bool> CMPlayVoicelinesFelinid =
        CVarDef.Create("rmc.play_voicelines_felinid", true, CVar.REPLICATED | CVar.CLIENT | CVar.ARCHIVE);

    public static readonly CVarDef<bool> CMPlayVoicelinesHuman =
        CVarDef.Create("rmc.play_voicelines_human", true, CVar.REPLICATED | CVar.CLIENT | CVar.ARCHIVE);

    public static readonly CVarDef<bool> CMPlayVoicelinesMoth =
        CVarDef.Create("rmc.play_voicelines_moth", true, CVar.REPLICATED | CVar.CLIENT | CVar.ARCHIVE);

    public static readonly CVarDef<bool> CMPlayVoicelinesReptilian =
        CVarDef.Create("rmc.play_voicelines_reptilian", true, CVar.REPLICATED | CVar.CLIENT | CVar.ARCHIVE);

    public static readonly CVarDef<bool> CMPlayVoicelinesSlime =
        CVarDef.Create("rmc.play_voicelines_slime", true, CVar.REPLICATED | CVar.CLIENT | CVar.ARCHIVE);

    public static readonly CVarDef<string> CMOocWebhook =
        CVarDef.Create("rmc.ooc_webhook", "", CVar.SERVERONLY | CVar.CONFIDENTIAL);

    public static readonly CVarDef<int> CMMaxHeavyAttackTargets =
        CVarDef.Create("rmc.max_heavy_attack_targets", 3, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<float> CMBloodlossMultiplier =
        CVarDef.Create("rmc.bloodloss_multiplier", 1.5f, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<float> CMBleedTimeMultiplier =
        CVarDef.Create("rmc.bleed_time_multiplier", 1f, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<float> CMMarinesPerXeno =
        CVarDef.Create("rmc.marines_per_xeno", 5.5f, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<bool> RMCAutoBalance =
        CVarDef.Create("rmc.auto_balance", true, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<float> RMCAutoBalanceStep =
        CVarDef.Create("rmc.auto_balance_step", 0.5f, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<float> RMCAutoBalanceMin =
        CVarDef.Create("rmc.auto_balance_min", 3f, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<float> RMCAutoBalanceMax =
        CVarDef.Create("rmc.auto_balance_max", 8f, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCPatronLobbyMessageTimeSeconds =
        CVarDef.Create("rmc.patron_lobby_message_time_seconds", 30, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCPatronLobbyMessageInitialDelaySeconds =
        CVarDef.Create("rmc.patron_lobby_message_initial_delay_seconds", 5, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<string> RMCDiscordAccountLinkingMessageLink =
        CVarDef.Create("rmc.discord_account_linking_message_link", "", CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCRequisitionsStartingBalance =
        CVarDef.Create("rmc.requisitions_starting_balance", 80000, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCRequisitionsBalanceGain =
        CVarDef.Create("rmc.requisitions_balance_gain", 1500, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<string> RMCDiscordToken =
        CVarDef.Create("rmc.discord_token", "", CVar.SERVER | CVar.SERVERONLY | CVar.CONFIDENTIAL);

    public static readonly CVarDef<ulong> RMCDiscordAdminChatChannel =
        CVarDef.Create("rmc.discord_admin_chat_channel", 0UL, CVar.SERVER | CVar.SERVERONLY | CVar.CONFIDENTIAL);

    /// <summary>
    ///     Comma-separated list of maps to load as the planet in the distress signal gamemode.
    /// </summary>
    public static readonly CVarDef<string> RMCPlanetMaps =
        CVarDef.Create("rmc.planet_maps", "/Maps/_RMC14/lv624.yml,/Maps/_RMC14/solaris.yml,/Maps/_RMC14/prison.yml,/Maps/_RMC14/shiva.yml", CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<bool> RMCDrawStorageIconLabels =
        CVarDef.Create("rmc.draw_storage_icon_labels", true, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<bool> RMCFTLCrashLand =
        CVarDef.Create("rmc.ftl_crash_land", true, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<float> RMCDropshipInitialDelayMinutes =
        CVarDef.Create("rmc.dropship_initial_delay_minutes", 15f, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<float> RMCLandingZonePrimaryAutoMinutes =
        CVarDef.Create("rmc.landing_zone_primary_auto_minutes", 25f, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCCorrosiveAcidTickDelaySeconds =
        CVarDef.Create("rmc.corrosive_acid_tick_delay_seconds", 10, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<string> RMCCorrosiveAcidDamageType =
        CVarDef.Create("rmc.corrosive_acid_damage_type", "Heat", CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCCorrosiveAcidDamageTimeSeconds =
        CVarDef.Create("rmc.corrosive_acid_damage_time_seconds", 45, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCTailStabMaxTargets =
        CVarDef.Create("rmc.tail_stab_max_targets", 1, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCEvolutionPointsRequireOvipositorMinutes =
        CVarDef.Create("rmc.evolution_points_require_ovipositor_minutes", 5, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCEvolutionPointsAccumulateBeforeMinutes =
        CVarDef.Create("rmc.evolution_points_accumulate_before_minutes", 15, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<bool> RMCAtmosTileEqualize =
        CVarDef.Create("rmc.atmos_tile_equalize", false, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<bool> RMCGasTileOverlayUpdate =
        CVarDef.Create("rmc.gas_tile_overlay_update", false, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<bool> RMCActiveInputMoverEnabled =
        CVarDef.Create("rmc.active_input_mover_enabled", true, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<string> RMCAdminFaxAreaMap =
        CVarDef.Create("rmc.admin_fax_area_map", "Maps/_RMC14/admin_fax.yml", CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCBioscanInitialDelaySeconds =
        CVarDef.Create("rmc.bioscan_initial_delay_seconds", 300, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCBioscanCheckDelaySeconds =
        CVarDef.Create("rmc.bioscan_check_delay_seconds", 60, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCBioscanMinimumCooldownSeconds =
        CVarDef.Create("rmc.bioscan_minimum_cooldown_seconds", 300, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCBioscanBaseCooldownSeconds =
        CVarDef.Create("rmc.bioscan_base_cooldown_seconds", 1800, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCBioscanVariance =
        CVarDef.Create("rmc.bioscan_variance", 2, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCDropshipFabricatorStartingPoints =
        CVarDef.Create("rmc.dropship_fabricator_starting_points", 20000, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<float> RMCDropshipFabricatorGainEverySeconds =
        CVarDef.Create("rmc.dropship_fabricator_gain_every_seconds", 3.33333f, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<bool> RMCDropshipCASDebug =
        CVarDef.Create("rmc.dropship_cas_debug", false, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCDropshipFlyByTimeSeconds =
        CVarDef.Create("rmc.dropship_fly_by_time_seconds", 100, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCDropshipHijackTravelTimeSeconds =
        CVarDef.Create("rmc.dropship_hijack_travel_time_seconds", 180, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<bool> RMCEntitiesLogDelete =
        CVarDef.Create("rmc.entities_log_delete", false, CVar.SERVER | CVar.SERVERONLY);
}
