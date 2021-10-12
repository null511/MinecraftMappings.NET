using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class FlowerBlueOrchid : BedrockBlockData
    {
        public const string BlockId = "flower_blue_orchid";
        public const string BlockName = "Flower Blue Orchid";


        public FlowerBlueOrchid() : base(BlockName)
        {
            Versions.Add(new BedrockBlockDataVersion {
                Id = BlockId,
                MapsToJavaBlock = typeof(BlueOrchid),
            });
        }
    }
}
