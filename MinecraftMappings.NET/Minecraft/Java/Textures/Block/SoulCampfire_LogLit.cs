using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SoulCampfire_LogLit : JavaBlockTexture
    {
        public SoulCampfire_LogLit() : base("Soul Campfire, Log Lit")
        {
            AddVersion("soul_campfire_log_lit");
                //.WithDefaultModel<Java.Models.Block.SoulCampfire>()
                //.MapsToBedrockBlock<BedrockBlocks.SoulCampfire_LogLit>();
        }
    }
}
