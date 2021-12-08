using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RespawnAnchorTop_Off : JavaBlockTexture
    {
        public RespawnAnchorTop_Off() : base("Respawn Anchor Top, Off")
        {
            AddVersion("respawn_anchor_top_off");
                //.WithDefaultModel<Java.Models.Block.RespawnAnchorTop_Off>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RespawnAnchorTop_Off>();
        }
    }
}
