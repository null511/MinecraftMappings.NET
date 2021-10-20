using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeeNestBottom : JavaBlockTexture
    {
        public BeeNestBottom() : base("Bee Nest Bottom")
        {
            AddVersion("bee_nest_bottom")
                .WithDefaultModel<Java.Models.Block.BeeNest>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BeeNestBottom>();
        }
    }
}
