using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class MelonSide : BedrockBlockTexture
    {
        public MelonSide() : base("Melon Side")
        {
            AddVersion("melon_side")
                .MapsToJavaBlock<Java.Textures.Block.MelonSide>();
        }
    }
}
