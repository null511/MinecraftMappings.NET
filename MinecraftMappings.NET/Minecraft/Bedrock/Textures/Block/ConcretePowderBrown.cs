using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class ConcretePowderBrown : BedrockBlockTexture
    {
        public ConcretePowderBrown() : base("Concrete Powder Brown")
        {
            AddVersion("concrete_powder_brown")
                .MapsToJavaBlock<Java.Textures.Block.BrownConcretePowder>();
        }
    }
}
