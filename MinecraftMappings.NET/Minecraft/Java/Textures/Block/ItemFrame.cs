using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ItemFrame : JavaBlockTexture
    {
        public ItemFrame() : base("Item Frame")
        {
            AddVersion("item_frame");
                //.WithDefaultModel<Java.Models.Block.ItemFrame>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ItemFrame>();
        }
    }
}
