using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class RoseBushTop : JavaBlockModel
    {
        public RoseBushTop() : base("Rose Bush Top")
        {
            AddVersion("rose_bush_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/rose_bush_top");
        }
    }
}
