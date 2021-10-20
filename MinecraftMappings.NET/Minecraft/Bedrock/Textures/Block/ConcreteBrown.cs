using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class ConcreteBrown : BedrockBlockTexture
    {
        public ConcreteBrown() : base("Concrete Brown")
        {
            AddVersion("concrete_brown")
                .MapsToJavaBlock<BrownConcrete>();
        }
    }
}
