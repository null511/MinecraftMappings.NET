using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WaterStill : JavaBlockTexture
    {
        public WaterStill() : base("Water Still")
        {
            BlendMode = BlendModes.Transparent;

            AddVersion("water_still");
                //.WithDefaultModel<Java.Models.Block.WaterStill>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WaterStill>();
        }
    }
}
