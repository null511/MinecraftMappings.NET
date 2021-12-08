using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PottedAzaleaBushTop : JavaBlockTexture
    {
        public PottedAzaleaBushTop() : base("Potted Azalea Bush Top")
        {
            AddVersion("potted_azalea_bush_top");
                //.WithDefaultModel<Java.Models.Block.PottedAzaleaBush>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PottedAzaleaBushTop>();
        }
    }
}
