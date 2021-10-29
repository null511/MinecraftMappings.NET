using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class LecternSides : BedrockBlockTexture
    {
        public LecternSides() : base("Lectern Sides")
        {
            AddVersion("lectern_sides")
                .MapsToJavaBlock<Java.Textures.Block.LecternSides>();
        }
    }
}
