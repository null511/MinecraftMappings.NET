using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class LogBirch : BedrockBlockData
    {
        public const string BlockId = "log_birch";
        public const string BlockName = "Log Birch";


        public LogBirch() : base(BlockName)
        {
            Versions.Add(new BedrockBlockDataVersion {
                Id = BlockId,
                MapsToJavaId = BirchLog.BlockId,
            });
        }
    }
}
