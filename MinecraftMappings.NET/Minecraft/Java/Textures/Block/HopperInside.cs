using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class HopperInside : JavaBlockTexture
    {
        public HopperInside() : base("Hopper Inside")
        {
            AddVersion("hopper_inside")
                .WithMinVersion("1.5")
                .WithDefaultModel<Java.Models.Block.Hopper>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HopperInside>();
        }
    }
}
