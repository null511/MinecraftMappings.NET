using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class LecternFront : BedrockBlockTexture
    {
        public LecternFront() : base("Lectern Front")
        {
            AddVersion("lectern_front")
                .MapsToJavaBlock<Java.Textures.Block.LecternFront>();
        }
    }
}
