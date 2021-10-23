using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LodestoneTop : JavaBlockTexture
    {
        public LodestoneTop() : base("Lodestone Top")
        {
            AddVersion("lodestone_top")
                .WithDefaultModel<Java.Models.Block.Lodestone>();
                //.MapsToBedrockBlock<BedrockBlocks.LodestoneTop>();
        }
    }
}
