using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlackConcretePowder : JavaBlockTexture
    {
        public BlackConcretePowder() : base("Black Concrete Powder")
        {
            AddVersion("black_concrete_powder")
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcretePowderBlack>();
        }
    }
}
