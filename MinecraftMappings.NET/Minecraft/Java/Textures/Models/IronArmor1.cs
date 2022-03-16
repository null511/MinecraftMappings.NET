using MinecraftMappings.Internal.Models.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Models
{
    public class IronArmor1 : JavaEntityModel
    {
        public IronArmor1() : base("Iron Armor [1]")
        {
            AddVersion("iron_layer_1", "1.0.0");
                //.WithPath("armor/iron_layer_1")
        }
    }
}
