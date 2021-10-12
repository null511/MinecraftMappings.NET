using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class ShulkerTopBlack : BedrockBlockData
    {
        public const string BlockId = "shulker_top_black";
        public const string BlockName = "Shulker Top Black";


        public ShulkerTopBlack() : base(BlockName)
        {
            Versions.Add(new BedrockBlockDataVersion {
                Id = BlockId,
                MapsToJavaId = BlackShulkerBox.BlockId,
            });
        }
    }
}
