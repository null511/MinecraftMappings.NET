using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class LecternTop : BedrockBlockTexture
    {
        public LecternTop() : base("Lectern Top")
        {
            AddVersion("lectern_top")
                .MapsToJavaBlock<Java.Textures.Block.LecternTop>();
        }
    }
}
