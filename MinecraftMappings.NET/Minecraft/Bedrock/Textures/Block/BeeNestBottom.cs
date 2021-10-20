using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class BeeNestBottom : BedrockBlockTexture
    {
        public BeeNestBottom() : base("Bee Nest Bottom")
        {
            AddVersion("bee_nest_bottom")
                .MapsToJavaBlock<Java.Textures.Block.BeeNestBottom>();
        }
    }
}
