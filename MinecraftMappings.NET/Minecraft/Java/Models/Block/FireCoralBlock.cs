using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class FireCoralBlock : JavaBlockModel
    {
        public FireCoralBlock() : base("Fire Coral Block")
        {
            AddVersion("fire_coral_block", "1.14")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/fire_coral_block");
        }
    }
}
