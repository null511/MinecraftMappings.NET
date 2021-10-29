using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class DoublePlant_GrassBottom : BedrockBlockTexture
    {
        public DoublePlant_GrassBottom() : base("Double-Plant, Grass Bottom")
        {
            AddVersion("double_plant_grass_bottom")
                .MapsToJavaBlock<Java.Textures.Block.TallGrassBottom>();
        }
    }
}
