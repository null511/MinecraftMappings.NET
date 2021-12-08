using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GreenConcretePowder : JavaBlockTexture
    {
        public GreenConcretePowder() : base("Green Concrete Powder")
        {
            AddVersion("green_concrete_powder")
                .WithMinVersion("1.12");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcretePowderGreen>();
        }
    }
}
