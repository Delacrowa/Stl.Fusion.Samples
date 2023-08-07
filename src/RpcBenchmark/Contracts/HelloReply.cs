using System.Runtime.Serialization;
using MemoryPack;

namespace Samples.RpcBenchmark;

[DataContract, MemoryPackable(GenerateType.VersionTolerant)]
public sealed partial class HelloReply
{
    [DataMember, MemoryPackOrder(0)] public Hello Response { get; set; } = null!;
}
