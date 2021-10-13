using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class ConcretePowderBlue : BedrockBlockTexture
    {
        public ConcretePowderBlue() : base("Concrete Powder Blue")
        {
            AddVersion("concrete_powder_blue")
                .MapsToJavaBlock<BlueConcretePowder>();
        }
    }
}
