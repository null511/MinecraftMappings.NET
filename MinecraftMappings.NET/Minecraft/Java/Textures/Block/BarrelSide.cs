using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BarrelSide : JavaBlockTexture
    {
        public BarrelSide() : base("Barrel Side")
        {
            AddVersion(4, "barrel_side")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.Barrel>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BarrelSide>();
        }
    }
}
