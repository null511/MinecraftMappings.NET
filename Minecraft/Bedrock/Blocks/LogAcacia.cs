using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class LogAcacia : BedrockBlockData
    {
        public const string BlockId = "log_acacia";
        public const string BlockName = "Log Acacia";


        public LogAcacia() : base(BlockName)
        {
            AddVersion(BlockId, version => {
                version.MapsToJavaId = AcaciaLog.BlockId;
            });
        }
    }
}
