using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DarkOakSapling : JavaBlockTexture
    {
        public DarkOakSapling() : base("Dark Oak Sapling")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("dark_oak_sapling")
                .WithDefaultModel<Java.Models.Block.DarkOakSapling>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.SaplingBigOak>();
        }
    }
}
