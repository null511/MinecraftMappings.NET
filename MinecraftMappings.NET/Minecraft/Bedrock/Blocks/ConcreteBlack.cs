using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class ConcreteBlack : BedrockBlockTexture
    {
        public ConcreteBlack() : base("Concrete Black")
        {
            AddVersion("concrete_black")
                .MapsToJavaBlock<BlackConcrete>();
        }
    }
}
