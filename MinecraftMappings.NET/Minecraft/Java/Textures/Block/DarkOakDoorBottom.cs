using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DarkOakDoorBottom : JavaBlockTexture
    {
        public DarkOakDoorBottom() : base("Dark Oak Door Bottom")
        {
            AddVersion("dark_oak_door_bottom")
                .WithMinVersion("1.8");
                //.WithDefaultModel<Java.Models.Block.DarkOakDoorBottom>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoorBigOakLower>();
        }
    }
}
