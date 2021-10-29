using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class DoublePlant_RoseTop : BedrockBlockTexture
    {
        public DoublePlant_RoseTop() : base("Double-Plant, Rose Top")
        {
            AddVersion("double_plant_rose_top")
                .MapsToJavaBlock<Java.Textures.Block.RoseBushTop>();
        }
    }
}
