using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class FlowerHoustonia : BedrockBlockData
    {
        public const string BlockId = "flower_houstonia";
        public const string BlockName = "Flower Houstonia";


        public FlowerHoustonia() : base(BlockName)
        {
            Versions.Add(new BedrockBlockDataVersion {
                Id = BlockId,
                MapsToJavaBlock = typeof(AzureBluet),
            });
        }
    }
}
