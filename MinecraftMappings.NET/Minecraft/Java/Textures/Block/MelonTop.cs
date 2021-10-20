using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class MelonTop : JavaBlockTexture
    {
        public MelonTop() : base("Melon Top")
        {
            AddVersion("melon_top")
                .WithDefaultModel<Java.Models.Block.Melon>();
                //.MapsToBedrockBlock<BedrockBlocks.MelonTop>();
        }
    }
}
