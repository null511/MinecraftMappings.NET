using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CrimsonRoots : JavaBlockTexture
    {
        public CrimsonRoots() : base("Crimson Roots")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("crimson_roots")
                .WithDefaultModel<Java.Models.Block.CrimsonRoots>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CrimsonRoots>();
        }
    }
}
