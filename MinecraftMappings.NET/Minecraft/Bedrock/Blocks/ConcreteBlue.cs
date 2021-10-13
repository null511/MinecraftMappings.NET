using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class ConcreteBlue : BedrockBlockTexture
    {
        public ConcreteBlue() : base("Concrete Blue")
        {
            AddVersion("concrete_blue")
                .MapsToJavaBlock<BlueConcrete>();
        }
    }
}
