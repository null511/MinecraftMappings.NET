using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class BeeNestSide : BedrockBlockTexture
    {
        public BeeNestSide() : base("Bee Nest Side")
        {
            AddVersion("bee_nest_side")
                .MapsToJavaBlock<Java.Textures.Block.BeeNestSide>();
        }
    }
}
