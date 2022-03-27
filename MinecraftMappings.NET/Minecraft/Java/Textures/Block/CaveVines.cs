using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CaveVines : JavaBlockTexture
    {
        public CaveVines() : base("Cave Vines")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("cave_vines")
                .WithDefaultModel<Java.Models.Block.CaveVines>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CaveVines>();
        }
    }
}
