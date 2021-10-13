using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BeeNestFrontHoney : BedrockBlockTexture
    {
        public BeeNestFrontHoney() : base("Bee Nest Front, Honey")
        {
            AddVersion("bee_nest_front_honey")
                .MapsToJavaBlock<Java.Textures.Block.BeeNestFrontHoney>();
        }
    }
}
