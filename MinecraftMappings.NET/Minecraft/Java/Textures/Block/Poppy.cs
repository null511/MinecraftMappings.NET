using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Poppy : JavaBlockTexture
    {
        public Poppy() : base("Poppy")
        {
            AddVersion("poppy")
                .WithDefaultModel<Java.Models.Block.Poppy>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FlowerRose>();
        }
    }
}
