using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WaterFlow : JavaBlockTexture
    {
        public WaterFlow() : base("Water Flow")
        {
            BlendMode = BlendModes.Transparent;

            AddVersion("water_flow");
                //.WithDefaultModel<Java.Models.Block.WaterFlow>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WaterFlow>();
        }
    }
}
