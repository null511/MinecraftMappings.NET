using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedConcretePowder : JavaBlockTexture
    {
        public RedConcretePowder() : base("Red Concrete Powder")
        {
            AddVersion("red_concrete_powder")
                .WithMinVersion("1.12");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcretePowderRed>();
        }
    }
}
