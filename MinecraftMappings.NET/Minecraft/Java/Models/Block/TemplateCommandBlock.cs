using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class TemplateCommandBlock : JavaBlockModel
    {
        public TemplateCommandBlock() : base("Template Command Block")
        {
            AddVersion("template_command_block", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_directional")
                .AddTexture("up", "#side")
                .AddTexture("down", "#side")
                .AddTexture("north", "#front")
                .AddTexture("south", "#back")
                .AddTexture("west", "#side")
                .AddTexture("east", "#side");
        }
    }
}
