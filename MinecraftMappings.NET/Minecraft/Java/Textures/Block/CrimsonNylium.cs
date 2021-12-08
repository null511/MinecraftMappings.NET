using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CrimsonNylium : JavaBlockTexture
    {
        public CrimsonNylium() : base("Crimson Nylium")
        {
            AddVersion("crimson_nylium");
                //.WithDefaultModel<Java.Models.Block.CrimsonNylium>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CrimsonNylium>();
        }
    }
}
