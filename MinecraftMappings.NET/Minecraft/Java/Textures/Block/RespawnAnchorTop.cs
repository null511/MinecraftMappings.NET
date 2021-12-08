using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RespawnAnchorTop : JavaBlockTexture
    {
        public RespawnAnchorTop() : base("Respawn Anchor Top")
        {
            AddVersion("respawn_anchor_top");
                //.WithDefaultModel<Java.Models.Block.RespawnAnchorTop>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RespawnAnchorTop>();
        }
    }
}
