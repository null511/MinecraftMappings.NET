using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class EndPortalFrameEye : JavaBlockTexture
    {
        public EndPortalFrameEye() : base("End Portal Frame Eye")
        {
            AddVersion("end_portal_frame_eye")
                .WithDefaultModel<Java.Models.Block.EndPortalFrame_Filled>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.EndPortalFrameEye>();
        }
    }
}
