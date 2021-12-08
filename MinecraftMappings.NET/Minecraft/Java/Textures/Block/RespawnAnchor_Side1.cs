using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RespawnAnchor_Side1 : JavaBlockTexture
    {
        public RespawnAnchor_Side1() : base("Respawn Anchor, Side 1")
        {
            AddVersion("respawn_anchor_side1");
                //.WithDefaultModel<Java.Models.Block.RespawnAnchor_Side1>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RespawnAnchor_Side1>();
        }
    }
}
