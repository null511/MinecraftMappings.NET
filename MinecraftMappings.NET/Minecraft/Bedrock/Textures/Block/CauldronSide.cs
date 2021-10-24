using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class CauldronSide : BedrockBlockTexture
    {
        public CauldronSide() : base("Cauldron Side")
        {
            AddVersion("cauldron_side")
                .MapsToJavaBlock<Java.Textures.Block.CauldronSide>();
        }
    }
}
