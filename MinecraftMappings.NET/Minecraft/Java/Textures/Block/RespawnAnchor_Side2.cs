using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RespawnAnchor_Side2 : JavaBlockTexture
    {
        public RespawnAnchor_Side2() : base("Respawn Anchor, Side 2")
        {
            AddVersion("respawn_anchor_side2");
                //.WithDefaultModel<Java.Models.Block.RespawnAnchor_Side2>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RespawnAnchor_Side2>();
        }
    }
}
