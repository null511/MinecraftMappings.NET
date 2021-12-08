using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeeNestSide : JavaBlockTexture
    {
        public BeeNestSide() : base("Bee Nest Side")
        {
            AddVersion(5, "bee_nest_side")
                .WithMinVersion("1.15")
                .WithDefaultModel<Java.Models.Block.BeeNest>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BeeNestSide>();
        }
    }
}
