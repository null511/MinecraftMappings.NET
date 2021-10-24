using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ComposterTop : JavaBlockTexture
    {
        public ComposterTop() : base("Composter Top")
        {
            AddVersion("composter_top")
                .WithDefaultModel<Java.Models.Block.Composter>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ComposterTop>();
        }
    }
}
