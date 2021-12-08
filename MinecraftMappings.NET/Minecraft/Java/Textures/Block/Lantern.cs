using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Lantern : JavaBlockTexture
    {
        public Lantern() : base("Lantern")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("lantern")
                .WithDefaultModel<Java.Models.Block.Lantern>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Lantern>();
        }
    }
}
