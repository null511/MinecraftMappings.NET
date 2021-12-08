using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CrimsonNyliumSide : JavaBlockTexture
    {
        public CrimsonNyliumSide() : base("Crimson Nylium Side")
        {
            AddVersion("crimson_nylium_side");
                //.WithDefaultModel<Java.Models.Block.CrimsonNylium>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CrimsonNyliumSide>();
        }
    }
}
