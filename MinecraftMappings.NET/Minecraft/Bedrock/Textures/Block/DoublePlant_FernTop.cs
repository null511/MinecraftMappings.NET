using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class DoublePlant_FernTop : BedrockBlockTexture
    {
        public DoublePlant_FernTop() : base("Double-Plant, Fern Top")
        {
            AddVersion("double_plant_fern_top")
                .MapsToJavaBlock<Java.Textures.Block.LargeFernTop>();
        }
    }
}
