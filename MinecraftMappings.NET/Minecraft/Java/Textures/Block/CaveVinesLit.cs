using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CaveVinesLit : JavaBlockTexture
    {
        public CaveVinesLit() : base("Cave Vines, Lit")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("cave_vines_lit");
                //.WithDefaultModel<Java.Models.Block.CaveVines>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CaveVines>();
        }
    }
}
