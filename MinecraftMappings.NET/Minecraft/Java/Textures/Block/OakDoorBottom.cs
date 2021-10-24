using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OakDoorBottom : JavaBlockTexture
    {
        public OakDoorBottom() : base("Oak Door Bottom")
        {
            AddVersion("oak_door_bottom")
                .WithDefaultModel<Java.Models.Block.OakDoorBottom>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoorWoodLower>();
        }
    }
}
