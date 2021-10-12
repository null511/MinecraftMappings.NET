using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class GlazedTerracottaBlack : BedrockBlockData
    {
        public const string BlockId = "glazed_terracotta_black";
        public const string BlockName = "Glazed Terracotta Black";


        public GlazedTerracottaBlack() : base(BlockName)
        {
            Versions.Add(new BedrockBlockDataVersion {
                Id = BlockId,
                MapsToJavaId = BlackGlazedTerracotta.BlockId,
            });
        }
    }
}
