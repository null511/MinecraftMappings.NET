using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OakSapling : JavaBlockTexture
    {
        public OakSapling() : base("Oak Sapling")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("oak_sapling")
                .WithDefaultModel<Java.Models.Block.OakSapling>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.SaplingOak>();
        }
    }
}
