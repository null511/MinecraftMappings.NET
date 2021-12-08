using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CrimsonRootsPot : JavaBlockTexture
    {
        public CrimsonRootsPot() : base("Crimson Roots, Pot")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("crimson_roots_pot");
                //.WithDefaultModel<Java.Models.Block.CrimsonRootsPot>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CrimsonRootsPot>();
        }
    }
}
