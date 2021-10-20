using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class FurnaceTop : JavaBlockTexture
    {
        public FurnaceTop() : base("Furnace Top")
        {
            AddVersion("furnace_top")
                .WithDefaultModel<Java.Models.Block.Furnace>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FurnaceFrontOff>();
        }
    }
}
