using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class GlassBlack : BedrockBlockData
    {
        public const string BlockId = "glass_black";
        public const string BlockName = "Glass Black";


        public GlassBlack() : base(BlockName)
        {
            Versions.Add(new BedrockBlockDataVersion {
                Id = BlockId,
                MapsToJavaId = BlackStainedGlass.BlockId,
            });
        }
    }
}
