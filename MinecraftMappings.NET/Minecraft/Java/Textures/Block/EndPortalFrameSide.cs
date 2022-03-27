using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class EndPortalFrameSide : JavaBlockTexture
    {
        public EndPortalFrameSide() : base("End Portal Frame Side")
        {
            AddVersion("end_portal_frame_side")
                .WithDefaultModel<Java.Models.Block.EndPortalFrame>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.EndPortalFrameSide>();
        }
    }
}
