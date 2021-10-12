using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class LeavesAcacia : BedrockBlockData
    {
        public const string BlockId = "leaves_acacia";
        public const string BlockName = "Leaves Acacia";


        public LeavesAcacia() : base(BlockName)
        {
            Versions.Add(new BedrockBlockDataVersion {
                Id = BlockId,
                MapsToJavaId = AcaciaLeaves.BlockId,
            });
        }
    }
}
