using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WarpedNylium : JavaBlockTexture
    {
        public WarpedNylium() : base("Warped Nylium")
        {
            AddVersion("warped_nylium")
                .WithDefaultModel<Java.Models.Block.WarpedNylium>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WarpedNylium>();
        }
    }
}
