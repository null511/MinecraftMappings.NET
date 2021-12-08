using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeeNestFrontHoney : JavaBlockTexture
    {
        public BeeNestFrontHoney() : base("Bee Nest Front, Honey")
        {
            AddVersion(5, "bee_nest_front_honey")
                .WithMinVersion("1.15")
                .WithDefaultModel<Java.Models.Block.BeeNestHoney>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BeeNestFrontHoney>();
        }
    }
}
