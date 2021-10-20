using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CampfireLog : JavaBlockTexture
    {
        public CampfireLog() : base("Campfire Log")
        {
            AddVersion("campfire_log")
                .WithDefaultModel<Java.Models.Block.Campfire>();
                //.MapsToBedrockBlock<BedrockBlocks.CampfireLog>();
        }
    }
}
