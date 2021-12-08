using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class TwistingVinesPlant : JavaBlockTexture
    {
        public TwistingVinesPlant() : base("Twisting Vines Plant")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("twisting_vines_plant");
                //.WithDefaultModel<Java.Models.Block.TwistingVinesPlant>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.TwistingVinesPlant>();
        }
    }
}
