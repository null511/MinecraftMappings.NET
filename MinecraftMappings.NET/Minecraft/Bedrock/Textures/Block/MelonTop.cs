using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class MelonTop : BedrockBlockTexture
    {
        public MelonTop() : base("Melon Top")
        {
            AddVersion("melon_top")
                .MapsToJavaBlock<Java.Textures.Block.MelonTop>();
        }
    }
}
