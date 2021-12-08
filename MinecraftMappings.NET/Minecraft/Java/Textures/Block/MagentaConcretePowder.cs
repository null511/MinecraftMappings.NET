using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class MagentaConcretePowder : JavaBlockTexture
    {
        public MagentaConcretePowder() : base("Magenta Concrete Powder")
        {
            AddVersion("magenta_concrete_powder")
                .WithMinVersion("1.12");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcretePowderMagenta>();
        }
    }
}
