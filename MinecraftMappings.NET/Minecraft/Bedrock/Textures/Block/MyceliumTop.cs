using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class MyceliumTop : BedrockBlockTexture
    {
        public MyceliumTop() : base("Mycelium Top")
        {
            AddVersion("mycelium_top")
                .MapsToJavaBlock<Java.Textures.Block.MyceliumTop>();
        }
    }
}
