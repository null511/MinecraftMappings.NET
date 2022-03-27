using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrownConcretePowder : JavaBlockTexture
    {
        public BrownConcretePowder() : base("Brown Concrete Powder")
        {
            AddVersion("brown_concrete_powder")
                .WithDefaultModel<Java.Models.Block.BrownConcretePowder>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcretePowderBrown>();
        }
    }
}
