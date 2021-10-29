using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class DoublePlant_RoseBottom : BedrockBlockTexture
    {
        public DoublePlant_RoseBottom() : base("Double-Plant, Rose Bottom")
        {
            AddVersion("double_plant_rose_bottom")
                .MapsToJavaBlock<Java.Textures.Block.RoseBushBottom>();
        }
    }
}
