using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class JungleDoorBottom : JavaBlockTexture
    {
        public JungleDoorBottom() : base("Jungle Door Bottom")
        {
            AddVersion("jungle_door_bottom");
                //.WithDefaultModel<Java.Models.Block.JungleDoorBottom>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoorJungleLower>();
        }
    }
}
