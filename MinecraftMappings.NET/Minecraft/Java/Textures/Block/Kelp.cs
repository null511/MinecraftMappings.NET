using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Kelp : JavaBlockTexture
    {
        public Kelp() : base("Kelp")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("kelp")
                .WithDefaultModel<Java.Models.Block.Kelp>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.KelpTop>();
        }
    }
}
