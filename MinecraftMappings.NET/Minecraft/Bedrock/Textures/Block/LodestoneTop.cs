using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class LodestoneTop : BedrockBlockTexture
    {
        public LodestoneTop() : base("Lodestone Top")
        {
            AddVersion("lodestone_top")
                .MapsToJavaBlock<Java.Textures.Block.LodestoneTop>();
        }
    }
}
