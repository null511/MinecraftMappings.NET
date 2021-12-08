using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OakDoorBottom : JavaBlockTexture
    {
        public OakDoorBottom() : base("Oak Door Bottom")
        {
            AddVersion("door_bottom")
                .WithMaxVersion("1.8")
                .WithDefaultModel<Java.Models.Block.OakDoorBottom>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoorWoodLower>();

            AddVersion("oak_door_bottom")
                .WithMinVersion("1.8")
                .WithDefaultModel<Java.Models.Block.OakDoorBottom>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoorWoodLower>();
        }
    }
}
