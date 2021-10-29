using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class DoublePlant_FernBottom : BedrockBlockTexture
    {
        public DoublePlant_FernBottom() : base("Double-Plant, Fern Bottom")
        {
            AddVersion("double_plant_fern_bottom")
                .MapsToJavaBlock<Java.Textures.Block.LargeFernBottom>();
        }
    }
}
