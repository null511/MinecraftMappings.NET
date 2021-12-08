using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class IronDoorBottom : JavaBlockTexture
    {
        public IronDoorBottom() : base("Iron Door Bottom")
        {
            AddVersion("iron_door_bottom");
                //.WithDefaultModel<Java.Models.Block.IronDoorBottom>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoorIronLower>();
        }
    }
}
