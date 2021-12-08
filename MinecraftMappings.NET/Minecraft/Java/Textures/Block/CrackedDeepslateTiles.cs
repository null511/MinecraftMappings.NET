using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CrackedDeepslateTiles : JavaBlockTexture
    {
        public CrackedDeepslateTiles() : base("Cracked Deepslate Tiles")
        {
            AddVersion("cracked_deepslate_tiles");
                //.WithDefaultModel<Java.Models.Block.CrackedDeepslateTiles>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CrackedDeepslateTiles>();
        }
    }
}
