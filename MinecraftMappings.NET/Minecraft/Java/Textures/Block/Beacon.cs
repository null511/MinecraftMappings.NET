using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Beacon : JavaBlockTexture
    {
        public Beacon() : base("Beacon")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(0, "beacon")
                .WithMinVersion("1.4.2")
                .WithDefaultModel<Java.Models.Block.Beacon>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Beacon>();
        }
    }
}
