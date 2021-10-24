using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class LecternBase : BedrockBlockTexture
    {
        public LecternBase() : base("Lectern Base")
        {
            AddVersion("lectern_base")
                .MapsToJavaBlock<Java.Textures.Block.LecternBase>();
        }
    }
}
