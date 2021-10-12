using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class GlassPaneTopBlue : BedrockBlockData
    {
        public const string BlockId = "glass_pane_top_blue";
        public const string BlockName = "Glass Pane Top Blue";


        public GlassPaneTopBlue() : base(BlockName)
        {
            Versions.Add(new BedrockBlockDataVersion {
                Id = BlockId,
                MapsToJavaId = BlueStainedGlassPaneTop.BlockId,
            });
        }
    }
}
