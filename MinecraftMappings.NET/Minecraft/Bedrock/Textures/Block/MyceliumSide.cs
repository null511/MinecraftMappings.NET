using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class MyceliumSide : BedrockBlockTexture
    {
        public MyceliumSide() : base("Mycelium Side")
        {
            AddVersion("mycelium_side")
                .MapsToJavaBlock<Java.Textures.Block.MyceliumSide>();
        }
    }
}
