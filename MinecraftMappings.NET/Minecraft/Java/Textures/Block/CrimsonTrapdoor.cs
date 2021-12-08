using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CrimsonTrapdoor : JavaBlockTexture
    {
        public CrimsonTrapdoor() : base("Crimson Trapdoor")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("crimson_trapdoor");
                //.WithDefaultModel<Java.Models.Block.CrimsonTrapdoorTop>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CrimsonTrapdoor>();
        }
    }
}
