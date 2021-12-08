using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PinkConcretePowder : JavaBlockTexture
    {
        public PinkConcretePowder() : base("Pink Concrete Powder")
        {
            AddVersion("pink_concrete_powder")
                .WithMinVersion("1.12");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcretePowderPink>();
        }
    }
}
