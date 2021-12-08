using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AncientDebrisSide : JavaBlockTexture
    {
        public AncientDebrisSide() : base("Ancient Debris, Side")
        {
            AddVersion(5, "ancient_debris_side")
                .WithMinVersion("1.16")
                .WithDefaultModel<Java.Models.Block.AncientDebris>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.AncientDebrisSide>();
        }
    }
}
