using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GrayConcretePowder : JavaBlockTexture
    {
        public GrayConcretePowder() : base("Gray Concrete Powder")
        {
            AddVersion("gray_concrete_powder")
                .WithMinVersion("1.12");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcretePowderGray>();
        }
    }
}
