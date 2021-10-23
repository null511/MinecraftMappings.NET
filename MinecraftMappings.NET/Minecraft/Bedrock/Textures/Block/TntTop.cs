using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class TntTop : BedrockBlockTexture
    {
        public TntTop() : base("TNT Top")
        {
            AddVersion("tnt_top")
                .MapsToJavaBlock<Java.Textures.Block.TntTop>();
        }
    }
}
