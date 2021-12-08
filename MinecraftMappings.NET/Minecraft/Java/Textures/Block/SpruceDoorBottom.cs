using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SpruceDoorBottom : JavaBlockTexture
    {
        public SpruceDoorBottom() : base("Spruce Door Bottom")
        {
            AddVersion("spruce_door_bottom")
                .WithDefaultModel<Java.Models.Block.SpruceDoorBottom>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.SpruceDoorBottom>();
        }
    }
}
