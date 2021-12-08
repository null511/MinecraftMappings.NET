using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LightGrayConcretePowder : JavaBlockTexture
    {
        public LightGrayConcretePowder() : base("Light Gray Concrete Powder")
        {
            AddVersion("light_gray_concrete_powder")
                .WithMinVersion("1.12");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcretePowderLightGray>();
        }
    }
}
