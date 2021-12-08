using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AzaleaTop : JavaBlockTexture
    {
        public AzaleaTop() : base("Azalea Top")
        {
            AddVersion(7, "azalea_top")
                .WithMinVersion("1.17")
                .WithDefaultModel<Java.Models.Block.Azalea>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LeavesAzalea>();
        }
    }
}
