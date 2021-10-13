using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BeeNestTop : BedrockBlockTexture
    {
        public BeeNestTop() : base("Bee Nest Top")
        {
            AddVersion("bee_nest_top")
                .MapsToJavaBlock<Java.Textures.Block.BeeNestTop>();
        }
    }
}
