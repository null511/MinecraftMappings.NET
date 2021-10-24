using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class FarmlandMoist : JavaBlockTexture
    {
        public FarmlandMoist() : base("Farmland, Moist")
        {
            AddVersion("farmland_moist")
                .WithMinVersion("1.0.0")
                .WithDefaultModel<Java.Models.Block.FarmlandMoist>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FarmlandWet>();
        }
    }
}
