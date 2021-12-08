using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RespawnAnchor_Side4 : JavaBlockTexture
    {
        public RespawnAnchor_Side4() : base("Respawn Anchor, Side 4")
        {
            AddVersion("respawn_anchor_side4");
                //.WithDefaultModel<Java.Models.Block.RespawnAnchor_Side4>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RespawnAnchor_Side4>();
        }
    }
}
