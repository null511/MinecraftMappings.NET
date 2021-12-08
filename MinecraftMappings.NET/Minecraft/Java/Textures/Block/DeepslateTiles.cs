using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeepslateTiles : JavaBlockTexture
    {
        public DeepslateTiles() : base("Deepslate Tiles")
        {
            AddVersion("deepslate_tiles");
                //.WithDefaultModel<Java.Models.Block.DeepslateTiles>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeepslateTiles>();
        }
    }
}
