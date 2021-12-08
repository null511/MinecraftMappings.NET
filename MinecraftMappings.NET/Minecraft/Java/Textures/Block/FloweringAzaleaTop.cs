using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class FloweringAzaleaTop : JavaBlockTexture
    {
        public FloweringAzaleaTop() : base("Flowering Azalea Top")
        {
            AddVersion(7, "flowering_azalea_top")
                .WithMinVersion("1.17");
                //.WithDefaultModel<Java.Models.Block.FloweringAzalea>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LeavesAzaleaFloweringTop>();
        }
    }
}
