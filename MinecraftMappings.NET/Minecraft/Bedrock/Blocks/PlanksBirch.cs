using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class PlanksBirch : BedrockBlockData
    {
        public const string BlockId = "planks_birch";
        public const string BlockName = "Planks Birch";


        public PlanksBirch() : base(BlockName)
        {
            Versions.Add(new BedrockBlockDataVersion {
                Id = BlockId,
                MapsToJavaId = BirchPlanks.BlockId,
            });
        }
    }
}
