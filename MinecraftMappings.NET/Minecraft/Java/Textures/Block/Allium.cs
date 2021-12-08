using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Allium : JavaBlockTexture
    {
        public Allium() : base("Allium")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(1, "allium")
                .WithMinVersion("1.7.2")
                .WithDefaultModel<Java.Models.Block.Allium>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FlowerAllium>();
        }
    }
}
