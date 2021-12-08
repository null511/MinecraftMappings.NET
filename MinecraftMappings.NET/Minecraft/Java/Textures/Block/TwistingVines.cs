using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class TwistingVines : JavaBlockTexture
    {
        public TwistingVines() : base("Twisting Vines")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("twisting_vines");
                //.WithDefaultModel<Java.Models.Block.TwistingVines>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.TwistingVines>();
        }
    }
}
