using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeeNestFront : JavaBlockTexture
    {
        public BeeNestFront() : base("Bee Nest Front")
        {
            AddVersion(5, "bee_nest_front")
                .WithMinVersion("1.15")
                .WithDefaultModel<Java.Models.Block.BeeNest>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BeeNestFront>();
        }
    }
}
