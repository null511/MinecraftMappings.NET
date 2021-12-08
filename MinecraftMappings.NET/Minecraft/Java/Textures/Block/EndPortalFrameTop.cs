using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class EndPortalFrameTop : JavaBlockTexture
    {
        public EndPortalFrameTop() : base("End Portal Frame Top")
        {
            AddVersion("end_portal_frame_top");
                //.WithDefaultModel<Java.Models.Block.EndPortalFrameTop>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.EndPortalFrameTop>();
        }
    }
}
