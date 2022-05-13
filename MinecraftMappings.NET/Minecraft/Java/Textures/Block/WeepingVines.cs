using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WeepingVines : JavaBlockTexture
    {
        public WeepingVines() : base("Weeping Vines")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("weeping_vines")
                .WithDefaultModel<Java.Models.Block.WeepingVines>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WeepingVines>();
        }
    }
}
