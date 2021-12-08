using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class FrostedIce2 : JavaBlockTexture
    {
        public FrostedIce2() : base("Frosted Ice 2")
        {
            AddVersion("frosted_ice_2");
                //.WithDefaultModel<Java.Models.Block.FrostedIce>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FrostedIce2>();
        }
    }
}
