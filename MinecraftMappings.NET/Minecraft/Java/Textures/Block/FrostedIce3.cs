using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class FrostedIce3 : JavaBlockTexture
    {
        public FrostedIce3() : base("Frosted Ice 3")
        {
            AddVersion("frosted_ice_3");
                //.WithDefaultModel<Java.Models.Block.FrostedIce>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FrostedIce3>();
        }
    }
}
