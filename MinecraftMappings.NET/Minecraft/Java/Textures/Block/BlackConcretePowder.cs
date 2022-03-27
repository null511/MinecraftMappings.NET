using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlackConcretePowder : JavaBlockTexture
    {
        public BlackConcretePowder() : base("Black Concrete Powder")
        {
            AddVersion("black_concrete_powder")
                .WithDefaultModel<Java.Models.Block.BlackConcretePowder>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcretePowderBlack>();
        }
    }
}
