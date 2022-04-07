using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class ConcreteBlue : BedrockBlockTexture
    {
        public ConcreteBlue() : base("Concrete Blue")
        {
            AddVersion("concrete_blue")
                .MapsToJavaBlock<Java.Textures.Block.BlueConcrete>();
        }
    }
}
