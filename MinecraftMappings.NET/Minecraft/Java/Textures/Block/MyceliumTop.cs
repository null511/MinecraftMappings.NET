using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class MyceliumTop : JavaBlockTexture
    {
        public MyceliumTop() : base("Mycelium Top")
        {
            AddVersion("mycelium_top")
                .WithDefaultModel<Java.Models.Block.Mycelium>();
                //.MapsToBedrockBlock<BedrockBlocks.MyceliumTop>();
        }
    }
}
