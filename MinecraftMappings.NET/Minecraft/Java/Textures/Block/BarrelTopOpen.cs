using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BarrelTopOpen : JavaBlockTexture
    {
        public BarrelTopOpen() : base("Barrel Top, Open")
        {
            AddVersion(4, "barrel_top_open")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.BarrelOpen>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BarrelTopOpen>();
        }
    }
}
