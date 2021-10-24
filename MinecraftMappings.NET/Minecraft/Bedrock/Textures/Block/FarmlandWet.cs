using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class FarmlandWet : BedrockBlockTexture
    {
        public FarmlandWet() : base("Farmland, Wet")
        {
            AddVersion("farmland_wet")
                .MapsToJavaBlock<Java.Textures.Block.FarmlandMoist>();
        }
    }
}
