using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CampfireLogLit : JavaBlockTexture
    {
        public CampfireLogLit() : base("Campfire Log, Lit")
        {
            AddVersion("campfire_log_lit")
                .WithDefaultModel<Java.Models.Block.Campfire>();
                //.MapsToBedrockBlock<BedrockBlocks.CampfireLogLit>();
        }
    }
}
