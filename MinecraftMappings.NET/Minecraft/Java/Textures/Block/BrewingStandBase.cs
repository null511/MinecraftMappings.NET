using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrewingStandBase : JavaBlockTexture
    {
        public BrewingStandBase() : base("Brewing Stand Base")
        {
            AddVersion("brewing_stand_base")
                .WithDefaultModel<Java.Models.Block.BrewingStand>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BrewingStandBase>();
        }
    }
}
