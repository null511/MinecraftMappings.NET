using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class FurnaceTop : BedrockBlockTexture
    {
        public FurnaceTop() : base("Furnace Top")
        {
            AddVersion("furnace_top")
                .MapsToJavaBlock<Java.Textures.Block.FurnaceTop>();
        }
    }
}
