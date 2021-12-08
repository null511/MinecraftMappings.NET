using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BarrelBottom : JavaBlockTexture
    {
        public BarrelBottom() : base("Barrel Bottom")
        {
            AddVersion(4, "barrel_bottom")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.Barrel>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BarrelBottom>();
        }
    }
}
