using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class RedMushroomBlock : JavaBlockModel
    {
        public RedMushroomBlock() : base("Red Mushroom Block")
        {
            AddVersion("red_mushroom_block", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_single_face")
                .AddTexture("texture", "block/red_mushroom_block");
        }
    }
}
