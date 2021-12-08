using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeeNestBottom : JavaBlockTexture
    {
        public BeeNestBottom() : base("Bee Nest Bottom")
        {
            AddVersion(5, "bee_nest_bottom")
                .WithMinVersion("1.15")
                .WithDefaultModel<Java.Models.Block.BeeNest>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BeeNestBottom>();
        }
    }
}
