using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BirchDoorBottom : JavaBlockTexture
    {
        public BirchDoorBottom() : base("Birch Door Bottom")
        {
            AddVersion(1, "birch_door_bottom")
                .WithMinVersion("1.8")
                .WithDefaultModel<Java.Models.Block.BirchDoorBottom>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoorBirchLower>();
        }
    }
}
