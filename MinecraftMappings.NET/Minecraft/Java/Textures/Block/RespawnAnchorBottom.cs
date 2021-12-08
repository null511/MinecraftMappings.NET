using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RespawnAnchorBottom : JavaBlockTexture
    {
        public RespawnAnchorBottom() : base("Respawn Anchor Bottom")
        {
            AddVersion("respawn_anchor_bottom");
                //.WithDefaultModel<Java.Models.Block.RespawnAnchorBottom>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RespawnAnchorBottom>();
        }
    }
}
