using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class ComposterTop : BedrockBlockTexture
    {
        public ComposterTop() : base("Composter Top")
        {
            AddVersion("composter_top")
                .MapsToJavaBlock<Java.Textures.Block.ComposterTop>();
        }
    }
}
