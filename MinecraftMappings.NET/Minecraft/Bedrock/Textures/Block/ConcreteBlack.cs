using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
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
