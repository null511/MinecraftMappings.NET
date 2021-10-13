using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class ConcretePowderBrown : BedrockBlockTexture
    {
        public ConcretePowderBrown() : base("Concrete Powder Brown")
        {
            AddVersion("concrete_powder_brown")
                .MapsToJavaBlock<BrownConcretePowder>();
        }
    }
}
