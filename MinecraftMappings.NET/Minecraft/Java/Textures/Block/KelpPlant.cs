using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class KelpPlant : JavaBlockTexture
    {
        public KelpPlant() : base("Kelp Plant")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("kelp_plant")
                .WithDefaultModel<Java.Models.Block.KelpPlant>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.KelpA>();
        }
    }
}
