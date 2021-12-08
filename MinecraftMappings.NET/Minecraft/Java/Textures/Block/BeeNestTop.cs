using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeeNestTop : JavaBlockTexture
    {
        public BeeNestTop() : base("Bee Nest Top")
        {
            AddVersion(5, "bee_nest_top")
                .WithMinVersion("1.15")
                .WithDefaultModel<Java.Models.Block.BeeNest>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BeeNestTop>();
        }
    }
}
