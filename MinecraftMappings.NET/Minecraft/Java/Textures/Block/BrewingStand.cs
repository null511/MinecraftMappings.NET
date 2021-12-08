using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrewingStand : JavaBlockTexture
    {
        public BrewingStand() : base("Brewing Stand")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("brewing_stand")
                .WithDefaultModel<Java.Models.Block.BrewingStand>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BrewingStand>();
        }
    }
}
