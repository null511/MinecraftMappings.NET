using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WarpedDoorBottom : JavaBlockTexture
    {
        public WarpedDoorBottom() : base("Warped Door Bottom")
        {
            AddVersion("warped_door_bottom")
                .WithDefaultModel<Java.Models.Block.WarpedDoorBottom>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WarpedDoorBottom>();
        }
    }
}
