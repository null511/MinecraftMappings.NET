using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Obsidian : JavaBlockTexture
    {
        public Obsidian() : base("Obsidian")
        {
            AddVersion("obsidian")
                .WithDefaultModel<Java.Models.Block.Obsidian>();
                //.MapsToBedrockBlock<BedrockBlocks.Obsidian>();
        }
    }
}
