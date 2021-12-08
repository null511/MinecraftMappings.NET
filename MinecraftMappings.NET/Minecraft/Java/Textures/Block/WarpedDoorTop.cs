using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WarpedDoorTop : JavaBlockTexture
    {
        public WarpedDoorTop() : base("Warped Door Top")
        {
            AddVersion("warped_door_top");
                //.WithDefaultModel<Java.Models.Block.WarpedDoorTop>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WarpedDoorTop>();
        }
    }
}
