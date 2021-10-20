using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeeNestSide : JavaBlockTexture
    {
        public BeeNestSide() : base("Bee Nest Side")
        {
            AddVersion("bee_nest_side")
                .WithDefaultModel<Java.Models.Block.BeeNest>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BeeNestSide>();
        }
    }
}
