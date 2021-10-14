namespace MinecraftMappings.Minecraft.Java.Textures.Models
{
    public class IronArmor1 : Armor1
    {
        public IronArmor1() : base("Iron Armor [1]")
        {
            AddVersion("iron_layer_1", "1.0.0")
                //.WithPath("armor/iron_layer_1")
                .WithUVMappings(DefaultUVRegions);
        }
    }
}
