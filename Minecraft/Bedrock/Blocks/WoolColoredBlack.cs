using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class WoolColoredBlack : BedrockBlockData
    {
        public const string BlockId = "wool_colored_black";
        public const string BlockName = "Wool Colored Black";


        public WoolColoredBlack() : base(BlockName)
        {
            Versions.Add(new BedrockBlockDataVersion {
                Id = BlockId,
                MapsToJavaId = BlackWool.BlockId,
            });
        }
    }
}
