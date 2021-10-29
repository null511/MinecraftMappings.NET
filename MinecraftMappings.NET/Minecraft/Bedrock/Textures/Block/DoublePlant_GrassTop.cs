using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class DoublePlant_GrassTop : BedrockBlockTexture
    {
        public DoublePlant_GrassTop() : base("Double-Plant, Grass Top")
        {
            AddVersion("double_plant_grass_top")
                .MapsToJavaBlock<Java.Textures.Block.TallGrassTop>();
        }
    }
}
