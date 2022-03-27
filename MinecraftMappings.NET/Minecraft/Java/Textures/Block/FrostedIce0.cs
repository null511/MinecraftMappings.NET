using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class FrostedIce0 : JavaBlockTexture
    {
        public FrostedIce0() : base("Frosted Ice 0")
        {
            AddVersion("frosted_ice_0")
                .WithDefaultModel<Java.Models.Block.FrostedIce0>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FrostedIce0>();
        }
    }
}
