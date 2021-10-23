using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class TntSide : BedrockBlockTexture
    {
        public TntSide() : base("TNT Side")
        {
            AddVersion("tnt_side")
                .MapsToJavaBlock<Java.Textures.Block.TntSide>();
        }
    }
}
