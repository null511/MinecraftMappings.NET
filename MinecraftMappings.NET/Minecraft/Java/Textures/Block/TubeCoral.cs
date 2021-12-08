using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class TubeCoral : JavaBlockTexture
    {
        public TubeCoral() : base("Tube Coral")
        {
            AddVersion("tube_coral");
                //.WithDefaultModel<Java.Models.Block.TubeCoral>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.TubeCoral>();
        }
    }
}
