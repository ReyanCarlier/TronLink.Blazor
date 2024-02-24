namespace TronLink.Blazor.Responses.Classes;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class NodeInfoResponse
{
    [JsonPropertyName("activeConnectCount")]
    public int ActiveConnectCount { get; set; }

    [JsonPropertyName("beginSyncNum")]
    public long BeginSyncNum { get; set; }

    [JsonPropertyName("block")]
    public string Block { get; set; }

    [JsonPropertyName("cheatWitnessInfoMap")]
    public Dictionary<string, object> CheatWitnessInfoMap { get; set; }

    [JsonPropertyName("configNodeInfo")]
    public ConfigNodeInfo ConfigNodeInfo { get; set; }

    [JsonPropertyName("currentConnectCount")]
    public int CurrentConnectCount { get; set; }

    [JsonPropertyName("machineInfo")]
    public MachineInfo MachineInfo { get; set; }

    [JsonPropertyName("passiveConnectCount")]
    public int PassiveConnectCount { get; set; }

    [JsonPropertyName("peerList")]
    public List<PeerInfo> PeerList { get; set; }

    [JsonPropertyName("solidityBlock")]
    public string SolidityBlock { get; set; }

    [JsonPropertyName("totalFlow")]
    public long TotalFlow { get; set; }
}

public class ConfigNodeInfo
{
    [JsonPropertyName("activeNodeSize")]
    public int ActiveNodeSize { get; set; }

    [JsonPropertyName("allowAdaptiveEnergy")]
    public int AllowAdaptiveEnergy { get; set; }

    [JsonPropertyName("allowCreationOfContracts")]
    public int AllowCreationOfContracts { get; set; }

    [JsonPropertyName("backupListenPort")]
    public int BackupListenPort { get; set; }

    [JsonPropertyName("backupMemberSize")]
    public int BackupMemberSize { get; set; }

    [JsonPropertyName("backupPriority")]
    public int BackupPriority { get; set; }

    [JsonPropertyName("codeVersion")]
    public string CodeVersion { get; set; }

    [JsonPropertyName("dbVersion")]
    public int DbVersion { get; set; }

    [JsonPropertyName("discoverEnable")]
    public bool DiscoverEnable { get; set; }

    [JsonPropertyName("listenPort")]
    public int ListenPort { get; set; }

    [JsonPropertyName("maxConnectCount")]
    public int MaxConnectCount { get; set; }

    [JsonPropertyName("maxTimeRatio")]
    public int MaxTimeRatio { get; set; }

    [JsonPropertyName("minParticipationRate")]
    public int MinParticipationRate { get; set; }

    [JsonPropertyName("minTimeRatio")]
    public int MinTimeRatio { get; set; }

    [JsonPropertyName("p2pVersion")]
    public string P2pVersion { get; set; }

    [JsonPropertyName("passiveNodeSize")]
    public int PassiveNodeSize { get; set; }

    [JsonPropertyName("sameIpMaxConnectCount")]
    public int SameIpMaxConnectCount { get; set; }

    [JsonPropertyName("sendNodeSize")]
    public int SendNodeSize { get; set; }

    [JsonPropertyName("supportConstant")]
    public bool SupportConstant { get; set; }

    [JsonPropertyName("versionName")]
    public string VersionName { get; set; }

    [JsonPropertyName("versionNum")]
    public string VersionNum { get; set; }
}

public class MachineInfo
{
    [JsonPropertyName("cpuCount")]
    public int CpuCount { get; set; }

    [JsonPropertyName("cpuRate")]
    public double CpuRate { get; set; }

    [JsonPropertyName("deadLockThreadCount")]
    public int DeadLockThreadCount { get; set; }

    [JsonPropertyName("deadLockThreadInfoList")]
    public List<object> DeadLockThreadInfoList { get; set; }

    [JsonPropertyName("freeMemory")]
    public long FreeMemory { get; set; }

    [JsonPropertyName("javaVersion")]
    public string JavaVersion { get; set; }

    [JsonPropertyName("jvmFreeMemory")]
    public long JvmFreeMemory { get; set; }

    [JsonPropertyName("jvmTotalMemory")]
    public long JvmTotalMemory { get; set; }

    [JsonPropertyName("memoryDescInfoList")]
    public List<object> MemoryDescInfoList { get; set; }

    [JsonPropertyName("osName")]
    public string OsName { get; set; }

    [JsonPropertyName("processCpuRate")]
    public double ProcessCpuRate { get; set; }

    [JsonPropertyName("threadCount")]
    public int ThreadCount { get; set; }

    [JsonPropertyName("totalMemory")]
    public long TotalMemory { get; set; }
}

public class PeerInfo
{
    [JsonPropertyName("active")]
    public bool Active { get; set; }

    [JsonPropertyName("avgLatency")]
    public int AvgLatency { get; set; }

    [JsonPropertyName("blockInPorcSize")]
    public int BlockInPorcSize { get; set; }

    [JsonPropertyName("connectTime")]
    public long ConnectTime { get; set; }

    [JsonPropertyName("disconnectTimes")]
    public int DisconnectTimes { get; set; }

    [JsonPropertyName("headBlockTimeWeBothHave")]
    public long HeadBlockTimeWeBothHave { get; set; }

    [JsonPropertyName("headBlockWeBothHave")]
    public string HeadBlockWeBothHave { get; set; }

    [JsonPropertyName("host")]
    public string Host { get; set; }

    [JsonPropertyName("inFlow")]
    public long InFlow { get; set; }

    [JsonPropertyName("lastBlockUpdateTime")]
    public long LastBlockUpdateTime { get; set; }

    [JsonPropertyName("lastSyncBlock")]
    public string LastSyncBlock { get; set; }

    [JsonPropertyName("localDisconnectReason")]
    public string LocalDisconnectReason { get; set; }

    [JsonPropertyName("needSyncFromPeer")]
    public bool NeedSyncFromPeer { get; set; }

    [JsonPropertyName("needSyncFromUs")]
    public bool NeedSyncFromUs { get; set; }

    [JsonPropertyName("nodeCount")]
    public int NodeCount { get; set; }

    [JsonPropertyName("nodeId")]
    public string NodeId { get; set; }

    [JsonPropertyName("port")]
    public int Port { get; set; }

    [JsonPropertyName("remainNum")]
    public int RemainNum { get; set; }

    [JsonPropertyName("remoteDisconnectReason")]
    public string RemoteDisconnectReason { get; set; }

    [JsonPropertyName("score")]
    public int Score { get; set; }

    [JsonPropertyName("syncBlockRequestedSize")]
    public int SyncBlockRequestedSize { get; set; }

    [JsonPropertyName("syncFlag")]
    public bool SyncFlag { get; set; }

    [JsonPropertyName("syncToFetchSize")]
    public int SyncToFetchSize { get; set; }

    [JsonPropertyName("syncToFetchSizePeekNum")]
    public int SyncToFetchSizePeekNum { get; set; }

    [JsonPropertyName("unFetchSynNum")]
    public int UnFetchSynNum { get; set; }
}