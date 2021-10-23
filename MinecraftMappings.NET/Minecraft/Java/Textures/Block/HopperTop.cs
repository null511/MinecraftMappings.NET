using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class HopperTop : JavaBlockTexture
    {
        public HopperTop() : base("Hopper Top")
        {
            AddVersion("hopper_top")
                .WithMinVersion("1.5")
                .WithDefaultModel<Java.Models.Block.Hopper>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HopperTop>();
        }
    }
}
