using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RespawnAnchor_Side3 : JavaBlockTexture
    {
        public RespawnAnchor_Side3() : base("Respawn Anchor, Side 3")
        {
            AddVersion("respawn_anchor_side3");
                //.WithDefaultModel<Java.Models.Block.RespawnAnchor_Side3>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RespawnAnchor_Side3>();
        }
    }
}
