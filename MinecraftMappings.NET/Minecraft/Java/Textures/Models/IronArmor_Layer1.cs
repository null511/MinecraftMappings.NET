using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Models
{
    public class IronArmor_Layer1 : JavaEntityTexture
    {
        public IronArmor_Layer1() : base("Iron Armor, Layer 1")
        {
            AddVersion("iron_layer_1")
                .WithPath("models/armor")
                .WithDefaultModel<Java.Models.Entity.ArmorLayer1>();
                //.MapsToBedrockEntity<BedrockEntities.IronArmor_Layer1>();
        }
    }
}
