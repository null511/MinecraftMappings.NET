using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Models
{
    public class IronArmor_Layer2 : JavaEntityTexture
    {
        public IronArmor_Layer2() : base("Iron Armor, Layer 2")
        {
            AddVersion("iron_layer_2")
                .WithPath("models/armor")
                .WithDefaultModel<Java.Models.Entity.ArmorLayer2>();
                //.MapsToBedrockEntity<BedrockEntities.IronArmor_Layer2>();
        }
    }
}
