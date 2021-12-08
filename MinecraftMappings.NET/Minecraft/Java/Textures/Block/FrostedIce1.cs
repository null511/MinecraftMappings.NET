using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class FrostedIce1 : JavaBlockTexture
    {
        public FrostedIce1() : base("Frosted Ice 1")
        {
            AddVersion("frosted_ice_1");
                //.WithDefaultModel<Java.Models.Block.FrostedIce>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FrostedIce1>();
        }
    }
}
