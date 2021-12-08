using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WeepingVinesPlant : JavaBlockTexture
    {
        public WeepingVinesPlant() : base("Weeping Vines Plant")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("weeping_vines_plant");
                //.WithDefaultModel<Java.Models.Block.WeepingVinesPlant>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WeepingVinesPlant>();
        }
    }
}
