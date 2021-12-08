using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WarpedNyliumSide : JavaBlockTexture
    {
        public WarpedNyliumSide() : base("Warped Nylium Side")
        {
            AddVersion("warped_nylium_side");
                //.WithDefaultModel<Java.Models.Block.WarpedNylium>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WarpedNyliumSide>();
        }
    }
}
