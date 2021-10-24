using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class LodestoneSide : BedrockBlockTexture
    {
        public LodestoneSide() : base("Lodestone Side")
        {
            AddVersion("lodestone_side")
                .MapsToJavaBlock<Java.Textures.Block.LodestoneSide>();
        }
    }
}
