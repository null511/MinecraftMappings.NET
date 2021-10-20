using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BirchDoorBottom : JavaBlockTexture
    {
        public BirchDoorBottom() : base("Birch Door Bottom")
        {
            AddVersion("birch_door_bottom")
                .WithDefaultModel<Java.Models.Block.BirchDoorBottom>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoorBirchLower>();
        }
    }
}
