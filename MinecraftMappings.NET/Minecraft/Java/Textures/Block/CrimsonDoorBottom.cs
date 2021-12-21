using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CrimsonDoorBottom : JavaBlockTexture
    {
        public CrimsonDoorBottom() : base("Crimson Door Bottom")
        {
            AddVersion("crimson_door_bottom")
                .WithDefaultModel<Java.Models.Block.CrimsonDoorBottom>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoorCrimsonLower>();
        }
    }
}
